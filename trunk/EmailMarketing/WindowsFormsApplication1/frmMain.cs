using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailMarketing
{
    public partial class frmMain : Form
    {        
        
        public frmMain()
        {            
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuCustomerView_Click(object sender, EventArgs e)
        {
            frmCustomerView F = new frmCustomerView();
            F.ShowDialog();
        }

        private void mnuOption_Click(object sender, EventArgs e)
        {
            frmOption F = new frmOption();
            F.ShowDialog();
        }

        private void mnuEventView_Click(object sender, EventArgs e)
        {
            frmEventView F = new frmEventView();
            F.ShowDialog();
        }

        private void mnuEventInsert_Click(object sender, EventArgs e)
        {
            frmEventInsert F = new frmEventInsert();
            F.ShowDialog();
        }

        private void mnuCustomerInsert_Click(object sender, EventArgs e)
        {
            frmCustomerInsert F = new frmCustomerInsert();
            F.ShowDialog();
        }

        private void mnuScheduleView_Click(object sender, EventArgs e)
        {
            frmSchedulerView F = new frmSchedulerView();
            F.ShowDialog();
        }
                
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout F = new frmAbout();
            F.ShowDialog();
        }
    }
}