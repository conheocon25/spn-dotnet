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
            frmCustomer F = new frmCustomer();
            F.ShowDialog();
        }

        private void mnuOption_Click(object sender, EventArgs e)
        {
            frmOption F = new frmOption();
            F.ShowDialog();
        }

        private void mnuEventView_Click(object sender, EventArgs e)
        {
            frmEvent F = new frmEvent();
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

        private void mnuEvent_Click(object sender, EventArgs e)
        {
            frmEvent F = new frmEvent();
            F.ShowDialog();
        }

        private void mnuTemplate_Click(object sender, EventArgs e)
        {
            frmTemplate F = new frmTemplate();
            F.ShowDialog();
        }

        private void mnuTagView_Click(object sender, EventArgs e)
        {
            frmTag F = new frmTag();
            F.ShowDialog();
        }
    }
}