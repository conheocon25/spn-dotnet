using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;

namespace RestaurantApp
{
    class CData
    {
        string Server;
        string Database;
        string UID;
        string Password;
        MySqlConnection Connection;

        public CData()
        {
            Server = "gator3155.hostgator.com";
            Database = "spncom_qlkaraoke_baduc";
            UID = "spncom_admindb";
            Password = "admin368189";
            string connectionString = "SERVER=" + Server + ";" + "DATABASE=" +
            Database + ";" + "UID=" + UID + ";" + "PASSWORD=" + Password + ";";
            
            Connection = new MySqlConnection(connectionString);
        }
        public void open()
        {
            Connection.Open();   
        }
        public void close()
        {
            if (Connection.State== System.Data.ConnectionState.Open)
                Connection.Close();
        }        
    }
}
