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
    public partial class frmEvent : Form
    {

        public frmEvent(CollectionEvent lstEvent_ = null)
        {            
            InitializeComponent();
        }

        private void frmEventView_Load(object sender, EventArgs e)
        {
            CService.updateGrid(dgvEvent, "SELECT * FROM tbl_event");
        }

        private void gdvEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gdvEvent_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvEvent.HitTest(e.X, e.Y).RowIndex;
                mnuAction.Show(dgvEvent, new Point(e.X, e.Y));
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {            
            if (dgvEvent.SelectedRows.Count > 0)
            {
                int Index = dgvEvent.SelectedRows[0].Index;
                int Id = (int)dgvEvent.Rows[Index].Cells[0].Value;
                DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CService.deleteById("tbl_event", Id);
                    CService.updateGrid(dgvEvent, "SELECT * FROM tbl_event");
                }
            }
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            int Index = -1;
            string Id = "";
            if (dgvEvent.SelectedRows.Count > 0)
            {
                CApp.connect();
                Index = dgvEvent.SelectedRows[0].Index;
                Id = dgvEvent.Rows[Index].Cells[0].Value.ToString();

                SqlCommand cmdTag = new SqlCommand("SELECT * FROM tbl_tag", CApp.connection);
                SqlDataReader rdrTag = cmdTag.ExecuteReader();
                DataTable dtTag = new DataTable();
                dtTag.Load(rdrTag);

                SqlCommand cmdTemplate = new SqlCommand("SELECT * FROM tbl_template", CApp.connection);
                SqlDataReader rdrTemplate = cmdTemplate.ExecuteReader();
                DataTable dtTemplate = new DataTable();
                dtTemplate.Load(rdrTemplate);
                                
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_event WHERE id=@id", CApp.connection);
                cmd.Parameters.AddWithValue("@id", Id);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                frmEventUpdate F = new frmEventUpdate(dtTag, dtTemplate, reader["name"].ToString(), (int)reader["id_tag"], (int)reader["id_template"], DateTime.Parse(reader["time"].ToString()));
                
                F.ShowDialog();
                CApp.close();
                
                CApp.connect();
                if (F.State == 1)
                {
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_event SET name=@name, id_tag=@id_tag, id_template=@id_template, time=@time WHERE id=@id", CApp.connection);
                    cmdUpdate.Parameters.AddWithValue("@id", Id);
                    cmdUpdate.Parameters.AddWithValue("@name", F.NameEvent);
                    cmdUpdate.Parameters.AddWithValue("@id_tag", F.IdTag);
                    cmdUpdate.Parameters.AddWithValue("@id_template", F.IdTemplate);
                    cmdUpdate.Parameters.AddWithValue("@time", F.Time);

                    cmdUpdate.ExecuteNonQuery();
                    CService.updateGrid(dgvEvent, "SELECT * FROM tbl_event");
                }

                CApp.close();
            }
        }

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            CApp.connect();

            SqlCommand cmdTag = new SqlCommand("SELECT * FROM tbl_tag", CApp.connection);
            SqlDataReader rdrTag = cmdTag.ExecuteReader();
            DataTable dtTag = new DataTable();
            dtTag.Load(rdrTag);

            SqlCommand cmdTemplate = new SqlCommand("SELECT * FROM tbl_template", CApp.connection);
            SqlDataReader rdrTemplate = cmdTemplate.ExecuteReader();
            DataTable dtTemplate = new DataTable();
            dtTemplate.Load(rdrTemplate);

            frmEventInsert F = new frmEventInsert(dtTag, dtTemplate);
            F.ShowDialog();

            if (F.State == 1)
            {
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_event(name, time, id_tag, id_template) VALUES(@name, @time, @id_tag, @id_template)", CApp.connection);
                cmdInsert.Parameters.AddWithValue("@name", F.NameEvent);
                cmdInsert.Parameters.AddWithValue("@time", F.Time);
                cmdInsert.Parameters.AddWithValue("@id_template", F.IdTemplate);
                cmdInsert.Parameters.AddWithValue("@id_tag", F.IdTag);
                cmdInsert.ExecuteNonQuery();
            }
            CApp.close();

            CService.updateGrid(dgvEvent, "SELECT * FROM tbl_event");
        }
    }
}
