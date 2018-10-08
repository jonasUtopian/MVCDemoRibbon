namespace MVCDemoRibbon.View.User
{
    partial class AuthorityView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorityView));
            this.memoEditDesKey = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDisplay = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAuthority = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEditDesKey
            // 
            this.memoEditDesKey.Location = new System.Drawing.Point(76, 19);
            this.memoEditDesKey.Name = "memoEditDesKey";
            this.memoEditDesKey.Size = new System.Drawing.Size(613, 191);
            this.memoEditDesKey.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "授权码：";
            // 
            // labelControlDisplay
            // 
            this.labelControlDisplay.Location = new System.Drawing.Point(76, 245);
            this.labelControlDisplay.Name = "labelControlDisplay";
            this.labelControlDisplay.Size = new System.Drawing.Size(48, 14);
            this.labelControlDisplay.TabIndex = 12;
            this.labelControlDisplay.Text = "授权信息";
            // 
            // labelControlAuthority
            // 
            this.labelControlAuthority.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControlAuthority.Appearance.Image = global::MVCDemoRibbon.Properties.Resources.btnnormal;
            this.labelControlAuthority.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlAuthority.AppearanceHovered.Image = global::MVCDemoRibbon.Properties.Resources.btnclick;
            this.labelControlAuthority.Location = new System.Drawing.Point(545, 230);
            this.labelControlAuthority.Name = "labelControlAuthority";
            this.labelControlAuthority.Size = new System.Drawing.Size(120, 44);
            this.labelControlAuthority.TabIndex = 13;
            this.labelControlAuthority.Text = "授权";
            this.labelControlAuthority.Click += new System.EventHandler(this.labelControlAuthority_Click);
            // 
            // AuthorityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 295);
            this.Controls.Add(this.labelControlAuthority);
            this.Controls.Add(this.labelControlDisplay);
            this.Controls.Add(this.memoEditDesKey);
            this.Controls.Add(this.labelControl2);
            this.Name = "AuthorityView";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDesKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEditDesKey;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControlDisplay;
        private DevExpress.XtraEditors.LabelControl labelControlAuthority;
    }
}