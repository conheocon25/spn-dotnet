using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailMarketingDeliver
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ntiApp.Visible = true;
                ntiApp.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ntiApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            ntiApp.Visible = false;
        }
    }
}
