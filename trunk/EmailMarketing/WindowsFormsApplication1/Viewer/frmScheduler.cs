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
            Event.generate();
            dgvScheduler.DataSource = mScheduler.getAllReady();
        }
               
        
    }
}
