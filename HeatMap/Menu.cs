using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatMap
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SetupScreen();
        }

        private void SetupScreen()
        {
            // run button
            btnRun.Left = (this.ClientSize.Width - btnRun.Width) / 2;
            btnRun.Top = (100 - btnRun.Height);

            // update point button
            bntUpdatePoint.Left = (this.ClientSize.Width - bntUpdatePoint.Width) / 2;
            bntUpdatePoint.Top = (200 - bntUpdatePoint.Height);

            //Quit button
            btnQuit.Left = (this.ClientSize.Width - btnQuit.Width) / 2;
            btnQuit.Top = (this.ClientSize.Height - (btnQuit.Height+100));
        }

        private void Form_SizedChanged(object sender, EventArgs e)
        {
            // run button
            btnRun.Left = (this.ClientSize.Width - btnRun.Width) / 2;
            btnRun.Top = (100 - btnRun.Height);

            // update point button
            bntUpdatePoint.Left = (this.ClientSize.Width - bntUpdatePoint.Width) / 2;
            bntUpdatePoint.Top = (200 - bntUpdatePoint.Height);

            //Quit button
            btnQuit.Left = (this.ClientSize.Width - btnQuit.Width) / 2;
            btnQuit.Top = (this.ClientSize.Height - (btnQuit.Height + 100));
        }
    }
}
