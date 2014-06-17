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
    public partial class frmTagUpdate : Form
    {
        public int State = -1;
        public string NameTag = "";

        public frmTagUpdate(CTag Tag)
        {
            InitializeComponent();
            txtName.Text = Tag.Name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NameTag = txtName.Text;
            State = 1;
            this.Close();
        }
    }
}
