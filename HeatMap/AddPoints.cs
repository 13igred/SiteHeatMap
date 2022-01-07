using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace HeatMap
{
    public partial class AddPoints : Form
    {
        private int x;
        private int y;
        private string filePath;
        private Site site;
        private int DIAMETER = 10;
        private bool mouseDown;
        private Point lastLocation;
        private Point newLocation;
        private Point firstPoint;
        private int zoomValue = 2;
        private int dotTracker = -1;


        public AddPoints()
        {
            InitializeComponent();            
            Setup();
        }

        private void Setup()
        {
            cbControl();
            panMain.AutoScroll = true;
            panMain.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            //panMain.Height += -75;
            pbFactory.Width = panMain.Width;
            pbFactory.Height = panMain.Height;
            pbFactory.SizeMode = PictureBoxSizeMode.AutoSize;
            filePath = Directory.GetCurrentDirectory() + "\\SiteLayout.png";
            string picLocation = Directory.GetCurrentDirectory() + "\\Zooms\\04Zoom.png";
            Bitmap img = new Bitmap(picLocation);
            pbFactory.Image = img;
            SerializeObject();
            pbFactory.Refresh();
        }

        private void cbControl()
        {
            cbArea.Items.Add("CKF3");
            cbArea.Items.Add("GW");
            cbArea.Items.Add("TC");
            cbArea.Items.Add("CER");
            cbArea.Items.Add("CKF2");
            cbArea.Items.Add("PC");
            cbArea.Items.Add("MP");
            cbArea.Items.Add("FCC");            
        }

        private void pbFactory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                var relativePoint = me.Location;
                panPopUp.Location = new Point(10 + relativePoint.X + panMain.AutoScrollPosition.X, relativePoint.Y + panMain.AutoScrollPosition.Y + 10);
                panPopUp.Visible = true;
                panPopUp.BringToFront();
                x = relativePoint.X;
                y = relativePoint.Y;
            }

            if (e.Button.HasFlag(MouseButtons.Left) & !mouseDown)
            {
                firstPoint.X = e.X + panMain.AutoScrollPosition.X;
                firstPoint.Y = e.Y + panMain.AutoScrollPosition.Y;
                mouseDown = true;
            }
        }

        private void pbFactory_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
            {                
                int xLoc = e.X + lastLocation.X - firstPoint.X;
                if(xLoc > 14250)
                {
                    xLoc = 14250;
                }
                if(xLoc < 0)
                {
                    xLoc = 0;
                }     
                
                int yLoc = e.Y + lastLocation.Y - firstPoint.Y;
                if (yLoc > 22910)
                {
                    yLoc = 22910;
                }
                if (yLoc < 0)
                {
                    yLoc = 0;
                }

                newLocation = new Point((panMain.AutoScrollPosition.X) + (xLoc), (panMain.AutoScrollPosition.Y) + (yLoc));
                panMain.AutoScrollPosition = newLocation;
            }

            for (int i = 0; i < site.Items.Length; i++)
            {                
                if (site.Items[i].CoordinateX != "" && !site.Items[i].CoordinateX.Equals("\n    ") && (e.Location.X > (Int32.Parse(site.Items[i].CoordinateX) * ((float)zoomValue / 5)) - 2 && e.Location.X < (Int32.Parse(site.Items[i].CoordinateX) * ((float)zoomValue / 5)) + 2) && (e.Location.Y > (Int32.Parse(site.Items[i].CoordinateY) * ((float)zoomValue / 5)) - 2 && e.Location.Y < (Int32.Parse(site.Items[i].CoordinateY) * ((float)zoomValue / 5)) + 2))
                {
                    panDotInfo.Visible = true;
                    panDotInfo.Location =  new Point(e.Location.X + panMain.AutoScrollPosition.X + 20, e.Location.Y + panMain.AutoScrollPosition.Y);
                    lblArea.Text = site.Items[i].Area;
                    lblDesc.Text = site.Items[i].Description;
                    lblSapNo.Text = site.Items[i].ID;
                    dotTracker = i;
                }                
            }

            if (dotTracker != -1 && (e.Location.X < (Int32.Parse(site.Items[dotTracker].CoordinateX) * ((float)zoomValue / 5)) - 2 || e.Location.X > (Int32.Parse(site.Items[dotTracker].CoordinateX) * ((float)zoomValue / 5)) + 2 || e.Location.Y < (Int32.Parse(site.Items[dotTracker].CoordinateY) * ((float)zoomValue / 5)) - 2 || e.Location.Y > (Int32.Parse(site.Items[dotTracker].CoordinateY) + 2) * ((float)zoomValue / 5)))
            {
                panDotInfo.Visible = false;
                dotTracker = -1;
            }
        }

        private void pbFactory_MouseUp(object sender, MouseEventArgs e)
        {
            lastLocation = newLocation;
            mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panPopUp.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string result = filePath.Remove(filePath.Length - 4);
            UpdateXML uxml = new UpdateXML(txtSAPID.Text, cbArea.SelectedItem.ToString(), txtDesc.Text, x, y, result);
            panPopUp.Visible = false;
            SerializeObject();
            pbFactory.Refresh();
        }

        private void pbFactory_Paint(object sender, PaintEventArgs e)            
        {
            if (site != null)
            {
                for (int i = 0; i < site.Items.Length; i++)
                {
                    if (site.Items[i].CoordinateX != "" && !site.Items[i].CoordinateX.Equals("\n    "))
                    {
                        SolidBrush sb = new SolidBrush(Color.FromArgb(70, 0, 0, 128));

                        float x = (float.Parse(site.Items[i].CoordinateX) * ((float)zoomValue / 5)) - ((DIAMETER + (site.Items[i].circleScale / 2)) / 2);
                        float y = (float.Parse(site.Items[i].CoordinateY) * ((float)zoomValue / 5)) - ((DIAMETER + (site.Items[i].circleScale / 2)) / 2);

                        e.Graphics.FillEllipse(sb, x, y, (DIAMETER + (site.Items[i].circleScale / 2)), (DIAMETER + (site.Items[i].circleScale / 2)));
                    }
                }
            }
        }

        // From a XML Sheet creates a new instance of objects - currently just CKF3 will need to add more.
        // created using xsd.exe in cmd line.
        // cd C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools
        // xsd.exe "filepath" -> creates xsd file from xml
        // xsd.exe "xsd file name" /classes -> create c# class file
        public void SerializeObject()
        {
            string result = filePath.Remove(filePath.Length - 4) + ".xml";
            XmlSerializer ser = new XmlSerializer(typeof(Site));
            using (XmlReader reader = XmlReader.Create(result))
            {
                site = (Site)ser.Deserialize(reader);
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if(zoomValue < 5)
            {
                zoomValue += 1;
            }
            PictureZoomControl();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (zoomValue > 2)
            {
                zoomValue -= 1;
            }
            PictureZoomControl();
        }

        private void PictureZoomControl()
        {
            string filename = Directory.GetCurrentDirectory() + "//Zooms//";

            if(zoomValue == 5)
            {
                filename += "10Zoom.png";
            }
            else if(zoomValue == 4)
            {
                filename += "08Zoom.png";
            }
            else if (zoomValue == 3)
            {
                filename += "06Zoom.png";
            }
            else if (zoomValue == 2)
            {
                filename += "04Zoom.png";
            }

            pbFactory.Image = new Bitmap(filename);
            pbFactory.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAnal_Click(object sender, EventArgs e)
        {
            var frm = new AnalData();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            this.Hide();
            frm.Show();
        }
    }
}
