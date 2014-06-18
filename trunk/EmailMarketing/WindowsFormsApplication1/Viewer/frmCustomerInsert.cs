using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmailMarketing
{
    public partial class frmCustomerInsert : Form
    {        
        public int State = -1;
        public string Id = "";
        public string NameCustomer = "";
        public string Phone = "";
        public string Email = "";

        public frmCustomerInsert()
        {            
            InitializeComponent();
        }

        private void frmCustomerInsert_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {                                    
            NameCustomer = txtName.Text;
            Email = txtEmail.Text;
            Phone = txtPhone.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
               
    }
}
