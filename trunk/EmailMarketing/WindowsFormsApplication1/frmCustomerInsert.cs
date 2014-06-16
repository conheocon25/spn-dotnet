using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmailMarketing
{
    public partial class frmCustomerInsert : Form
    {
        public int IdTag = 1;
        public int State = -1;

        public frmCustomerInsert()
        {            
            InitializeComponent();
        }

        private void frmCustomerInsert_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CApp.connect();

            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_customer(name, phone, email, id_tag) VALUES(@name, @phone, @email, @id_tag)", CApp.connection);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@id_tag", IdTag);
            cmd.ExecuteNonQuery();
            State = 1;                            
            CApp.close();

            this.Close();
        }
               
    }
}
