using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        string myConnectionString;
        object connection;
        public Main()
        {
            InitializeComponent();
             
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string myConnectionString = "Server=localhost;Database=spncom_qlcuahang_hdncomputer;Uid=root;Pwd=admin123456";
            var connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select id, name, email From shopc_user";
                var dataAdapter = new MySqlDataAdapter(cmd);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;

            }
            catch (Exception)
            {
                MessageBox.Show("loi");
                throw;
            }
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnectionString = "Server=localhost;Database=spncom_qlcuahang_hdncomputer;Uid=root;Pwd=admin123456";
            var connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select id, name, email From shopc_user";
                var dataAdapter = new MySqlDataAdapter(cmd);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                
            }
            catch (Exception)
            {
                MessageBox.Show("loi");
                throw;
            }
            connection.Close();
        }
    }
}
