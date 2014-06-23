using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HtmlAgilityPack;

namespace EmailMarketing
{
    public partial class frmTemplate : Form
    {
        CTemplateMapper mTemplate = new CTemplateMapper();

        public frmTemplate()
        {
            InitializeComponent();            
            dgvTemplate.DataSource = mTemplate.getAll();
            
        }
                                
        private void mnuInsert_Click(object sender, EventArgs e)
        {
            frmTemplateInsert F = new frmTemplateInsert();
            F.ShowDialog();
            if (F.DialogResult == DialogResult.OK)
            {                                
                mTemplate.insert(new CTemplate(1, F.NameTemplate, F.Content));
                dgvTemplate.DataSource = mTemplate.getAll();                
            }
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            int Index = -1;            
            if (dgvTemplate.SelectedRows.Count > 0)
            {                
                Index = dgvTemplate.SelectedRows[0].Index;
                int Id = (int)dgvTemplate.Rows[Index].Cells[0].Value;
                CTemplate Template = mTemplate.get(Id);

                frmTemplateUpdate F = new frmTemplateUpdate(Template);                                             
                DialogResult result = F.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Template.Name = F.NameTemplate;
                    Template.Content = F.Content;

                    mTemplate.update(Template);
                    dgvTemplate.DataSource = mTemplate.getAll();
                }             
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {            
            if (dgvTemplate.SelectedRows.Count > 0)
            {
                int Index = dgvTemplate.SelectedRows[0].Index;
                int Id = (int)dgvTemplate.Rows[Index].Cells[0].Value;
                DialogResult result = MessageBox.Show("Có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {                                                            
                    mTemplate.delete(Id);
                    dgvTemplate.DataSource = mTemplate.getAll();
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

        private void mnuAction_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvTemplate_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mnuUpdate_Click(sender, e);
        }

    }
}
