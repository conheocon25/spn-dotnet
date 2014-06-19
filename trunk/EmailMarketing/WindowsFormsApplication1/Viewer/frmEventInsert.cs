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
    public partial class frmEventInsert : Form
    {
        public string NameEvent;
        public int IdTag;
        public int IdTemplate;
        public DateTime Time;
        public int State;

        public frmEventInsert(IList<CTag> TagAll, IList<CTemplate> TemplateAll)
        {
            InitializeComponent();
            
            cboTag.DataSource = TagAll;
            cboTag.DisplayMember = "name";
            cboTag.ValueMember = "id";

            cboTemplate.DataSource = TemplateAll;
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
            this.DialogResult = DialogResult.OK;
            NameEvent = txtName.Text;
            IdTag = (int)cboTag.SelectedValue;
            IdTemplate = (int)cboTemplate.SelectedValue;
            Time = dtpTime.Value;
            State = (int)cboState.SelectedValue;
            this.Close();
        }

        
    }
}
