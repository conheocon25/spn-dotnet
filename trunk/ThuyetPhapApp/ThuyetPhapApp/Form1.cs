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
            
            TreeNode rootNode = new TreeNode("Chùa Long Viễn", 0, 1);
                        
            //Load dữ liệu từ file XML của Chùa Long Viễn
            var typeData = XDocument.Load("http://chualongvien.com/model/load/CategoryBType/all");
            var subTypeData = XDocument.Load("http://chualongvien.com/model/load/CategoryVideo/all");

            //Thực hiện truy vấn để lấy dữ  liệu về
            var types = 
from c in typeData.Root.Descendants("object")
select c;

            foreach (var type in types)
            {
                string id = type.Element("id").Value;
                string name = type.Element("name").Value;

                //Thêm danh mục cha
                TreeNode node = new TreeNode(name, 0, 1);
                
                //Thêm danh mục con
                var subTypes = 
from c1 in subTypeData.Root.Descendants("object")
where (c1.Element("btype").Value == id) 
select c1;

                foreach (var subType in subTypes)
                {
                    string subId   = subType.Element("id").Value;
                    string subName = subType.Element("name").Value;
                    TreeNode childNode = new TreeNode(subName, 0, 1);
                    childNode.Tag = subId;
                    node.Nodes.Add(childNode);
                }
                rootNode.Nodes.Add(node);
            }
            categoryTreeView.Nodes.Add(rootNode);
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
                var videos = from c in docVideo.Root.Descendants("object")
                                select c;

                foreach (var video in videos)
                {
                    string id = video.Element("id").Value;
                    string name = video.Element("name").Value;
                    string url = video.Element("url").Value;
                    string time = video.Element("time").Value;
                    string count = video.Element("count").Value;

                    var item = new ListViewItem(new[] { name, time, count });
                    item.Tag = url;
                    item.ImageIndex = 0;
                    lvVideo.Items.Add(item);
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
