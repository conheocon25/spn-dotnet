using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeBaDuc
{
    public partial class FrmDomainInsert : Form
    {
        public string NameDomain = "";
        public int State = -1;
        public FrmDomainInsert()
        {
            InitializeComponent();
        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            NameDomain = txtNameDomain.Text;
            this.Close();
        }
    }
}
