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

        public frmEventUpdate(CEvent Event, IList<CTag> lstTag, IList<CTemplate> lstTemplate)
        {
            InitializeComponent();

            txtName.Text = Event.Name;

            cboTag.DataSource = lstTag;
            cboTag.DisplayMember = "name";
            cboTag.ValueMember = "id";
            cboTag.SelectedValue = Event.IdTag;

            cboTemplate.DataSource = lstTemplate;
            cboTemplate.DisplayMember = "name";
            cboTemplate.ValueMember = "id";
            cboTemplate.SelectedValue = Event.IdTemplate;

            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "dd/MM/yyyy hh:mm";
            dtpTime.Value = Event.Time;
            
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
