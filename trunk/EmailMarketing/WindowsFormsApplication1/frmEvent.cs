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
            int Index = -1;
            string Id = "";
            if (dgvEvent.SelectedRows.Count > 0)
            {
                Index = dgvEvent.SelectedRows[0].Index;
                Id = dgvEvent.Rows[Index].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CApp.connect();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_event WHERE id=@id", CApp.connection);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                    CApp.close();

                    CService.updateGrid(dgvEvent, "SELECT * FROM tbl_event");
                }
            }
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {

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
