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
    public partial class frmTagInsert : Form
    {
        public string NameTag = "";
        public int State = -1;
        public frmTagInsert()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NameTag = txtName.Text;
            State = 1;
            this.Close();
        }
    }
}
