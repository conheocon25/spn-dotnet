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
    public partial class frmLog : Form
    {
        private CLogMapper mLog = new CLogMapper();
        public frmLog()
        {
            InitializeComponent();
            var mLog = new CLogMapper();
            var LogAll = mLog.getAll();
            dgvLog.DataSource = LogAll;
        }

        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (dgvLog.SelectedRows.Count > 0)
            {
                int Index = dgvLog.SelectedRows[0].Index;
                int Id = (int)dgvLog.Rows[Index].Cells[0].Value;
                DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    mLog.delete(Id);
                    dgvLog.DataSource = mLog.getAll();
                }
            }
        }

        private void mnuDeleteAll_Click(object sender, EventArgs e)
        {                        
            DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                mLog.deleteAll();
                dgvLog.DataSource = mLog.getAll();
            }
            
        }

        private void dgvLog_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvLog.HitTest(e.X, e.Y).RowIndex;
                mnuAction.Show(dgvLog, new Point(e.X, e.Y));
            }
        }
    }
}
