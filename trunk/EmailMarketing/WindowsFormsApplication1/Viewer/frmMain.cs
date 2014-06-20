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
        CEventMapper mEvent = new CEventMapper();
        CSchedulerMapper mScheduler = new CSchedulerMapper();
        public frmMain()
        {            
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Kiểm tra thông điệp đã đơợc để trong hàng đợi
            IList<CScheduler> SchedulerAll = mScheduler.getAllReady();
            CApp.nSum = SchedulerAll.Count;
            CApp.nSend = 0;
            pgbSending.Maximum = SchedulerAll.Count;
            updateProcesssing();
            
            //Kiểm tra phát sinh dữ liệu gửi đi
            tmrScheduler.Interval = 1000 * CApp.nCheckScheduler;
            tmrScheduler.Enabled = true;
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
                        
        public void updateProcesssing()
        {
            lblState.Text = "Thông báo " + CApp.nSend + " / " + (CApp.nSum + CApp.nSend);
            pgbSending.Maximum = (CApp.nSum + CApp.nSend);
            pgbSending.Value = CApp.nSend;
        }

        private void tmrSending_Tick(object sender, EventArgs e)
        {
            CApp.sending();
            updateProcesssing();                        
        }

        private void mnuLog_Click(object sender, EventArgs e)
        {
            frmLog F = new frmLog();
            F.ShowDialog();
        }

        private void tmrScheduler_Tick(object sender, EventArgs e)
        {            
            var EventAll = mEvent.getAllReady();
            if (EventAll.Count > 0) {
                lblSchedulerState.Text = "Có dữ liệu ...";                
                foreach (var Event in EventAll){
                    Event.generate();
                    Event.State = 1;
                    mEvent.update(Event);
                }
                CApp.bAuto = true;

                CApp.nSum = mScheduler.getAll().Count;
                updateProcesssing();
            }
        }
    }
}