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
        cMySQLConnection myDBConnection;
        
        public Main()
        {
            InitializeComponent();
             
        }

        private void Main_Load(object sender, EventArgs e)
        {
            myDBConnection = new cMySQLConnection();
            myDBConnection.LoadToDataGridView("Select * From cafecoirieng_employee", DGView1);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnectionString = "Server=gator3155.hostgator.com;Database=spncom_qlcuahang_hdncomputer;Uid=spncom_admindb;Pwd=admin368189";
            var connection = new MySqlConnection(myConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select id, name, email From shopc_user";
                var dataAdapter = new MySqlDataAdapter(cmd);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                DGView1.DataSource = dataSet.Tables[0].DefaultView;
                
            }
            catch (Exception)
            {
                MessageBox.Show("loi");
                throw;
            }
            connection.Close();
        }

       
        private void DGView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStt.Text = DGView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = DGView1.CurrentRow.Cells[1].Value.ToString();
            txtJob.Text = DGView1.CurrentRow.Cells[2].Value.ToString();

            cboGender.SelectedIndex = int.Parse(DGView1.CurrentRow.Cells[3].Value.ToString());
            txtPhone.Text = DGView1.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = DGView1.CurrentRow.Cells[5].Value.ToString();
            txtSalaryBase.Text = DGView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
