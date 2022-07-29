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
           string[] 科目 = { "Java", "Csharp", "Linq" };
        
        private void button36_Click(object sender, EventArgs e)
        { 
            學生圖表.Series.Clear();
            string s = cbbox.Text;
            學生圖表.DataSource = students_scores;
            學生圖表.Series.Add(s);
            學生圖表.Series[0].XValueMember = "Name";
            學生圖表.Series[0].YValueMembers = s;
            學生圖表.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            學生圖表.Series[0].BorderWidth = 3;
            學生圖表.ChartAreas[0].AxisY.Maximum = 100;

        }
        private void button33_Click(object sender, EventArgs e)
        {
            // split=> 數學成績 分成 三群 '待加強'(60~69) '佳'(70~89) '優良'(90~100) 
        }

        private void Frm作業_3_Load(object sender, EventArgs e)
        {
            string[] s = { "Java", "Csharp", "Linq", "平均成績", "總分" };
            foreach (string x in s) cbbox.Items.Add(x);
            var q = from n in students_scores
                    select n.Name;
            foreach (string i in q) studentname.Items.Add(i);


        }

        private void button37_Click(object sender, EventArgs e)
        {
            string n = studentname.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            學生圖表.Series.Clear();
            學生圖表.DataSource = students_scores;

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
    }
}
