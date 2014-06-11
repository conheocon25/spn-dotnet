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
    public partial class frmEventView : Form
    {

        public frmEventView(CollectionEvent lstEvent_ = null)
        {            
            InitializeComponent();
        }

        private void frmEventView_Load(object sender, EventArgs e)
        {
            var blist = new BindingList<CEvent>(CApp.colEvent.getAll());
            grdEvent.DataSource = blist;
        }
    }
}
