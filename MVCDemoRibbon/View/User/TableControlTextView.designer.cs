namespace MVCDemoRibbon.View.User
{
    partial class TableControlTextView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mseconds = new DevExpress.XtraEditors.TextEdit();
            this.txt_date = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.sbt_transform = new DevExpress.XtraEditors.SimpleButton();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.sbZoomUp = new DevExpress.XtraEditors.SimpleButton();
            this.btZoomDown = new DevExpress.XtraEditors.SimpleButton();
            this.btReset = new DevExpress.XtraEditors.SimpleButton();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mseconds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Location = new System.Drawing.Point(12, 12);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage2;
            this.navigationFrame1.SelectedPageIndex = 0;
            this.navigationFrame1.Size = new System.Drawing.Size(131, 479);
            this.navigationFrame1.TabIndex = 0;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.listBoxControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(131, 479);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Items.AddRange(new object[] {
            "&1OK 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16",
            "&1OK 21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36",
            "&1OK 41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56",
            "&1OK 61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76",
            "&1OK 81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96",
            "&1OK 101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116",
            "",
            "&1ERR 22",
            "&1READCODE 0"});
            this.listBoxControl1.Location = new System.Drawing.Point(16, 12);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(98, 452);
            this.listBoxControl1.TabIndex = 0;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(131, 479);
            // 
            // chart1
            // 
            chartArea2.AxisX.LabelStyle.Format = "yyyy-MM-dd-HH:mm:ss";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(165, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(304, 232);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "毫秒值";
            // 
            // txt_mseconds
            // 
            this.txt_mseconds.Location = new System.Drawing.Point(565, 26);
            this.txt_mseconds.Name = "txt_mseconds";
            this.txt_mseconds.Size = new System.Drawing.Size(167, 20);
            this.txt_mseconds.TabIndex = 3;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(565, 80);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(296, 20);
            this.txt_date.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "日期";
            // 
            // sbt_transform
            // 
            this.sbt_transform.Location = new System.Drawing.Point(755, 25);
            this.sbt_transform.Name = "sbt_transform";
            this.sbt_transform.Size = new System.Drawing.Size(106, 23);
            this.sbt_transform.TabIndex = 6;
            this.sbt_transform.Text = "转换";
            // 
            // sbAdd
            // 
            this.sbAdd.Location = new System.Drawing.Point(1022, 83);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(106, 23);
            this.sbAdd.TabIndex = 8;
            this.sbAdd.Text = "添加数据";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // sbZoomUp
            // 
            this.sbZoomUp.Location = new System.Drawing.Point(1022, 153);
            this.sbZoomUp.Name = "sbZoomUp";
            this.sbZoomUp.Size = new System.Drawing.Size(106, 23);
            this.sbZoomUp.TabIndex = 9;
            this.sbZoomUp.Text = "放大";
            this.sbZoomUp.Click += new System.EventHandler(this.sbZoomUp_Click);
            // 
            // btZoomDown
            // 
            this.btZoomDown.Location = new System.Drawing.Point(1022, 230);
            this.btZoomDown.Name = "btZoomDown";
            this.btZoomDown.Size = new System.Drawing.Size(106, 23);
            this.btZoomDown.TabIndex = 10;
            this.btZoomDown.Text = "缩小";
            this.btZoomDown.Click += new System.EventHandler(this.btZoomDown_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(1022, 295);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(106, 23);
            this.btReset.TabIndex = 11;
            this.btReset.Text = "初始";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // TableControlTextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btZoomDown);
            this.Controls.Add(this.sbZoomUp);
            this.Controls.Add(this.sbAdd);
            this.Controls.Add(this.sbt_transform);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mseconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.navigationFrame1);
            this.Name = "TableControlTextView";
            this.Size = new System.Drawing.Size(1410, 514);
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mseconds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_date.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_mseconds;
        private DevExpress.XtraEditors.TextEdit txt_date;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton sbt_transform;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraEditors.SimpleButton sbZoomUp;
        private DevExpress.XtraEditors.SimpleButton btZoomDown;
        private DevExpress.XtraEditors.SimpleButton btReset;
    }
}