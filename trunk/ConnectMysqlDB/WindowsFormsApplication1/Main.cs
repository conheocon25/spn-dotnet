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
            btSave.Visible = false; 
        }
        public void LoadData()
        {
            myDBConnection = new cMySQLConnection();
            myDBConnection.LoadToDataGridView("Select * From k3d_employee", DGView1); 
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

       

        public void LoadToText()
        {
            txtStt.Text = DGView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = DGView1.CurrentRow.Cells[1].Value.ToString();
            txtJob.Text = DGView1.CurrentRow.Cells[2].Value.ToString();
            cboGender.SelectedIndex = int.Parse(DGView1.CurrentRow.Cells[3].Value.ToString());
            txtPhone.Text = DGView1.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = DGView1.CurrentRow.Cells[5].Value.ToString();
            txtSalaryBase.Text = DGView1.CurrentRow.Cells[6].Value.ToString();
        }

        public void SetToText()
        {
            txtStt.Text = "";
            txtName.Text = "";
            txtJob.Text = "";
            cboGender.SelectedIndex = 1;
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtSalaryBase.Text = "";
        }
        private void DGView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadToText();
        }

        private void DGView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadToText();
        }

        private void DGView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadToText();
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            SetToText();
            btAddNew.Visible = false;
            btSave.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btAddNew.Visible = true;
            btSave.Visible = false;
            int gender = 1;
            if (cboGender.SelectedText == "Nam")
            {
                gender = 0;
            }
            string mysql = "Insert into k3d_employee (id, name, job, gender, phone, address, salary_base) VALUES(null,'" 
                + txtName.Text + "','"
                + txtJob.Text + "',"
                + gender + ",'"
                + txtPhone.Text + "','"
                + txtAddress.Text + "',"
                + txtSalaryBase.Text + ")";
            myDBConnection = new cMySQLConnection();
            myDBConnection.Insert(mysql);

            LoadData();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int gender = 1;
            if (cboGender.SelectedText == "Nam")
            {
                gender = 0;
            }
            string mysql = "Update k3d_employee set name='" + txtName.Text 
                +"', job='" + txtJob.Text
                + "', gender=" + gender
                + ", phone='" + txtPhone.Text
                + "', address='" + txtAddress.Text
                + "', salary_base=" + txtSalaryBase.Text
                + " Where id=" + txtStt.Text;
                
            myDBConnection = new cMySQLConnection();
            myDBConnection.Update(mysql);
            LoadData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string mysql = "DELETE FROM k3d_employee WHERE id=" + txtStt.Text;
            myDBConnection = new cMySQLConnection();
            myDBConnection.Delete(mysql);
            LoadData();
        }
    }
}
