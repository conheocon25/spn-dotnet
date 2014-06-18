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
        CTagMapper mTag = new CTagMapper();
        public frmTag()
        {
            InitializeComponent();                        
            dgvTag.DataSource = mTag.getAll();
        }
                               
        private void mnuInsert_Click(object sender, EventArgs e)
        {
            frmTagInsert F = new frmTagInsert();
            var result = F.ShowDialog();
            if (result == DialogResult.OK)
            {                
                mTag.insert(new CTag(0, F.NameTag));
                dgvTag.DataSource = mTag.getAll();                
            }
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {                                    
            if (dgvTag.SelectedRows.Count > 0)
            {                
                int Index = dgvTag.SelectedRows[0].Index;
                int IdTag = (int)dgvTag.Rows[Index].Cells[0].Value;

                CTag Tag = mTag.get(IdTag);
                frmTagUpdate F = new frmTagUpdate(Tag);
                
                DialogResult result = F.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Tag.Name = F.NameTag;
                    mTag.update(Tag);
                    dgvTag.DataSource = mTag.getAll();
                }
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {            
            if (dgvTag.SelectedRows.Count > 0)
            {
                int Index = dgvTag.SelectedRows[0].Index;
                int Id = (int)dgvTag.Rows[Index].Cells[0].Value;
                DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {                                        
                    mTag.delete(Id);
                    dgvTag.DataSource = mTag.getAll();
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
