using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CGlobal.Data.open();

            CGlobal.Data.close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout F = new frmAbout();
            F.ShowDialog();
        }

        private void khuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDomain F = new frmDomain();
            F.ShowDialog();
        }

        private void mnuSelling_Click(object sender, EventArgs e)
        {
            frmSelling F = new frmSelling();
            F.ShowDialog();
        }

        private void mnuImport_Click(object sender, EventArgs e)
        {
            frmImport F = new frmImport();
            F.ShowDialog();
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            frmUser F = new frmUser();
            F.ShowDialog();
        }
        
    }
}
