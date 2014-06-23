using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;

namespace KaraokeBaDuc
{
    public class CApp
    {
        static public MySqlConnection MySQLConnection;
        static public string Server;
        static public string DataBaseServer;
        static public string UserID;
        static public string PassWord;
        static public string ConnectionString;
        
        //Constructor
        public CApp()
        {
            Initialize();
        }
        private void Initialize()
        {
            Server = "gator3155.hostgator.com";
            DataBaseServer = "spncom_qlkaraoke_baduc";
            UserID = "spncom_admindb";
            PassWord = "admin368189";
            ConnectionString = "SERVER=" + Server + ";" + "DATABASE=" +
            DataBaseServer + ";" + "UID=" + UserID + ";" + "PASSWORD=" + PassWord + ";";                        
        }

        //open MySQLConnection to DataBaseServer
        private bool OpenMySQLConnection()
        {
            try
            {
                MySQLConnection = new MySqlConnection(ConnectionString);
                MySQLConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {                
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Không Thể kết nối với Server!");
                        break;

                    case 1045:
                        MessageBox.Show("Sai Mật khẩu và tài khoản!");
                        break;
                }
                return false;
            }
        }

        //Close MySQLConnection
        private bool CloseMySQLConnection()
        {
            try
            {
                if (MySQLConnection.State == ConnectionState.Open)
                    MySQLConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }           
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    UserID, PassWord, Server, DataBaseServer);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                  UserID, PassWord, Server, DataBaseServer);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }
}
