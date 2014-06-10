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
    public partial class frmSchedulerView : Form
    {
        private CollectionEvent lstEvent;
        private CollectionScheduler lstScheduler;
        private CollectionCustomer lstCustomer;

        public frmSchedulerView(CollectionEvent lstEvent_ = null, CollectionCustomer lstCustomer_ = null)
        {
            this.lstEvent = lstEvent_;
            this.lstCustomer = lstCustomer_;
            this.lstScheduler = new CollectionScheduler();
            InitializeComponent();
        }

        private void frmSchedulerView_Load(object sender, EventArgs e)
        {
            lstMain.DisplayMember = "Name";
            lstMain.ValueMember = "Id";

            foreach (var Event in this.lstEvent.getAll())
            {
                lstMain.Items.Add(Event);
            }
        }

        private void lstMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CEvent curE = (CEvent)lstMain.SelectedItem;

            //Phát sinh ra danh sách thư mời
            foreach( var Customer in this.lstCustomer.getAll() ){
                var Scheduler = new CScheduler(1, curE.Name, curE.Time, curE.IdTemplate, Customer.Id);
                this.lstScheduler.Add(Scheduler);
            }
            //Gán vào lưới dữ liệu để xem
            var blist = new BindingList<CScheduler>(this.lstScheduler.getAll());
            dgvScheduler.DataSource = blist;
        }

        private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }        
    }
}
