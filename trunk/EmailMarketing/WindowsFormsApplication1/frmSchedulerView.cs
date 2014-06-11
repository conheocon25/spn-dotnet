using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EmailMarketing
{
    public partial class frmSchedulerView : Form
    {        
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
            foreach( var Customer in CApp.colCustomer.getAll() ){
                var Scheduler = new CScheduler(i++, curE.Name, curE.Time, curE.IdTemplate, Customer.Id);
                CApp.colScheduler.Add(Scheduler);
            }
            //Gán vào lưới dữ liệu để xem
            var blist = new BindingList<CScheduler>(CApp.colScheduler.getAll());
            dgvScheduler.DataSource = blist;

            CScheduler my = CApp.colScheduler.find(1);
            my.sendMail();
            my.sendMail();
            my.sendMail();
            my.sendMail();
            my.sendMail();
        }

        private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }        
    }
}
