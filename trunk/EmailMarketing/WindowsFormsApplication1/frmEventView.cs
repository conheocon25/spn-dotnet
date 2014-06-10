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
        private CollectionEvent lstEvent;

        public frmEventView(CollectionEvent lstEvent_ = null)
        {
            this.lstEvent = lstEvent_;
            InitializeComponent();
        }

        private void frmEventView_Load(object sender, EventArgs e)
        {
            var blist = new BindingList<CEvent>(this.lstEvent.getAll());
            grdEvent.DataSource = blist;
        }
    }
}
