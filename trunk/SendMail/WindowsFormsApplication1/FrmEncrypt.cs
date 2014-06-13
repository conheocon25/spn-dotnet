using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmEncrypt : Form
    {
        public FrmEncrypt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string encryptedstring = MyEncrypt.Encrypt(txtEncrypt.Text, "654789spncompanyadmin368068...");
            txtEncryptResult.Text = encryptedstring;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string decryptedstring = MyEncrypt.Decrypt(txtDecrypt.Text, "654789spncompanyadmin368068...");
            txtDecryptResult.Text = decryptedstring;
        }
    }
}
