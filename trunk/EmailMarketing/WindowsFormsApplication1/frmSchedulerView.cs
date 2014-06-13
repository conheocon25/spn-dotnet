using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EmailMarketing
{
    public partial class frmSchedulerView : Form
    {
        public List<CScheduler> lstMessage;
        public int              curMessage=0;

        public frmSchedulerView()
        {            
            InitializeComponent();
        }

        private void frmSchedulerView_Load(object sender, EventArgs e)
        {
            lstMain.DisplayMember = "Name";
            lstMain.ValueMember = "Id";

            foreach (var Event in CApp.colEvent.getAll())
            {
                lstMain.Items.Add(Event);
            }
            
        }

        private void lstMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CEvent curE = (CEvent)lstMain.SelectedItem;

            //Phát sinh ra danh sách thư mời
            int i = 1;
            foreach( var Customer in CApp.colCustomer.findByTag(curE.IdTag) ){
                var Scheduler = new CScheduler(i++, curE.Name, curE.Time, curE.IdTemplate, Customer.Id, false);
                CApp.colScheduler.Add(Scheduler);
                
            }
            //Gán vào lưới dữ liệu để xem
            var blist = new BindingList<CScheduler>(CApp.colScheduler.getAll());
            dgvScheduler.DataSource = blist;

            updateProcesssing();
        }

        private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tmrSending_Tick(object sender, EventArgs e)
        {

            if (CApp.bNextMessage == true && CApp.colScheduler.getAll().Count > curMessage)
            {
                CApp.colScheduler.getAll()[curMessage].sendMail();
                curMessage ++;
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
            lblProcessing.Text = curMessage + " / " + CApp.colScheduler.getAll().Count;
        }
    }
}
