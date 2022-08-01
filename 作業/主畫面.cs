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
    public partial class 主畫面 : Form
    {
        public 主畫面()
        {
            InitializeComponent();
        }


        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

            Frm作業_3 X = new Frm作業_3();
            X.MdiParent = this;
            X.WindowState = FormWindowState.Maximized;
            X.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
       
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm作業_4 X = new Frm作業_4();
            X.MdiParent = this;
            X.WindowState = FormWindowState.Maximized;
            X.Show();
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void 階梯排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void 關閉目前視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void 關閉所有視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void 主畫面_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Frm作業_1 X = new Frm作業_1();
            X.MdiParent = this;
            X.WindowState = FormWindowState.Maximized;
            X.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Frm作業_2 X = new Frm作業_2();
            X.MdiParent = this;
            X.WindowState = FormWindowState.Maximized;
            X.Show();
        }
    }
}
