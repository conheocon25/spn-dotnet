using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EmailMarketing
{
    public partial class frmScheduler : Form
    {        
        public int curMessage=0;
        public int nScheduler = 0;
        
        CEventMapper mEvent = new CEventMapper();
        CCustomerMapper mCustomer = new CCustomerMapper();
        CSchedulerMapper mScheduler = new CSchedulerMapper();
        
        public frmScheduler()
        {            
            InitializeComponent();
        }

        private void frmSchedulerView_Load(object sender, EventArgs e)
        {                        
            lstMain.DataSource = mEvent.getAll();
            lstMain.DisplayMember = "Name";
            lstMain.ValueMember = "Id";
                        
            dgvScheduler.DataSource = mScheduler.getAll();
        }

        private void lstMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {                                                            
            int IdEvent = (int)lstMain.SelectedValue;
            var Event = mEvent.get(IdEvent);
            var CustomerAll = mCustomer.getByTag(Event.IdTag);

            foreach (var Customer in CustomerAll)
            {                                
                mScheduler.insert(
                    new CScheduler(
                        1,
                        Event.Time,
                        Event.IdTemplate,
                        Customer.Id,
                        0
                        )
                );
            }
            dgvScheduler.DataSource = mScheduler.getAllReady();
            updateProcesssing();
        }
                
        private void tmrSending_Tick(object sender, EventArgs e)
        {                        
            //Lấy về tổng số tin cần gửi            
            IList<CScheduler> SchedulerAll = mScheduler.getAllReady();
            nScheduler = SchedulerAll.Count;
            prbSending.Maximum = nScheduler;

            if (CApp.bNextMessage == true && nScheduler > curMessage)
            {                
                SchedulerAll[curMessage].sendMail();
                curMessage++;                
                CApp.bNextMessage = false;
                updateProcesssing();
            }            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (CApp.bNextMessage == false)
            {
                CApp.bNextMessage = true;
                cmdStart.Text = "Ngừng lại";
            }
            else {
                CApp.bNextMessage = false;
                cmdStart.Text = "Bắt đầu";
            }
            updateProcesssing();
        }
        public void updateProcesssing(){
            lblProcessing.Text = curMessage + " / " + nScheduler.ToString();
            prbSending.Value = curMessage;
        }

        private void frmScheduler_FormClosed(object sender, FormClosedEventArgs e)
        {
            CApp.bNextMessage = false;
        }

        private void cmdSchedulerDeleteAll_Click(object sender, EventArgs e)
        {
            mScheduler.deleteAll();
            dgvScheduler.DataSource = mScheduler.getAll();
        }
        
    }
}
