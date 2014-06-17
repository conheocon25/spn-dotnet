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
        CTagMapper mapper = new CTagMapper();
        public frmTag()
        {
            InitializeComponent();
            //CService.updateGrid(dgvTag, "SELECT * FROM tbl_tag");
            var TagAll = mapper.getAll();
            dgvTag.DataSource = TagAll;
        }
                               
        private void mnuInsert_Click(object sender, EventArgs e)
        {
            frmTagInsert F = new frmTagInsert();
            F.ShowDialog();
            if (F.State == 1)
            {                
                mapper.insert(new CTag(0, F.NameTag));
                CService.updateGrid(dgvTag, "SELECT * FROM tbl_tag");
            }
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {                                    
            if (dgvTag.SelectedRows.Count > 0)
            {
                int Index = dgvTag.SelectedRows[0].Index;
                CTag Tag = mapper.get(Index);
                frmTagUpdate F = new frmTagUpdate(Tag);
                
                F.ShowDialog();
                if (F.State == 1)
                {
                    Tag.Name = F.NameTag;
                    mapper.update(Tag);
                    CService.updateGrid(dgvTag, "SELECT * FROM tbl_tag");
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
                    mapper.delete(Id);
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
