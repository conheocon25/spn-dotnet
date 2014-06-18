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
    public partial class frmTemplateInsert : Form
    {
        public int State = -1;
        public string NameTemplate = "";
        public string Content = "";

        public frmTemplateInsert()
        {
            InitializeComponent();
        }
                                
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            NameTemplate = txtName.Text;
            Content = txtContent.Text;
            this.Close();
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            webPreview.DocumentText = txtContent.Text;
        }
    }
}
