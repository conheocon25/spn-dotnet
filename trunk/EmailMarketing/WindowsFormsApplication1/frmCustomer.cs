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
        public frmCustomer()
        {
            InitializeComponent();                        
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            CApp.connect();
                        
            //Nạp danh sách thẻ khách hàng
            SqlCommand cmdTag = new SqlCommand("SELECT * FROM tbl_tag", CApp.connection);
            SqlDataReader readerTag = cmdTag.ExecuteReader();

            TreeNode N = new TreeNode("Cửa hàng ABC", 0, 1);

            if (readerTag.HasRows)
            {
                foreach (System.Data.Common.DbDataRecord r in readerTag)
                {
                    //alRows.Add(r);
                    string StrId = r[0].ToString();
                    string StrName = r[1].ToString();

                    //Thêm danh mục cha
                    TreeNode N1 = new TreeNode(StrName, 0, 1);
                    N1.Tag = StrId;
                    N.Nodes.Add(N1);
                }
            }            
            tvwTag.Nodes.Add(N);
            
            //Chọn Node mặc định có hiệu lực
            tvwTag.SelectedNode = N.Nodes[0];
            curNode = N.Nodes[0];
            clickTag(curNode);

            CApp.close();
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
            //Lấy về Tag mặc định
            int IdTag = Convert.ToInt32(tvwTag.SelectedNode.Tag);
            frmCustomerInsert f = new frmCustomerInsert();            
            f.ShowDialog();
            if (f.State == 1) {
                CApp.connect();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_customer(name, phone, email, id_tag) VALUES(@name, @phone, @email, @id_tag)", CApp.connection);
                cmd.Parameters.AddWithValue("@name", f.Name);
                cmd.Parameters.AddWithValue("@phone", f.Phone);
                cmd.Parameters.AddWithValue("@email", f.Email);
                cmd.Parameters.AddWithValue("@id_tag", IdTag);
                cmd.ExecuteNonQuery();
                CApp.close();

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
            int Index = -1;
            string Id = "";
            if (dgvCustomer.SelectedRows.Count > 0) {
                Index = dgvCustomer.SelectedRows[0].Index;
                Id = dgvCustomer.Rows[Index].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {                    
                    CApp.connect();                                        
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_customer WHERE id=@id", CApp.connection);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();                                        
                    CApp.close();

                    clickTag(curNode);
                }
            }
        }
                
        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            int Index = -1;
            string Id = "";
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                CApp.connect();                
                Index = dgvCustomer.SelectedRows[0].Index;
                Id = dgvCustomer.Rows[Index].Cells[0].Value.ToString();
                
                //Lọc danh sách khách hàng đưa vào lưới                
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_customer WHERE id=@id", CApp.connection);
                cmd.Parameters.AddWithValue("@id", Id);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();                
                frmCustomerUpdate f = new frmCustomerUpdate(Id, reader["name"].ToString(), reader["email"].ToString(), reader["phone"].ToString());
                CApp.close();

                CApp.connect();
                f.ShowDialog();
                if (f.State == 1){
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_customer SET name=@name, email=@email, phone=@phone  WHERE id=@id", CApp.connection);
                    cmdUpdate.Parameters.AddWithValue("@id", Id);
                    cmdUpdate.Parameters.AddWithValue("@name", f.NameCustomer);
                    cmdUpdate.Parameters.AddWithValue("@email", f.Email);
                    cmdUpdate.Parameters.AddWithValue("@phone", f.Phone);
                    cmdUpdate.ExecuteNonQuery();
                    clickTag(curNode);
                }

                CApp.close();
            }
        }
                
        private void clickTag(TreeNode N)
        {
            if (N.Level == 1)
            {
                CApp.connect();

                int IdTag = Convert.ToInt32(N.Tag);
                //Lọc danh sách khách hàng đưa vào lưới                
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_customer WHERE id_tag=@id_tag", CApp.connection);
                cmd.Parameters.AddWithValue("@id_tag", IdTag);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvCustomer.DataSource = dt;

                CApp.close();
            }
        }

        private void tvwTag_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
