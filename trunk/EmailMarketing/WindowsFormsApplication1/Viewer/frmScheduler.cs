using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EmailMarketing
{
    public partial class frmScheduler : Form
    {
        public List<CScheduler> lstMessage;
        public int              curMessage=0;
        public int nScheduler = 0;
        
        CEventMapper mEvent = new CEventMapper();
        CSchedulerMapper mScheduler = new CSchedulerMapper();
        
        public frmScheduler()
        {            
            InitializeComponent();
        }

        private void frmSchedulerView_Load(object sender, EventArgs e)
        {                        
            lstMain.DataSource = mEvent.getAll();
            lstMain.DisplayMember = "Name";
            lstMain.ValueMember = "Id";
                        
            dgvScheduler.DataSource = mScheduler.getAll();
        }

        private void lstMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {                        
            CApp.connect();
            
            //Lấy về Event
            string IdEvent = lstMain.SelectedValue.ToString();
            SqlCommand cmdEvent = new SqlCommand("SELECT * FROM tbl_event WHERE id=@id", CApp.connection);
            cmdEvent.Parameters.AddWithValue("@id", IdEvent);
            SqlDataReader rdrEvent = cmdEvent.ExecuteReader();
            rdrEvent.Read();
            int IdCustomer = (int)rdrEvent["id"];
            int IdTemplate = (int)rdrEvent["id_template"];
            int IdTag = (int)rdrEvent["id_tag"];
            DateTime Time = DateTime.Parse(rdrEvent["time"].ToString());

            CApp.close();

            CApp.connect();
            //Lấy về danh sách KH tương ứng của Event
            SqlCommand cmdCustomer = new SqlCommand("SELECT * FROM tbl_customer WHERE id_tag=@id_tag", CApp.connection);
            cmdCustomer.Parameters.AddWithValue("@id_tag", IdTag);
            SqlDataReader rdrCustomer = cmdCustomer.ExecuteReader();                        
            List<int> CA = new List<int>();
            while (rdrCustomer.Read())
            {
                CA.Add((int)rdrCustomer["id"]);                
            }
            CApp.close();

            CApp.connect();
            foreach (int IdCur in CA)
            {                
                SqlCommand cmdScheduler = new SqlCommand("INSERT INTO tbl_scheduler(time, id_template, id_customer, state) VALUES(@time, @id_template, @id_customer, @state)", CApp.connection);
                cmdScheduler.Parameters.AddWithValue("@time", Time);
                cmdScheduler.Parameters.AddWithValue("@id_template", IdTemplate);
                cmdScheduler.Parameters.AddWithValue("@id_customer", IdCur);
                cmdScheduler.Parameters.AddWithValue("@state", 0);
                cmdScheduler.ExecuteNonQuery();
            }
            CApp.close();
                        
        }
                
        private void tmrSending_Tick(object sender, EventArgs e)
        {                        
            //Lấy về tổng số tin cần gửi            
            IList<CScheduler> SchedulerAll = mScheduler.getAllReady();
            nScheduler = SchedulerAll.Count;
            prbSending.Maximum = nScheduler;

            if (CApp.bNextMessage == true && nScheduler > curMessage)
            {                
                SchedulerAll[curMessage].sendMail();
                curMessage++;
                prbSending.Value = curMessage;
                CApp.bNextMessage = false;
                updateProcesssing();
            }            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (CApp.bNextMessage == false)
            {
                CApp.bNextMessage = true;
                cmdStart.Text = "Ngừng lại";
            }
            else {
                CApp.bNextMessage = false;
                cmdStart.Text = "Bắt đầu";
            }
            updateProcesssing();
        }
        public void updateProcesssing(){
            lblProcessing.Text = curMessage + " / " + nScheduler.ToString();
        }

        private void frmScheduler_FormClosed(object sender, FormClosedEventArgs e)
        {
            CApp.bNextMessage = false;
        }        
    }
}
