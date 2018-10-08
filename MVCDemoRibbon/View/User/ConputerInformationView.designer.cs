namespace MVCDemoRibbon.View.User
{
    partial class ConputerInformationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConputerInformationView));
            this.memoEditPCInfo = new DevExpress.XtraEditors.MemoEdit();
            this.labelControlGetDesKey = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditPCInfo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEditPCInfo
            // 
            this.memoEditPCInfo.Location = new System.Drawing.Point(12, 12);
            this.memoEditPCInfo.Name = "memoEditPCInfo";
            this.memoEditPCInfo.Size = new System.Drawing.Size(642, 213);
            this.memoEditPCInfo.TabIndex = 12;
            // 
            // labelControlGetDesKey
            // 
            this.labelControlGetDesKey.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControlGetDesKey.Appearance.Image = global::MVCDemoRibbon.Properties.Resources.btnnormal;
            this.labelControlGetDesKey.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlGetDesKey.AppearanceHovered.Image = global::MVCDemoRibbon.Properties.Resources.btnclick;
            this.labelControlGetDesKey.Location = new System.Drawing.Point(483, 231);
            this.labelControlGetDesKey.Name = "labelControlGetDesKey";
            this.labelControlGetDesKey.Size = new System.Drawing.Size(120, 44);
            this.labelControlGetDesKey.TabIndex = 14;
            this.labelControlGetDesKey.Text = "复制设备信息";
            this.labelControlGetDesKey.Click += new System.EventHandler(this.labelControlGetDesKey_Click);
            // 
            // ConputerInformationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 282);
            this.Controls.Add(this.labelControlGetDesKey);
            this.Controls.Add(this.memoEditPCInfo);
            this.Name = "ConputerInformationView";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.memoEditPCInfo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEditPCInfo;
        private DevExpress.XtraEditors.LabelControl labelControlGetDesKey;
    }
}