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
        
        public frmScheduler()
        {            
            InitializeComponent();
        }

        private void frmSchedulerView_Load(object sender, EventArgs e)
        {
            CApp.connect();
            SqlCommand cmdEvent = new SqlCommand("SELECT * FROM tbl_event", CApp.connection);
            SqlDataReader rdrEvent = cmdEvent.ExecuteReader();
            DataTable dtEvent = new DataTable();
            dtEvent.Load(rdrEvent);

            lstMain.DataSource = dtEvent;
            lstMain.DisplayMember = "Name";
            lstMain.ValueMember = "Id";
            CApp.close();
            CService.updateGrid(dgvScheduler, "SELECT * FROM tbl_scheduler WHERE state=0");

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

        private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tmrSending_Tick(object sender, EventArgs e)
        {
            CApp.connect();
            
            //Lấy về tổng số tin cần gửi
            SqlCommand cmdScheduler = new SqlCommand("SELECT * FROM tbl_scheduler WHERE state=0", CApp.connection);
            SqlDataReader rdrScheduler = cmdScheduler.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdrScheduler);
            nScheduler = dt.Rows.Count;
            CApp.close();
            
            if (CApp.bNextMessage == true && this.nScheduler > curMessage)
            {
                //Đoạn mã gửi email đi
                string UserState = "Testing ...";
                
                // add from,to mailaddresses
                MailAddress from = new MailAddress("thanhbao2007vl@gmail.com", "Thanh Bảo");
                MailAddress to = new MailAddress("tuanbuithanh@gmail.com", "Bùi Thanh Tuấn");
                MailMessage Message = new MailMessage(from, to);
                Message.Subject = "Thử nè";
                Message.Body = "<H1>1. Thử 2. Chơi 3. Ngủ</H1>";
                Message.IsBodyHtml = true;

                CApp.Sender._smtpClient.SendAsync(Message, UserState);
                
                curMessage ++;
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


    }
}
