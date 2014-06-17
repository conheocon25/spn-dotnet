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

        private void frmTemplateInsert_Load(object sender, EventArgs e)
        {

        }
                
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            State = 1;
            NameTemplate = txtName.Text;
            Content = txtContent.Text;
            this.Close();
        }
    }
}
