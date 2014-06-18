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
        public int curMessage = 0;
        public int nScheduler = 0;

        CEventMapper mEvent = new CEventMapper();
        CCustomerMapper mCustomer = new CCustomerMapper();
        CSchedulerMapper mScheduler = new CSchedulerMapper();

        public frmMain()
        {            
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            IList<CScheduler> SchedulerAll = mScheduler.getAllReady();
            nScheduler = SchedulerAll.Count;
            pgbSending.Maximum = nScheduler;
            updateProcesssing();
        }

        private void mnuCustomerView_Click(object sender, EventArgs e)
        {
            frmCustomer F = new frmCustomer();
            F.ShowDialog();
        }

        private void mnuOption_Click(object sender, EventArgs e)
        {
            frmConfig F = new frmConfig();
            F.ShowDialog();
        }

        private void mnuEventView_Click(object sender, EventArgs e)
        {
            frmEvent F = new frmEvent();
            F.ShowDialog();
        }
        
        private void mnuScheduleView_Click(object sender, EventArgs e)
        {
            frmScheduler F = new frmScheduler();
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

        private void mnuConfig_Click(object sender, EventArgs e)
        {
            frmConfig F = new frmConfig();
            F.ShowDialog();
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

        private void ntiApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            ntiApp.Visible = false;
        }
                
        private void mnuSending_Click(object sender, EventArgs e)
        {
            if (CApp.bAuto == false)
            {
                CApp.bAuto = true;                
                mnuSending.Text = "Ngưng gửi";
            }
            else {
                CApp.bAuto = false;                
                mnuSending.Text = "Gửi tự động";            
            }         
        }
        public void updateProcesssing()
        {
            lblState.Text = "Thông báo " + curMessage + " / " + nScheduler.ToString();
            pgbSending.Maximum = nScheduler;
            pgbSending.Value = curMessage;
        }

        private void tmrSending_Tick(object sender, EventArgs e)
        {            
            IList<CScheduler> SchedulerAll = mScheduler.getAllReady();
            nScheduler = SchedulerAll.Count;
            pgbSending.Maximum = nScheduler;

            if (CApp.bAuto == true) {
                if (CApp.bNextMessage == true && nScheduler > curMessage)
                {
                    SchedulerAll[curMessage].sendMail();
                    curMessage++;
                    CApp.bNextMessage = false;
                    updateProcesssing();
                }
            }            
        }
    }
}