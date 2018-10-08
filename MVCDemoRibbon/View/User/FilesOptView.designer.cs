namespace MVCDemoRibbon.View.User
{
    partial class FilesOptView
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_FromPath = new DevExpress.XtraEditors.TextEdit();
            this.txt_ToPath = new DevExpress.XtraEditors.TextEdit();
            this.btn_SelectFromPath = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SelectToPath = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Copy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FromPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ToPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(103, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "From：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(103, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "To：";
            // 
            // txt_FromPath
            // 
            this.txt_FromPath.Location = new System.Drawing.Point(149, 68);
            this.txt_FromPath.Name = "txt_FromPath";
            this.txt_FromPath.Size = new System.Drawing.Size(248, 20);
            this.txt_FromPath.TabIndex = 2;
            // 
            // txt_ToPath
            // 
            this.txt_ToPath.Location = new System.Drawing.Point(149, 112);
            this.txt_ToPath.Name = "txt_ToPath";
            this.txt_ToPath.Size = new System.Drawing.Size(248, 20);
            this.txt_ToPath.TabIndex = 3;
            // 
            // btn_SelectFromPath
            // 
            this.btn_SelectFromPath.Location = new System.Drawing.Point(416, 64);
            this.btn_SelectFromPath.Name = "btn_SelectFromPath";
            this.btn_SelectFromPath.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFromPath.TabIndex = 4;
            this.btn_SelectFromPath.Text = "...";
            // 
            // btn_SelectToPath
            // 
            this.btn_SelectToPath.Location = new System.Drawing.Point(416, 111);
            this.btn_SelectToPath.Name = "btn_SelectToPath";
            this.btn_SelectToPath.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectToPath.TabIndex = 5;
            this.btn_SelectToPath.Text = "...";
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(416, 166);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy.TabIndex = 6;
            this.btn_Copy.Text = "copy";
            // 
            // FilesOptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 472);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_SelectToPath);
            this.Controls.Add(this.btn_SelectFromPath);
            this.Controls.Add(this.txt_ToPath);
            this.Controls.Add(this.txt_FromPath);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FilesOptView";
            this.Text = "文件操作";
            ((System.ComponentModel.ISupportInitialize)(this.txt_FromPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ToPath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_FromPath;
        private DevExpress.XtraEditors.TextEdit txt_ToPath;
        private DevExpress.XtraEditors.SimpleButton btn_SelectFromPath;
        private DevExpress.XtraEditors.SimpleButton btn_SelectToPath;
        private DevExpress.XtraEditors.SimpleButton btn_Copy;
    }
}