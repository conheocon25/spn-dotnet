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
    public partial class frmCustomerUpdate : Form
    {
        public int State = -1;
        public string Id = "";
        public string Name = "";
        public string Phone = "";
        public string Email = "";

        public frmCustomerUpdate(string Id_="", string Name_="", string Email_="", string Phone_="")
        {
            InitializeComponent();

            txtName.Text = Name_;
            txtPhone.Text = Phone_;
            txtEmail.Text = Email_;
            Id = Id_;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            Phone = txtName.Text;
            Email = txtName.Text;
            State = 1;
            this.Close();            
        }

    }
}
