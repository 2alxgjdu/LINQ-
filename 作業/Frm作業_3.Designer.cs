﻿
namespace 作業
{
    partial class Frm作業_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.學生圖表 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new 作業.DataSet1TableAdapters.TableAdapterManager();
            this.ordersTableAdapter1 = new 作業.DataSet1TableAdapters.OrdersTableAdapter();
            this.productsTableAdapter1 = new 作業.DataSet1TableAdapters.ProductsTableAdapter();
            this.dataSet11 = new 作業.DataSet1();
            this.studentname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.學生圖表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button36.Location = new System.Drawing.Point(29, 106);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(250, 50);
            this.button36.TabIndex = 149;
            this.button36.Text = "搜尋 班級學生成績";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button37.Location = new System.Drawing.Point(29, 203);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(250, 50);
            this.button37.TabIndex = 148;
            this.button37.Text = "每個學生個人成績";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(29, 320);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(250, 50);
            this.button33.TabIndex = 147;
            this.button33.Text = "自己分群";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // 學生圖表
            // 
            chartArea1.Name = "ChartArea1";
            this.學生圖表.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.學生圖表.Legends.Add(legend1);
            this.學生圖表.Location = new System.Drawing.Point(371, 36);
            this.學生圖表.Name = "學生圖表";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.學生圖表.Series.Add(series1);
            this.學生圖表.Size = new System.Drawing.Size(354, 334);
            this.學生圖表.TabIndex = 150;
            this.學生圖表.Text = "chart1";
            title1.Name = "5";
            title2.Name = "6";
            title3.Name = "Title1";
            title4.Name = "Title2";
            this.學生圖表.Titles.Add(title1);
            this.學生圖表.Titles.Add(title2);
            this.學生圖表.Titles.Add(title3);
            this.學生圖表.Titles.Add(title4);
            // 
            // cbbox
            // 
            this.cbbox.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbox.FormattingEnabled = true;
            this.cbbox.Location = new System.Drawing.Point(100, 170);
            this.cbbox.Margin = new System.Windows.Forms.Padding(4);
            this.cbbox.Name = "cbbox";
            this.cbbox.Size = new System.Drawing.Size(176, 21);
            this.cbbox.TabIndex = 153;
            this.cbbox.Text = "Java";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(36, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 152;
            this.label9.Text = "選項:";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Order_DetailsTableAdapter = null;
            this.tableAdapterManager1.OrdersTableAdapter = this.ordersTableAdapter1;
            this.tableAdapterManager1.ProductPhotoTableAdapter = null;
            this.tableAdapterManager1.ProductsTableAdapter = this.productsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = 作業.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentname
            // 
            this.studentname.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.studentname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.studentname.FormattingEnabled = true;
            this.studentname.Location = new System.Drawing.Point(97, 269);
            this.studentname.Margin = new System.Windows.Forms.Padding(4);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(176, 21);
            this.studentname.TabIndex = 156;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(36, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 155;
            this.label7.Text = "學生:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(29, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 157;
            this.button1.Text = "所有班級學生成績";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm作業_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.學生圖表);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button33);
            this.Name = "Frm作業_3";
            this.Text = "Frm作業_3";
            this.Load += new System.EventHandler(this.Frm作業_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.學生圖表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.DataVisualization.Charting.Chart 學生圖表;
        private System.Windows.Forms.ComboBox cbbox;
        private System.Windows.Forms.Label label9;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private DataSet1TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.ComboBox studentname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}