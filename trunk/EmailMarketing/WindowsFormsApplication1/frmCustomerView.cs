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
        private CollectionTag lstTag;

        public frmCustomerView( CollectionTag lstTag_ = null, CollectionCustomer lstCustomer_ = null )
        {
            InitializeComponent();
            this.lstTag = lstTag_;
            this.lstCustomer = lstCustomer_;
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            var blist = new BindingList<CCustomer>(this.lstCustomer.getAll());
            grdCustomer.DataSource = blist;

            TreeNode N = new TreeNode("Cửa hàng ABC", 0, 1);
            foreach (var Tag in this.lstTag.getAll() )
            {
                string StrId = Tag.Id.ToString();
                string StrName = Tag.Name;

                //Thêm danh mục cha
                TreeNode N1 = new TreeNode(StrName, 0, 1);
                N1.Tag = StrId;
                N.Nodes.Add(N1);
            }
            tvwTag.Nodes.Add(N);

        }

        private void tvwTag_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int IdTag = Convert.ToInt32(e.Node.Tag);
            var qryCustomer = from c in this.lstCustomer.getAll()
                              where c.IdTag == IdTag
                              select c;

            var blist = new BindingList<CCustomer>(qryCustomer.ToList());
            grdCustomer.DataSource = blist;

        }
    }
}
