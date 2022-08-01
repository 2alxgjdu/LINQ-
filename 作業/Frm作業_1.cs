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
    public partial class Frm作業_1 : Form
    { 
        public Frm作業_1()
        {
            
            InitializeComponent();
            ordersTableAdapter1.Fill(dataSet11.Orders);
            order_DetailsTableAdapter1.Fill(dataSet11.Order_Details);
            productsTableAdapter1.Fill(dataSet11.Products);
            totalpage = dataSet11.Products.Count;
            students_scores = new List<Student>()
                                         {
                                            new Student{ Name = "Mark", Class = "CS_101", Java = 60, Csharp = 60, Linq = 50, Gender = "Male" },
                                            new Student{ Name = "Dio", Class = "CS_102", Java = 20, Csharp = 75, Linq = 100, Gender = "Male" },
                                            new Student{ Name = "Jojo", Class = "CS_101", Java = 70, Csharp = 50, Linq = 75, Gender = "Female" },
                                            new Student{ Name = "Lita", Class = "CS_102", Java = 90, Csharp = 30, Linq = 85, Gender = "Female" },
                                            new Student{ Name = "Tracy", Class = "CS_101", Java = 40, Csharp = 90, Linq = 90, Gender = "Female" },
                                            new Student{ Name = "Henry", Class = "CS_102", Java = 85, Csharp = 40, Linq = 70, Gender = "Male" },

                                          };
        }

        List<Student> students_scores;

        public class Student
        {
            public string Name { get; set; }
            public string Class { get; set; }
            public int Java { get; set; }
            public int Csharp { get; internal set; }
            public int Linq { get; set; }
            public string Gender { get; set; }
        }

        int count = 0;  
        int totalpage = 0;
        //void Page()
        //{

        //    int x = Convert.ToInt32(textBox1.Text);
        //    var q = from o in dataSet11.Products.Skip(x*(count-1)).Take(x)
        //            select o;
        //    dataGridView2.DataSource = q.ToList();
        //}

        
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void 下一頁_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            //MessageBox.Show(""+dataSet11.Products.Count);
            //totalpage = dataSet11.Products.Count;
            int x = Convert.ToInt32(textBox1.Text);
            count+=x; 
            //countpage++;
            var q = from o in dataSet11.Products
                    select o;
            if(count-x==0)
            dataGridView2.DataSource = q.Skip(0).Take(x).ToList();
            else
             dataGridView2.DataSource = q.Skip(count).Take(x).ToList();
            //this.nwDataSet1.Products.Take(10);//Top 10 Skip(10)

            //Distinct()
            if (count+x > 0)
              上一頁.Enabled = true;
            
            if (count+x >=totalpage )  下一頁.Enabled = false; 

            
           
        }

        private void button14_Click(object sender, EventArgs e)
        { 
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files =  dir.GetFiles();

            this.dataGridView1.DataSource = files;
            var q = from homework in files
                    where homework.Extension == ".log"
                    select homework;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            #region 搜尋 班級學生成績

            // 
            // 共幾個 學員成績 ?						

            // 找出 前面三個 的學員所有科目成績					
            // 找出 後面兩個 的學員所有科目成績					

            // 找出 Name 'aaa','bbb','ccc' 的學成績						

            // 找出學員 'bbb' 的成績	                          

            // 找出除了 'bbb' 學員的學員的所有成績 ('bbb' 退學)	


            // 數學不及格 ... 是誰 
            #endregion
           
            string s = cbbox.Text;
            if (s == "所有學員成績") {
                var q = from n in students_scores
                        orderby n.Name ascending
                        select n;
                dataGridView1.DataSource = q.ToList();
            }
            else if (s == "找出前面三個的學員所有科目成績")
            {
                var q =( from n in students_scores
                       orderby n.Name ascending
                        select n).Take(3);
                dataGridView2.DataSource = q.ToList();
            }
            else if (s == "找出後面兩個的學員所有科目成績")
            {
                var q = (from n in students_scores
                         orderby n.Name descending
                         select n).Take(2);
                dataGridView2.DataSource = q.ToList();
            }
            else if (s == "找出女同學的成績")
            {
                var q = from n in students_scores
                        where n.Gender== "Female"
                        select n;
                dataGridView2.DataSource = q.ToList();
            }
            else if (s == "找出所有同學除了JAVA的成績")
            {
                var q = (from n in students_scores
                         select new { n.Name,n.Linq,n.Csharp,n.Gender});
                dataGridView2.DataSource = q.ToList();
            }
            else if (s == "找出LINQ成績不及格的同學")
            {
                var q = from n in students_scores
                        where n.Linq<60
                         select n;
                dataGridView2.DataSource = q.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files =  dir.GetFiles();

            this.dataGridView1.DataSource = files;
            var q = from homework in files
                    where homework.CreationTime.Year==2019
                    orderby homework.CreationTime.Minute ascending
                    select homework;

            this.dataGridView1.DataSource = q.ToList();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView1.DataSource = files;
            var q = from homework in files
                    where homework.Length > 1024*10
                    select homework;
            this.dataGridView1.DataSource = q.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {

           
            dataGridView1.DataSource = dataSet11.Orders;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear() ;
            dataGridView2.Columns.Clear();
            int x = int.Parse(comboBox1.Text);
            var q2 = from z in dataSet11.Orders
                     where z.OrderDate.Year == x && !z.IsShippedDateNull() && !z.IsShipRegionNull() && !z.IsShipPostalCodeNull()
                     select z;
            dataGridView2.DataSource = q2.ToList();

            var q = from p in q2.ToList()
                    join s in dataSet11.Order_Details
                   on p.OrderID equals s.OrderID

                    select p;
            dataGridView1.DataSource = q.ToList();
        }

        private void 上一頁_Click(object sender, EventArgs e)
        {
            //123
            dataGridView2.Columns.Clear();
            //countpage--;
            int x = Convert.ToInt32(textBox1.Text);
            count -= x;
            var q = from o in dataSet11.Products.Skip(count).Take(x)
                    select o;
            dataGridView2.DataSource = q.ToList();
            if (count  < -1) 
            {
                dataGridView2.Columns.Clear();
                上一頁.Enabled = false; 
            }
   
            
            if (count+x < totalpage)下一頁.Enabled = true;
            
            
           
        }

        private void button37_Click(object sender, EventArgs e)
        {
            
            string a = studentname.Text;
            var q = students_scores.Where(n => n.Name == a).Select(n=>new {
                姓名 = n.Name,
                Java成績 = n.Java,
                Csharp成績 = n.Csharp,
                Linq成績 = n.Linq,
                總成績 =new[] { n.Java , n.Csharp ,n.Linq }.Sum(),
                平均 = new[] { n.Java ,n.Csharp , n.Linq }.Average(),
                最高分 = new[] { n.Java, n.Csharp, n.Linq }.Max(),
                最低分= new[]{n.Java, n.Csharp, n.Linq}.Min()
                                
            });
            dataGridView2.DataSource = q.ToList();
            //new {.....  Min=33, Max=34.}
            // 找出 'aaa', 'bbb' 'ccc' 學員 國文數學兩科 科目成績  |		

            //個人 所有科的  sum, min, max, avg

        }
        int  Max(int a,int b,int c)
        {
            int[]x= { a, b, c };
            int max = 0;
            for(int i = 0;i<x.Length;i++)
            {
                if (max < x[i])
                    max = x[i];
            }
            return max;
        }
        int Min(int a, int b, int c)
        {
            int[] x = { a, b, c };
            int min = x[0];
            for (int i = 0; i < x.Length; i++)
            {
                if (min > x[i])
                    min = x[i];
            }
            return min;
        }
        private void Frm作業_1_Load(object sender, EventArgs e)
        {
            var q = from n in students_scores
                    select n.Name;
            foreach (string i in q)studentname.Items.Add(i);


            var q2 = from x in dataSet11.Orders
                     select x.OrderDate.Year;
            foreach (var j in q2.Distinct()) comboBox1.Items.Add(j);
            string[] s = { "所有學員成績", "找出前面三個的學員所有科目成績", "找出後面兩個的學員所有科目成績","找出女同學的成績","找出所有同學除了JAVA的成績","找出LINQ成績不及格的同學"};
            foreach (string x in s) cbbox.Items.Add(x);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var q = from o in dataSet11.Products
                    select o;
            dataGridView2.DataSource = q.Skip(count).Take(x).ToList();
            if (count + x > 0)
                上一頁.Enabled = true;

            if (count + x >= totalpage) 下一頁.Enabled = false;
        }
    }
}
