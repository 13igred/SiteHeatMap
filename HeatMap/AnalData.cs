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
    public partial class AnalData : Form
    {
        private Site site;
        private const int DIAMETER = 25;
        private int maxJobCount = 0;
        private int minJobCount = 0;
        private int zoomValue = 5;
        private int dotTracker = -1;

        public AnalData()
        {
            string filePath = Directory.GetCurrentDirectory() + "\\SiteLayout.xml";
            InitializeComponent();            
            SerializeObject(filePath);            
            panMain.AutoScroll = true;
            pbFactory.SizeMode = PictureBoxSizeMode.AutoSize;
            Bitmap img = new Bitmap(Directory.GetCurrentDirectory() + "\\SiteLayout.png");
            pbFactory.Image = img;
            pbFactory.Refresh();
        }

        private void AddData()
        {
            ExcelReader ER = new ExcelReader();

            for (int i = 0; i < ER.data.Length; i++)
            {
                for (int j = 0; j < site.Items.Length; j++)
                {
                    if(ER.data[i].StringData.Equals(site.Items[j].ID))
                    {
                        site.Items[j].count = ER.data[i].IntData;
                    }
                }
            }

            //Init values
            maxJobCount = site.Items[0].count;
            minJobCount = site.Items[1].count;

            for (int i = 0; i < site.Items.Length; i++)
            {
                if (site.Items[i].count > maxJobCount)
                {
                    maxJobCount = site.Items[i].count;
                }

                if (site.Items[i].count < minJobCount)
                {
                    minJobCount = site.Items[i].count;
                }
            }

            for (int i = 0; i < site.Items.Length; i++)
            {
                if (site.Items[i].CoordinateX != "")
                {
                    CalculateHeatMap(i);
                }

            }
        }



        public void CalculateHeatMap(int index)
        {
            // as count increases red first increases then green decreases
            //calculate steps
            //For each count in each area i want to change the colour by a step amount. 
            // max = 255, 0 min = 0,255
            double stepSize = (510 / (maxJobCount - minJobCount));

            int scale = (int)Math.Floor((site.Items[index].count - minJobCount) * stepSize);

            if((scale - 255) > 0)
            {
                site.Items[index].redAmt = 255;
                site.Items[index].greenAmt = 255 - (scale - 255);
            }
            else
            {
                site.Items[index].redAmt = 0;
                site.Items[index].greenAmt = 255 - scale;
            }

            site.Items[index].circleScale = (int)Math.Ceiling((double)site.Items[index].count / maxJobCount * 100);
        }

        // From a XML Sheet creates a new instance of objects - currently just CKF3 will need to add more.
        // created using xsd.exe in cmd line. XML -> XSD -> XSD /classes 
        public void SerializeObject(string fileName)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Site));
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                site = (Site)ser.Deserialize(reader);
            }                        
        }

        // Paint a circle at the point given in the XML file.
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {           
            for (int i = 0; i < site.Items.Length; i++)
            {
                if (site.Items[i].CoordinateX != "" && site.Items[i].count > 0)
                {
                    SolidBrush sb = new SolidBrush(Color.FromArgb(70, site.Items[i].redAmt, site.Items[i].greenAmt, 0));
                    e.Graphics.FillEllipse(sb, float.Parse(site.Items[i].CoordinateX) - ((DIAMETER + (site.Items[i].circleScale / 2)) / 2), float.Parse(site.Items[i].CoordinateY) - ((DIAMETER + (site.Items[i].circleScale / 2)) / 2), (DIAMETER + (site.Items[i].circleScale / 2)), (DIAMETER + (site.Items[i].circleScale / 2)));
                }
            }            
        }


        // Detects a mouse click event.
        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                var relativePoint = me.Location;
                for (int i = 0; i < site.Items.Length; i++)
                {
                    if (site.Items[i].CoordinateX != "")
                    {
                        bool inA = InsideCircle(int.Parse(site.Items[i].CoordinateX), int.Parse(site.Items[i].CoordinateY), (DIAMETER + (site.Items[i].circleScale / 2)) / 2, relativePoint.X, relativePoint.Y);
                        if (inA)
                        {
                            lblItemDesc.Text = "Description: " + site.Items[i].Description + " Jobs Raised: " + site.Items[i].count + " SAP ID: " + site.Items[i].ID;
                            break;
                        }
                    }
                }
            }
        }

        //Xc,Yc is center of circle, r is radias, x,y is given from click pos. 
        public static bool InsideCircle(int xc, int yc, int r, int x, int y)
        {
            int dx = xc - x;
            int dy = yc - y;
            return dx * dx + dy * dy <= r * r;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < site.Items.Length; i++)
            {
                if (site.Items[i].CoordinateX != "" && !site.Items[i].CoordinateX.Equals("\n    ") && (e.Location.X > (Int32.Parse(site.Items[i].CoordinateX) * ((float)zoomValue / 5)) - 2 && e.Location.X < (Int32.Parse(site.Items[i].CoordinateX) * ((float)zoomValue / 5)) + 2) && (e.Location.Y > (Int32.Parse(site.Items[i].CoordinateY) * ((float)zoomValue / 5)) - 2 && e.Location.Y < (Int32.Parse(site.Items[i].CoordinateY) * ((float)zoomValue / 5)) + 2))
                {
                    panDotInfo.Visible = true;
                    panDotInfo.Location = new Point(e.Location.X + panMain.AutoScrollPosition.X + 20, e.Location.Y + panMain.AutoScrollPosition.Y);
                    lblArea.Text = site.Items[i].Area;
                    lblDesc.Text = site.Items[i].Description;
                    lblSapNo.Text = site.Items[i].ID;
                    lblJobsNo.Text = site.Items[i].count.ToString();
                    dotTracker = i;
                }
            }

            if (dotTracker != -1 && (e.Location.X < (Int32.Parse(site.Items[dotTracker].CoordinateX) * ((float)zoomValue / 5)) - 2 || e.Location.X > (Int32.Parse(site.Items[dotTracker].CoordinateX) * ((float)zoomValue / 5)) + 2 || e.Location.Y < (Int32.Parse(site.Items[dotTracker].CoordinateY) * ((float)zoomValue / 5)) - 2 || e.Location.Y > (Int32.Parse(site.Items[dotTracker].CoordinateY) + 2) * ((float)zoomValue / 5)))
            {
                panDotInfo.Visible = false;
                dotTracker = -1;
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (zoomValue < 5)
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

            if (zoomValue == 5)
            {
                filename += "10Zoom.png";
            }
            else if (zoomValue == 4)
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
    }
}
