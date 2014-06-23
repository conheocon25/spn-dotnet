using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailMarketing
{
    public partial class frmTemplateUpdate : Form
    {        
        public string NameTemplate = "";
        public string Content = "";

        public frmTemplateUpdate(CTemplate Template)
        {
            InitializeComponent();
            
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(Template.Content);
            doc.DocumentNode.SelectSingleNode("//h1[@id='Title']").InnerHtml = "<h1>Tiêu đề của tui nè</h1>";
            //doc.Save(
            txtName.Text = Template.Name;
            txtContent.Text = doc.DocumentNode.OuterHtml;
            
            //webPreview.DocumentText = Template.Content;
            webPreview.DocumentText = doc.DocumentNode.OuterHtml;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {     
            NameTemplate = txtName.Text;
            Content = txtContent.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            webPreview.DocumentText = txtContent.Text;
        }

        private void frmTemplateUpdate_Load(object sender, EventArgs e)
        {                        
            webPreview.Navigate("about:blank");
            if (webPreview.Document != null)
            {
                webPreview.Document.Write(string.Empty);
            }
            webPreview.DocumentText = txtContent.Text;
        }
    }
}
