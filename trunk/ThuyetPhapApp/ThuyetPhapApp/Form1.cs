using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ThuyetPhapApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            //Khởi tạo các cột dữ liệu List View            
            lvVideo.Columns.Add("Tên");
            lvVideo.Columns.Add("Thời gian");
            lvVideo.Columns.Add("Lượt xem");
            lvVideo.View = System.Windows.Forms.View.LargeIcon;
            
            TreeNode N = new TreeNode("Chùa Long Viễn", 0, 1);
                        
            //Load dữ liệu từ file XML của Chùa Long Viễn
            var docCat1 = XDocument.Load("http://chualongvien.com/model/load/CategoryBType/all");
            var docCat2 = XDocument.Load("http://chualongvien.com/model/load/CategoryVideo/all");

            //Thực hiện truy vấn để lấy dữ  liệu về
            var qryCat1 = from c in docCat1.Root.Descendants("object")
                              select c;

            foreach (var obj in qryCat1)
            {
                string StrId = obj.Element("id").Value;
                string StrName = obj.Element("name").Value;

                //Thêm danh mục cha
                TreeNode N1 = new TreeNode(StrName,0 , 1);
                
                //Thêm danh mục con
                var qryCat2 = from c1 in docCat2.Root.Descendants("object")
                              where (c1.Element("btype").Value == StrId) 
                              select c1;

                foreach (var obj1 in qryCat2)
                {
                    string StrId1   = obj1.Element("id").Value;
                    string StrName1 = obj1.Element("name").Value;
                    TreeNode N2 = new TreeNode(StrName1, 0, 1);
                    N2.Tag = StrId1;
                    N1.Nodes.Add(N2);
                }
                N.Nodes.Add(N1);
            }
            trvCategory.Nodes.Add(N);
        }
                
        private void trvCategory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            //Khi nhấn vào mục cấp thứ 2 của cây dữ liệu thì mới xử lí
            if (e.Node.Level == 2)
            {
                //Xóa sạch dữ liệu trước đó
                lvVideo.Items.Clear();

                //Nạp danh sách  Video Từ Website chualongvien.com
                var docVideo = XDocument.Load("http://chualongvien.com/model/findby/VideoLibrary/" + e.Node.Tag);
                var qryVideo = from c in docVideo.Root.Descendants("object")
                                select c;

                foreach (var obj in qryVideo)
                {
                    string StrId    = obj.Element("id").Value;
                    string StrName  = obj.Element("name").Value;
                    string StrURL   = obj.Element("url").Value;
                    string StrTime  = obj.Element("time").Value;
                    string StrCount = obj.Element("count").Value;

                    var Video = new ListViewItem(new[] { StrName, StrTime, StrCount });
                    Video.Tag = StrURL;
                    Video.ImageIndex = 0;
                    lvVideo.Items.Add(Video);
                }
                
            }
        }

        private void lvVideo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = lvVideo.SelectedItems;
            //MessageBox.Show(items[0].Tag.ToString());
            sfMovie.Movie = items[0].Tag.ToString();
        }

                
    }
}
