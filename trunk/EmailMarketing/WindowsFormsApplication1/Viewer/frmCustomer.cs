using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmailMarketing
{
    public partial class frmCustomer : Form
    {
        public TreeNode curNode = null;
        CCustomerMapper mCustomer = new CCustomerMapper();
        CTagMapper mTag = new CTagMapper();

        public frmCustomer()
        {
            InitializeComponent();                        
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {

            var TagAll = mTag.getAll();

            TreeNode N = new TreeNode("Ứng dụng", 0, 1);
                        
            foreach (var Tag in TagAll)
            {                                
                TreeNode N1 = new TreeNode(Tag.Name, 0, 1);
                N1.Tag = Tag.Id;
                N.Nodes.Add(N1);
            }            
            tvwTag.Nodes.Add(N);
           
            //Chọn Node mặc định có hiệu lực
            tvwTag.SelectedNode = N.Nodes[0];
            curNode = N.Nodes[0];
            clickTag(curNode);
        }

        private void tvwTag_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            clickTag(e.Node);
        }

        private void tvwTag_MouseUp(object sender, MouseEventArgs e)
        {
            if (tvwTag.SelectedNode.Level == 1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    // Select the clicked node
                    tvwTag.SelectedNode = tvwTag.GetNodeAt(e.X, e.Y);
                    curNode = tvwTag.SelectedNode;

                    if (tvwTag.SelectedNode != null)
                    {
                        mnuAction.Show(tvwTag, e.Location);
                    }
                }
            }
        }

        private void mnuCustomerInsert_Click(object sender, EventArgs e)
        {            
            int IdTag = Convert.ToInt32(tvwTag.SelectedNode.Tag);
            frmCustomerInsert F = new frmCustomerInsert();
            F.ShowDialog();
            if (F.State == 1) {                
                mCustomer.insert(new CCustomer(1, IdTag, F.NameCustomer, F.Email, F.Phone));
                clickTag(curNode);
            }                
        }
                
        private void dgvCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {                
                int currentMouseOverRow = dgvCustomer.HitTest(e.X, e.Y).RowIndex;                
                mnuGrid.Show(dgvCustomer, new Point(e.X, e.Y));
            }

        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {            
            if (dgvCustomer.SelectedRows.Count > 0) {
                int Index = dgvCustomer.SelectedRows[0].Index;
                int Id = (int)dgvCustomer.Rows[Index].Cells[0].Value;
                DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {                    
                    mCustomer.delete(Id);
                    clickTag(curNode);
                }
            }
        }
                
        private void mnuUpdate_Click(object sender, EventArgs e)
        {                        
            if (dgvCustomer.SelectedRows.Count > 0)
            {                
                int Index = dgvCustomer.SelectedRows[0].Index;
                int IdCustomer = (int)dgvCustomer.Rows[Index].Cells[0].Value;
                CCustomer Customer = mCustomer.get(IdCustomer);                
                frmCustomerUpdate F = new frmCustomerUpdate(Customer);
                                
                F.ShowDialog();
                if (F.State == 1){                    
                    CCustomer C = new CCustomer(IdCustomer, Customer.IdTag, F.NameCustomer, F.Email, F.Phone);
                    mCustomer.update(C);
                    clickTag(curNode);
                }
            }
        }
                
        private void clickTag(TreeNode N)
        {
            if (N.Level == 1)
            {                                
                var CustomerAll = mCustomer.getByTag( (int)N.Tag );
                dgvCustomer.DataSource = CustomerAll;
                curNode = N;
            }
        }
        
    }
}
