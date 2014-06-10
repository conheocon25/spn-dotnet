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
    public partial class frmCustomerInsert : Form
    {
        private CollectionCustomer lstCustomer;    
        public frmCustomerInsert(CollectionCustomer lstCustomer_=null)
        {
            this.lstCustomer = lstCustomer_;
            InitializeComponent();
        }

        private void frmCustomerInsert_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CCustomer Cus = new CCustomer(Convert.ToInt32(txtId.Text), 1, txtName.Text, txtEmail.Text, txtPhone.Text);
            this.lstCustomer.Add(Cus);
            this.Close();
        }
    }
}
