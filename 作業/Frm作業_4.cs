using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業
{
    public partial class Frm作業_4 : Form
    {
        public Frm作業_4()
        {
            InitializeComponent();
        }
        string 比大小(int x)
        {
            string i;
            if (x <= 5) {
                i = "很小";
            }
            else if (x > 5 && x <= 10)
            {
                i = "普通";
            }
            else
            {
                i = "大";
            }
            return i;
        }
        string 檔案大小(long x)
        {
            string y;
            if (x< 1024)
            {
                y = "KB"                    ;
            }
            else if (x > 1024*1024 && x < 1024*1024 * 1024)
            {
                y = "GB";
            }
            else
            {
                y = "MB";
            }
            return  y;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            int[] x = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
            var q = from i in x
                    group i by 比大小(i) into g
                    select new { 區域=g.Key,
                        數目=g.Count()  ,  
                        群組=g
                    };
            dataGridView1.DataSource = q.ToList();
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                string s = $"{group.區域} ( {group.數目} )";
                TreeNode y = this.treeView1.Nodes.Add(s);// group.MyKey.ToString());

                foreach (var item in group.群組)
                {
                    y.Nodes.Add(item.ToString());

                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();

            //this.dataGridView1.DataSource = files;
            var q = from f in files
                    group f by 檔案大小(f.Length) into g
                    select new
                    {
                        檔案大小=g.Key,
                        數量=g.Count(),
                        區分=g
                    };
            this.dataGridView1.DataSource = q.ToList();
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                string s = $"{group.檔案大小} ( {group.數量} )";
                TreeNode y = this.treeView1.Nodes.Add(s);// group.MyKey.ToString());

                foreach (var item in group.區分)
                {
                    y.Nodes.Add(item.ToString());

                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            var q = from f in files
                    orderby f.CreationTime.Year ascending
                    group f by f.CreationTime.Year into g
                    select new
                    {
                        年分=g.Key,
                        數量=g.Count(),
                        區域=g
                    };
            this.dataGridView1.DataSource = q.ToList();
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                string s = $"{group.年分} ( {group.數量} )";
                TreeNode y = this.treeView1.Nodes.Add(s);// group.MyKey.ToString());

                foreach (var item in group.區域)
                {
                    y.Nodes.Add(item.ToString());

                }
            }
        }
    } 
}
