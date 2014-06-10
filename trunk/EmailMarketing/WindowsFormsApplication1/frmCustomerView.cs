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
    public partial class frmCustomerView : Form
    {
        private CollectionCustomer lstCustomer;    
        public frmCustomerView( CollectionCustomer lstCustomer_ = null )
        {
            InitializeComponent();
            this.lstCustomer = lstCustomer_;
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            var blist = new BindingList<CCustomer>(this.lstCustomer.getAll());
            grdCustomer.DataSource = blist;
            /*
            grdCustomer.AutoGenerateColumns = false;                        
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn()
            {
                CellTemplate =  cell,
                                Name = "Name",
                                HeaderText = "Tên khách hàng",
                                DataPropertyName = "Name" // Tell the column which property of FileName it should use
            };
            grdCustomer.Columns.Add(colName);
            */

        }
    }
}
