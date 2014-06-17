﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailMarketing
{
    public partial class frmEventInsert : Form
    {
        public int State = -1;
        public string NameEvent;
        public int IdTag;
        public int IdTemplate;
        public DateTime Time;

        public frmEventInsert(DataTable dtTag_, DataTable dtTemplate_)
        {
            InitializeComponent();
            
            cboTag.DataSource = dtTag_;
            cboTag.DisplayMember = "name";
            cboTag.ValueMember = "id";

            cboTemplate.DataSource = dtTemplate_;
            cboTemplate.DisplayMember = "name";
            cboTemplate.ValueMember = "id";
        }

        private void frmEventInsert_Load(object sender, EventArgs e)
        {
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "dd/MM/yyyy hh:mm";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            State = 1;
            NameEvent = txtName.Text;
            IdTag = (int)cboTag.SelectedValue;
            IdTemplate = (int)cboTemplate.SelectedValue;
            Time = dtpTime.Value;

            this.Close();
        }
    }
}
