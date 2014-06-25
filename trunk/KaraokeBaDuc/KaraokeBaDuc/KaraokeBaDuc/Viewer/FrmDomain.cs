using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeBaDuc
{
    
    public partial class FrmDomain : Form
    {
        CDomainMapper mDomain = new CDomainMapper();
        public FrmDomain()
        {
            InitializeComponent();
            dgvDomain.DataSource = mDomain.getAll();
        }

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            FrmDomainInsert F = new FrmDomainInsert();
            var result = F.ShowDialog();
            if (result == DialogResult.OK)
            {
                mDomain.insert(new CDomain(0, F.NameDomain));
                dgvDomain.DataSource = mDomain.getAll();
            }
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDomain.SelectedRows.Count > 0)
            {
                int Index = dgvDomain.SelectedRows[0].Index;
                int IdDomain = (int)dgvDomain.Rows[Index].Cells[0].Value;

                CDomain Domain = mDomain.get(IdDomain);
                FrmDomainUpdate F = new FrmDomainUpdate(Domain);

                DialogResult result = F.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Domain.Name = F.NameDomain;
                    mDomain.update(Domain);
                    dgvDomain.DataSource = mDomain.getAll();
                }
            }
        }
    }
}
