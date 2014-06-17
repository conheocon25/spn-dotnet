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
            string strConnect = "Data Source= .\\SPNTEAM;Initial catalog=dbEmailMarketing;Integrated security=SSPI;Application Name=True";
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
        static public bool bNextMessage = false;
        static public CSender Sender = new CSender();
    }
}
