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
    public partial class frmScheduleView : Form
    {
        private CollectionScheduler lstScheduler;
        public frmScheduleView(CollectionScheduler lstScheduler_=null)
        {
            this.lstScheduler = lstScheduler_;
            InitializeComponent();
        }

        private void frmScheduleView_Load(object sender, EventArgs e)
        {
            var blist = new BindingList<Scheduler>(this.lstScheduler.getAll());
            grdScheduler.DataSource = blist;
        }
    }
}
