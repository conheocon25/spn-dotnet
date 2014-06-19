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
        CEventMapper mEvent = new CEventMapper();
        CTagMapper mTag = new CTagMapper();
        CTemplateMapper mTemplate = new CTemplateMapper();
 
        public frmEvent()
        {            
            InitializeComponent();
        }

        private void frmEventView_Load(object sender, EventArgs e)
        {
            var EventAll = mEvent.getAll();
            dgvEvent.DataSource = EventAll;
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
                    mEvent.delete(Id);
                    dgvEvent.DataSource = mEvent.getAll();
                }
            }
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {            
            if (dgvEvent.SelectedRows.Count > 0)
            {                
                int Index = dgvEvent.SelectedRows[0].Index;
                int Id = (int)dgvEvent.Rows[Index].Cells[0].Value;

                var TagAll = mTag.getAll();
                var TemplateAll = mTemplate.getAll();
                var Event = mEvent.get(Id);

                frmEventUpdate F = new frmEventUpdate(Event, TagAll, TemplateAll);                
                var Result = F.ShowDialog();

                if (Result == DialogResult.OK)
                {                    
                    mEvent.update(new CEvent(Id, F.NameEvent, F.Time, F.IdTemplate, F.IdTag, F.State));
                    dgvEvent.DataSource = mEvent.getAll();                    
                }
            }
        }

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            var TagAll = mTag.getAll();
            var TemplateAll = mTemplate.getAll();

            frmEventInsert F = new frmEventInsert(TagAll, TemplateAll);
            var Result = F.ShowDialog();

            if (Result == DialogResult.OK)
            {
                mEvent.insert(new CEvent(1, F.NameEvent, F.Time, F.IdTemplate, F.IdTag, F.State));
                dgvEvent.DataSource= mEvent.getAll();
            }

        }

        private void dgvEvent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mnuUpdate_Click(sender, e);
        }
    }
}
