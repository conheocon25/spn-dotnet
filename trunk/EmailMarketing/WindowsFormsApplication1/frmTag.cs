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
    public partial class frmTag : Form
    {
        public frmTag()
        {
            InitializeComponent();            
            CService.updateGrid(dgvTag, "SELECT * FROM tbl_tag");
        }

        private void dgvTag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
                
        private void mnuInsert_Click(object sender, EventArgs e)
        {
            frmTagInsert F = new frmTagInsert();
            F.ShowDialog();
            if (F.State == 1)
            {
                CApp.connect();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_tag(name) VALUES(@name)", CApp.connection);
                cmd.Parameters.AddWithValue("@name", F.NameTag);                
                cmd.ExecuteNonQuery();
                CApp.close();

                CService.updateGrid(dgvTag, "SELECT * FROM tbl_tag");
            }                
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            
            int Index = -1;
            string Id = "";
            if (dgvTag.SelectedRows.Count > 0)
            {
                CApp.connect();
                Index = dgvTag.SelectedRows[0].Index;
                Id = dgvTag.Rows[Index].Cells[0].Value.ToString();

                //Lọc danh sách khách hàng đưa vào lưới                
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_tag WHERE id=@id", CApp.connection);
                cmd.Parameters.AddWithValue("@id", Id);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();                
                frmTagUpdate F = new frmTagUpdate(reader["name"].ToString());

                CApp.close();

                CApp.connect();
                F.ShowDialog();
                if (F.State == 1)
                {
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_tag SET name=@name  WHERE id=@id", CApp.connection);
                    cmdUpdate.Parameters.AddWithValue("@id", Id);
                    cmdUpdate.Parameters.AddWithValue("@name", F.NameTag);
                    cmdUpdate.ExecuteNonQuery();
                    CService.updateGrid(dgvTag, "SELECT * FROM tbl_tag");
                }

                CApp.close();
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            int Index = -1;
            string Id = "";
            if (dgvTag.SelectedRows.Count > 0)
            {
                Index = dgvTag.SelectedRows[0].Index;
                Id = dgvTag.Rows[Index].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CApp.connect();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_tag WHERE id=@id", CApp.connection);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                    CApp.close();

                    CService.updateGrid(dgvTag, "SELECT * FROM tbl_tag");
                }
            }
        }

        private void dgvTag_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvTag.HitTest(e.X, e.Y).RowIndex;
                mnuAction.Show(dgvTag, new Point(e.X, e.Y));
            }
        }
    }
}
