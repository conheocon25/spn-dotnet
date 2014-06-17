using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmailMarketing
{
    public partial class frmTemplate : Form
    {
        public frmTemplate()
        {
            InitializeComponent();
            CService.updateGrid(dgvTemplate, "SELECT * FROM tbl_template");
        }
                                
        private void mnuInsert_Click(object sender, EventArgs e)
        {
            frmTemplateInsert F = new frmTemplateInsert();
            F.ShowDialog();
            if (F.State == 1)
            {
                CApp.connect();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_template(name, content) VALUES(@name, @content)", CApp.connection);
                cmd.Parameters.AddWithValue("@name", F.NameTemplate);
                cmd.Parameters.AddWithValue("@content", F.Content);
                cmd.ExecuteNonQuery();
                CApp.close();

                CService.updateGrid(dgvTemplate, "SELECT * FROM tbl_template");
            }
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            int Index = -1;
            string Id = "";
            if (dgvTemplate.SelectedRows.Count > 0)
            {
                CApp.connect();
                Index = dgvTemplate.SelectedRows[0].Index;
                Id = dgvTemplate.Rows[Index].Cells[0].Value.ToString();

                //Lọc danh sách khách hàng đưa vào lưới                
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_template WHERE id=@id", CApp.connection);
                cmd.Parameters.AddWithValue("@id", Id);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                frmTemplateUpdate F = new frmTemplateUpdate(reader["name"].ToString(), reader["content"].ToString());

                CApp.close();

                CApp.connect();
                F.ShowDialog();
                if (F.State == 1)
                {
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_template SET name=@name, content=@content  WHERE id=@id", CApp.connection);
                    cmdUpdate.Parameters.AddWithValue("@id", Id);
                    cmdUpdate.Parameters.AddWithValue("@name", F.NameTemplate);
                    cmdUpdate.Parameters.AddWithValue("@content", F.Content);

                    cmdUpdate.ExecuteNonQuery();
                    CService.updateGrid(dgvTemplate, "SELECT * FROM tbl_template");
                }

                CApp.close();
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {            
            if (dgvTemplate.SelectedRows.Count > 0)
            {
                int Index = dgvTemplate.SelectedRows[0].Index;
                string Id = dgvTemplate.Rows[Index].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CApp.connect();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_template WHERE id=@id", CApp.connection);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                    CApp.close();

                    CService.updateGrid(dgvTemplate, "SELECT * FROM tbl_template");
                }
            }
        }

        private void dgvTemplate_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvTemplate.HitTest(e.X, e.Y).RowIndex;
                mnuAction.Show(dgvTemplate, new Point(e.X, e.Y));
            }
        }

    }
}
