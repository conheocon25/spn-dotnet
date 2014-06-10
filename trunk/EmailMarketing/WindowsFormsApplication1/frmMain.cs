﻿using System;
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
        public CollectionTag        lstTag;
        public CollectionCustomer   lstCustomer;
        public CollectionEvent      lstEvent;
        public CollectionScheduler  lstScheduler;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lstTag = new CollectionTag();
            lstCustomer = new CollectionCustomer();
            lstEvent    = new CollectionEvent();
            lstScheduler = new CollectionScheduler();
        }

        private void mnuCustomerView_Click(object sender, EventArgs e)
        {
            frmCustomerView F = new frmCustomerView(this.lstTag, this.lstCustomer);
            F.ShowDialog();
        }

        private void mnuOption_Click(object sender, EventArgs e)
        {
            frmOption F = new frmOption();
            F.ShowDialog();
        }

        private void mnuEventView_Click(object sender, EventArgs e)
        {
            frmEventView F = new frmEventView(this.lstEvent);
            F.ShowDialog();
        }

        private void mnuEventInsert_Click(object sender, EventArgs e)
        {
            frmEventInsert F = new frmEventInsert();
            F.ShowDialog();
        }

        private void mnuCustomerInsert_Click(object sender, EventArgs e)
        {
            frmCustomerInsert F = new frmCustomerInsert(this.lstCustomer);
            F.ShowDialog();
        }

        private void mnuScheduleView_Click(object sender, EventArgs e)
        {
            frmSchedulerView F = new frmSchedulerView(this.lstEvent, this.lstCustomer);
            F.ShowDialog();
        }
                
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout F = new frmAbout();
            F.ShowDialog();
        }
    }
}