using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmailMarketing
{
    public static class CApp
    {        
        static public void connect()
        {
            string strConnect = "Data Source= STUDIO-PC;Initial catalog=dbEmailMarketing;Integrated security=SSPI;Application Name=True";
            try
            {
                connection  = new SqlConnection(strConnect);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }        
        }
        static public void close()
        {  
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        static public SqlConnection connection;
        static public bool bAuto = false;
        static public bool bNextMessage = true;
        static public int nSend = 0;
        static public int nSum = 0;
        static public int iScheduler = -1;

        static public int nCheckScheduler = 5;

        static public CSender Sender = new CSender();
        
        static public void sending(){
            if (bAuto == true)
            {
                if (bNextMessage == true && nSum > 0)
                {
                    var mScheduler = new CSchedulerMapper();
                    var SchedulerAll = mScheduler.getAll();
                    SchedulerAll[0].sendMail();
                    iScheduler = SchedulerAll[0].Id;
                    bNextMessage = false;
                }
            }                    
        }
    }
}
