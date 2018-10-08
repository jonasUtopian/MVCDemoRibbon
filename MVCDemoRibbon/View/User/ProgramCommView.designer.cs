namespace MVCDemoRibbon.View.User
{
    partial class ProgramCommView
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Write = new DevExpress.XtraEditors.TextEdit();
            this.txt_Read = new DevExpress.XtraEditors.TextEdit();
            this.btn_WriteFileData = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ReadFileData = new DevExpress.XtraEditors.SimpleButton();
            this.btn_StartProgram = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SelectPath = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ExePath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Write.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Read.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ExePath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(256, 332);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 14);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Write：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(256, 285);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 14);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Read：";
            // 
            // txt_Write
            // 
            this.txt_Write.Location = new System.Drawing.Point(302, 326);
            this.txt_Write.Name = "txt_Write";
            this.txt_Write.Size = new System.Drawing.Size(248, 20);
            this.txt_Write.TabIndex = 20;
            // 
            // txt_Read
            // 
            this.txt_Read.Location = new System.Drawing.Point(302, 282);
            this.txt_Read.Name = "txt_Read";
            this.txt_Read.Size = new System.Drawing.Size(248, 20);
            this.txt_Read.TabIndex = 19;
            // 
            // btn_WriteFileData
            // 
            this.btn_WriteFileData.Location = new System.Drawing.Point(453, 368);
            this.btn_WriteFileData.Name = "btn_WriteFileData";
            this.btn_WriteFileData.Size = new System.Drawing.Size(75, 23);
            this.btn_WriteFileData.TabIndex = 18;
            this.btn_WriteFileData.Text = "write";
            // 
            // btn_ReadFileData
            // 
            this.btn_ReadFileData.Location = new System.Drawing.Point(323, 368);
            this.btn_ReadFileData.Name = "btn_ReadFileData";
            this.btn_ReadFileData.Size = new System.Drawing.Size(75, 23);
            this.btn_ReadFileData.TabIndex = 17;
            this.btn_ReadFileData.Text = "read";
            // 
            // btn_StartProgram
            // 
            this.btn_StartProgram.Location = new System.Drawing.Point(569, 182);
            this.btn_StartProgram.Name = "btn_StartProgram";
            this.btn_StartProgram.Size = new System.Drawing.Size(75, 23);
            this.btn_StartProgram.TabIndex = 16;
            this.btn_StartProgram.Text = "start";
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.Location = new System.Drawing.Point(569, 127);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectPath.TabIndex = 15;
            this.btn_SelectPath.Text = "...";
            // 
            // txt_ExePath
            // 
            this.txt_ExePath.Location = new System.Drawing.Point(302, 128);
            this.txt_ExePath.Name = "txt_ExePath";
            this.txt_ExePath.Size = new System.Drawing.Size(248, 20);
            this.txt_ExePath.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(256, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 14);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Path：";
            // 
            // ProgramCommView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 519);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_Write);
            this.Controls.Add(this.txt_Read);
            this.Controls.Add(this.btn_WriteFileData);
            this.Controls.Add(this.btn_ReadFileData);
            this.Controls.Add(this.btn_StartProgram);
            this.Controls.Add(this.btn_SelectPath);
            this.Controls.Add(this.txt_ExePath);
            this.Controls.Add(this.labelControl2);
            this.Name = "ProgramCommView";
            this.Text = "ProgramCommView";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Write.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Read.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ExePath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Write;
        private DevExpress.XtraEditors.TextEdit txt_Read;
        private DevExpress.XtraEditors.SimpleButton btn_WriteFileData;
        private DevExpress.XtraEditors.SimpleButton btn_ReadFileData;
        private DevExpress.XtraEditors.SimpleButton btn_StartProgram;
        private DevExpress.XtraEditors.SimpleButton btn_SelectPath;
        private DevExpress.XtraEditors.TextEdit txt_ExePath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}