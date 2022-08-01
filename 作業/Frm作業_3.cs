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
    public partial class Frm作業_3 : Form
    {
        public Frm作業_3()
        { 

            InitializeComponent();

            students_scores = new List<Student>()
                                         {
                                            new Student{ Name = "Mark", Java = R.Next(0,100), Csharp =R.Next(0,100), Linq = R.Next(0,100) },
                                            new Student{ Name = "Dio", Java = R.Next(0,100), Csharp = R.Next(0,100), Linq =  R.Next(0,100)},
                                            new Student{ Name = "Jojo", Java =  R.Next(0,100), Csharp =  R.Next(0,100), Linq =  R.Next(0,100) },
                                            new Student{ Name = "Lita", Java =  R.Next(0,100), Csharp = R.Next(0,100), Linq = R.Next(0,100)},
                                            new Student{ Name = "Henry", Java =  R.Next(0,100), Csharp =  R.Next(0,100), Linq =  R.Next(0,100)},

                                          };
            subject = new List<科目成績>()
            {
                new 科目成績{Name="Jave"},
                new 科目成績{Name="Csharp"},
                new 科目成績{Name="Linq"}
            };
        }
        List<Student> students_scores;
        List<科目成績> subject;
        Random R = new Random();
        public class Student
        {
            public string Name { get; set; }
            public string Class { get; set; }
            public int Java { get; set; }
            public int Csharp { get; internal set; }
            public int Linq { get; set; }
            public string Gender { get; set; }

            
        }
        public class 科目成績
        {
            public string Name { get; set; }
        }  
        string[] 科目 = { "Java", "Csharp", "Linq" };


        private void button36_Click(object sender, EventArgs e)
        {
            學生圖表.Series.Clear();
            string s = cbbox.Text;
            var q = from p in students_scores
                    select new
                    {
                        Name = p.Name,
                        Java=p.Java,
                        Csharp=p.Csharp,
                        Linq=p.Linq,
                        平均成績 =new[] { p.Csharp, p.Java, p.Linq }.Average(),
                        總分 = new[] { p.Java, p.Linq, p.Csharp }.Sum(),
                    };
 
                學生圖表.DataSource = q.ToList();
                學生圖表.Series.Add(s);
                學生圖表.Series[0].XValueMember = "Name";
                學生圖表.Series[0].YValueMembers = s;
                學生圖表.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                學生圖表.Series[0].BorderWidth = 3;
                學生圖表.ChartAreas[0].AxisY.Maximum = 300;          
        }
        private void button33_Click(object sender, EventArgs e)
        {
            // split=> 數學成績 分成 三群 '待加強'(60~69) '佳'(70~89) '優良'(90~100) 
            string s = comboBox1.Text;
            if (s == "Java")
            {
                var q = from p in students_scores
                        group p by 成績優劣(p.Java) into g
                        select new
                        {
                            區分 = g.Key,
                            人數 = g.Count()
                        };
                dataGridView1.DataSource = q.ToList();
                學生圖表.DataSource = q.ToList();
                學生圖表.Series[0].XValueMember = "區分";
                學生圖表.Series[0].YValueMembers = "人數";
                學生圖表.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                學生圖表.Series[0].BorderWidth = 3;
            }
            else if (s == "Csharp")
            {
                var q = from p in students_scores
                        group p by 成績優劣(p.Csharp) into g
                        select new
                        {
                            區分 = g.Key,
                            人數 = g.Count()
                        };
                dataGridView1.DataSource = q.ToList();
                學生圖表.DataSource = q.ToList();
                學生圖表.Series[0].XValueMember = "區分";
                學生圖表.Series[0].YValueMembers = "人數";
                學生圖表.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                學生圖表.Series[0].BorderWidth = 3;
            }
            else if (s == "Linq")
            {
                var q = from p in students_scores
                        group p by 成績優劣(p.Linq) into g
                        select new
                        {
                            區分 = g.Key,
                            人數 = g.Count()
                        };
                dataGridView1.DataSource = q.ToList();
                學生圖表.DataSource = q.ToList();
                學生圖表.Series[0].XValueMember = "區分";
                學生圖表.Series[0].YValueMembers = "人數";
                學生圖表.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                學生圖表.Series[0].BorderWidth = 3;
            }

        }

        private void Frm作業_3_Load(object sender, EventArgs e)
        {
            string[] s = { "Java", "Csharp", "Linq", "平均成績", "總分" };
            foreach (string x in s) cbbox.Items.Add(x);
            var q = from n in students_scores
                    select n.Name;
            foreach (string i in q) studentname.Items.Add(i);
            string[] ss = { "Java", "Csharp", "Linq" };
            foreach (string xx in ss) comboBox1.Items.Add(xx);
        }
        private void button37_Click(object sender, EventArgs e)
        {

            學生圖表.ChartAreas.Clear();
            學生圖表.ChartAreas.Add("FirstChart");
            學生圖表.Series.Clear();
            if (studentname.Text == "") return;
            string s = studentname.Text;
            學生圖表.Series.Add(s);
            var q = students_scores.Where(i => i.Name == s).Select(i => new { i.Java, i.Csharp, i.Linq });
            foreach(var r in q)
            {
                學生圖表.Series[0].Points.AddXY("Java", r.Java);
                學生圖表.Series[0].Points.AddXY("Linq", r.Linq);
                學生圖表.Series[0].Points.AddXY("Csharp", r.Csharp);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            學生圖表.Series.Clear();
            var q =from s in students_scores
                   select s;
         
            學生圖表.DataSource =q.ToList();

            for (int i = 0; i < 科目.Length; i++)
            {
                學生圖表.Series.Add(科目[i]);
                學生圖表.Series[i].XValueMember = "Name";     
                學生圖表.Series[i].YValueMembers = 科目[i];   
                學生圖表.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                學生圖表.Series[i].BorderWidth = 3;
            }
            學生圖表.ChartAreas[0].AxisY.Maximum = 100;
        }
        string 成績優劣(int x)
        {
            string i;
            if (x >= 90 && x <= 100)
                i = "優等生";
            else if (x >= 60 && x <= 89)
                i = "普等生";
            else { i = "劣等生"; }
            return i;
        }
    }
}
