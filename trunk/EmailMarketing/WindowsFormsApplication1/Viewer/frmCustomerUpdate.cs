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
        public string NameCustomer = "";
        public string Phone = "";
        public string Email = "";

        public frmCustomerUpdate(CCustomer Customer)
        {
            InitializeComponent();

            txtName.Text = Customer.Name;
            txtPhone.Text = Customer.Phone;
            txtEmail.Text = Customer.Email;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NameCustomer = txtName.Text;
            Phone = txtPhone.Text;
            Email = txtEmail.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
