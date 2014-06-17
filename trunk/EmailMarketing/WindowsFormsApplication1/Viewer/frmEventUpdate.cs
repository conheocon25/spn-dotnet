using System;
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
    public partial class frmEventUpdate : Form
    {
        public int State = -1;
        public string NameEvent;
        public int IdTag;
        public int IdTemplate;
        public DateTime Time;

        public frmEventUpdate(DataTable dtTag_, DataTable dtTemplate_, string Name_="", int IdTag_=0, int IdTemplate_=0, DateTime time_=new DateTime())
        {
            InitializeComponent();

            txtName.Text = Name_;

            cboTag.DataSource = dtTag_;
            cboTag.DisplayMember = "name";
            cboTag.ValueMember = "id";
            cboTag.SelectedIndex = IdTag_;

            cboTemplate.DataSource = dtTemplate_;
            cboTemplate.DisplayMember = "name";
            cboTemplate.ValueMember = "id";
            cboTemplate.SelectedIndex = IdTemplate_;

            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "dd/MM/yyyy hh:mm";
            dtpTime.Value = time_;
            
        }

        private void frmEventUpdate_Load(object sender, EventArgs e)
        {
            
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
