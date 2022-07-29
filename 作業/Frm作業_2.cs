using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業
{
    public partial class Frm作業_2 : Form
    { 
        public Frm作業_2()
        {
            InitializeComponent();
            productPhotoTableAdapter1.Fill(dataSet11.ProductPhoto);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //22
            var q = from p in dataSet11.ProductPhoto
                    select p;
            dataGridView1.DataSource = q.ToList();
        }

        private void Frm作業_2_Load(object sender, EventArgs e)
        {
            var q = from p in dataSet11.ProductPhoto
                    orderby p.ModifiedDate ascending
                    select p.ModifiedDate.Year;
            foreach (var x in q.Distinct())
                comboBox3.Items.Add(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var t1 = dateTimePicker1.Value;
            var t2 = dateTimePicker2.Value;
            var q = from p in dataSet11.ProductPhoto
                    where p.ModifiedDate >= t1 && p.ModifiedDate <= t2
                    select p;
            dataGridView1.DataSource = q.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x =int.Parse( comboBox3.Text);
            var q = from p in dataSet11.ProductPhoto
                    where p.ModifiedDate.Year == x
                    select p;
            dataGridView1.DataSource = q.ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string x = comboBox2.Text;
            if (x == "第一季")
            {
                var q = from p in dataSet11.ProductPhoto
                        where p.ModifiedDate.Month < 4
                        select p;
                dataGridView1.DataSource = q.ToList();
            }
            else if (x == "第二季")
            {
                var q = from p in dataSet11.ProductPhoto
                        where p.ModifiedDate.Month >3 && p.ModifiedDate.Month < 7
                        select p;
                dataGridView1.DataSource = q.ToList();
            }
            else if (x == "第三季")
            {
                var q = from p in dataSet11.ProductPhoto
                        where p.ModifiedDate.Month > 6&& p.ModifiedDate.Month < 10
                        select p;
                dataGridView1.DataSource = q.ToList();
            }
            else if (x == "第四季")
            {
                var q = from p in dataSet11.ProductPhoto
                        where p.ModifiedDate.Month > 9
                        select p;
                dataGridView1.DataSource = q.ToList();
            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        { 
            Byte[] byteData = (Byte[])dataGridView1.CurrentRow.Cells["LargePhoto"].Value;
            MemoryStream memoryStream = new MemoryStream(byteData);
            pictureBox1.Image = Image.FromStream(memoryStream);
            memoryStream.Close();
        }
    }
}
