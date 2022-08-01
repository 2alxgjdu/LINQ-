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
            productsTableAdapter1.Fill(dataSet11.Products);
            ordersTableAdapter1.Fill(dataSet11.Orders);
            order_DetailsTableAdapter1.Fill(dataSet11.Order_Details);
        }
        NorthwindEntities dbContext = new NorthwindEntities();
        string 比大小(int x)
        {
            string i;
            if (x <= 5) {i = "很小";}
            else if (x > 5 && x <= 10){i = "普通";}
            else{i = "大";}return i;
        }
        string 檔案大小(long x)
        {
            string y;
            if (x< 1024){y = "KB";}
            else if (x > 1024*1024 && x < 1024*1024 * 1024)
            {y = "GB";}
            else{y = "MB";}
            return  y;
        }
        string 產品價格(decimal  x)
        {
            string i;
            if (x<30) { i = "低"; }
            else if (x < 100 && x > 30) { i = "中"; }
            else { i = "高"; }
            return i;
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

        private void button8_Click(object sender, EventArgs e)
        {
            var q = from p in dataSet11.Products
                    group p by 產品價格(p.UnitPrice) into g
                    select new { 
                        價格分類=g.Key,
                        分類數量=g.Count(),
                        區域=g
                    };
            this.dataGridView1.DataSource = q.ToList();
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                string s = $"{group.價格分類} ( {group.分類數量} )";
                TreeNode y = this.treeView1.Nodes.Add(s);

                foreach (var item in group.區域)
                {
                    y.Nodes.Add(item.ProductName.ToString());

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q = (from p in dbContext.Order_Details.AsEnumerable()
                     select new
                     {
                         總銷售金額 =  p.UnitPrice *Convert.ToDecimal( p.Quantity) * Convert.ToDecimal(1 - p.Discount)
                     }).Sum(p=>p.總銷售金額);
            MessageBox.Show("總銷售金額"+q);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            var q = from o in dataSet11.Orders
                    group o by o.OrderDate.Year into g
                    select new
                    {
                        訂單年份=g.Key,
                        該年份數量=g.Count(),
                        區域=g
                    };
            this.dataGridView1.DataSource = q.ToList();
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                string s = $"{group.訂單年份} ( {group.該年份數量} )";
                TreeNode y = this.treeView1.Nodes.Add(s);

                foreach (var item in group.區域)
                {
                    y.Nodes.Add(item.CustomerID.ToString());

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            var q = from o in dataSet11.Orders
                    group o by o.OrderDate.Year into g
                    select new
                    {
                        訂單年份 = g.Key,
                        數量 = g.Count(),
                        訂單裡面的GP = g.GroupBy(k => k.OrderDate.Month).Select(m => new { Key = m.Key, Mcount = m.Count(), Mmonth = m }
                        )

                    };
            this.dataGridView1.DataSource = q.ToList();
            this.treeView1.Nodes.Clear();
            foreach (var group in q)
            {
                TreeNode y = this.treeView1.Nodes.Add($"{group.訂單年份}年");

                foreach (var item in group.訂單裡面的GP)
                {
                    TreeNode y1 = y.Nodes.Add($"{item.Key}月");
                    foreach(var m in item.Mmonth)
                    {
                        y1.Nodes.Add(m.CustomerID);
                    }

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Order_Details.AsEnumerable()
                    
                    group p by p.Order.EmployeeID into g
                    orderby g.Sum(p=> p.UnitPrice * p.Quantity * Convert.ToDecimal(1 - p.Discount)) descending
                    select new
                    {
                        銷售員工=g.Key,
                        銷售價排行 = $" {g.Sum(p => p.UnitPrice * p.Quantity * Convert.ToDecimal(1 - p.Discount)):c3}"
                    };
            dataGridView2.DataSource = q.Take(5).ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Products.AsEnumerable()
                    orderby p.UnitPrice descending
                    select new
                    {
                        產品= p.ProductName,
                        產品價格=p.UnitPrice,
                        產品類別=p.Category.CategoryName
                    };
            dataGridView2.DataSource = q.Take(5).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Order_Details.AsEnumerable()
                    group p by p.Order.OrderDate.Value.Year into g
                    select new
                    {
                        年份1 = g.Key,
                        銷售額1 =g.Sum(p=>p.Quantity*p.UnitPrice*Convert.ToDecimal(1-p.Discount))
                    };
            var q2 = from p in dbContext.Order_Details.AsEnumerable()
                    group p by p.Order.OrderDate.Value.Year into g
                    select new
                    {
                        年份2= g.Key+1,
                        銷售額2 = g.Sum(p => p.Quantity * p.UnitPrice * Convert.ToDecimal(1 - p.Discount))
                    };
            var x = from p in q
                    join i in q2
                    on p.年份1 equals i.年份2
                    select new
                    {
                       銷售成長率年份=p.年份1,
                       銷售額=p.銷售額1,
                       該年份銷售成長率=(p.銷售額1-i.銷售額2)/p.銷售額1               
                    };
            dataGridView1.DataSource = x.ToList();
            dataGridView2.DataSource = q.ToList();
            chart1.DataSource = x.ToList();
            chart1.Series[0].XValueMember = "銷售成長率年份";
            chart1.Series[0].YValueMembers =" 該年份銷售成長率";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series[0].BorderWidth = 3;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var q = (from p in dbContext.Products.AsEnumerable()
                    where p.UnitPrice>300
                    select p).Any();
            MessageBox.Show("看來是" + q);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (CBX.Text == "") return;
            var q = from a in dbContext.Order_Details
                    join b in dbContext.Orders
                    on a.OrderID equals b.OrderID
                    join c in dbContext.Products
                    on a.ProductID equals c.ProductID
                    join d in dbContext.Categories
                    on c.CategoryID equals d.CategoryID
                    where b.RequiredDate.Value.Year.ToString() == CBX.Text
                    group a by d.CategoryName into g
                    select new
                    {
                        g.Key,
                        sum = g.Sum(i => i.Quantity)
                    };
            var r = from p in dbContext.Products
                    join od in dbContext.Order_Details
                    on p.ProductID equals od.ProductID
                    join o in dbContext.Orders
                    on od.OrderID equals o.OrderID
                    join c in dbContext.Categories
                    on p.CategoryID equals c.CategoryID
                    join g in q
                    on c.CategoryName equals g.Key
                    where o.RequiredDate.Value.Year.ToString() == CBX.Text
                    select new
                    {
                        銷售額=g.sum,
                        p.Category.CategoryName
                    };
            dataGridView1.DataSource = r.OrderByDescending(i => i.CategoryName).Distinct().ToList();
            chart1.DataSource = r.ToList().Distinct();
            chart1.Series[0].XValueMember = "CategoryName";
            chart1.Series[0].YValueMembers = "銷售額";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series[0].BorderWidth = 3;



        }

        private void Frm作業_4_Load(object sender, EventArgs e)
        {
            var q2 = from x in dataSet11.Orders
                     select x.OrderDate.Year;
            foreach (var j in q2.Distinct()) CBX.Items.Add(j);
        }
    } 
}
