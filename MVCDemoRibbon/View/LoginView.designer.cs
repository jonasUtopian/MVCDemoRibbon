namespace MVCDemoRibbon.View
{
    partial class LoginView
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
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.displayLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.rememberCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLogin = new DevExpress.XtraEditors.LabelControl();
            this.labelControlExit = new DevExpress.XtraEditors.LabelControl();
            this.labelCtrl_Keyboard = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.accountTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rememberCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl
            // 
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(167, 430);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(377, 18);
            this.progressBarControl.TabIndex = 1;
            // 
            // displayLabelControl
            // 
            this.displayLabelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.displayLabelControl.Location = new System.Drawing.Point(248, 454);
            this.displayLabelControl.Name = "displayLabelControl";
            this.displayLabelControl.Size = new System.Drawing.Size(197, 14);
            this.displayLabelControl.TabIndex = 2;
            this.displayLabelControl.Text = "Copyright © 2018-2019 JONAS Inc.";
            // 
            // rememberCheckEdit
            // 
            this.rememberCheckEdit.Location = new System.Drawing.Point(197, 368);
            this.rememberCheckEdit.Name = "rememberCheckEdit";
            this.rememberCheckEdit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.rememberCheckEdit.Properties.Appearance.Options.UseForeColor = true;
            this.rememberCheckEdit.Properties.Caption = "Remember password";
            this.rememberCheckEdit.Size = new System.Drawing.Size(148, 19);
            this.rememberCheckEdit.TabIndex = 4;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.EditValue = "123456";
            this.passwordTextEdit.Location = new System.Drawing.Point(248, 230);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.passwordTextEdit.Properties.Appearance.Options.UseFont = true;
            this.passwordTextEdit.Properties.AutoHeight = false;
            this.passwordTextEdit.Properties.UseSystemPasswordChar = true;
            this.passwordTextEdit.Size = new System.Drawing.Size(282, 42);
            this.passwordTextEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(197, 115);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(307, 22);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "欢迎使用";
            this.labelControl1.UseWaitCursor = true;
            // 
            // labelControlLogin
            // 
            this.labelControlLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControlLogin.Appearance.Image = global::MVCDemoRibbon.Properties.Resources.GreenBtn_nor;
            this.labelControlLogin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlLogin.AppearancePressed.Image = global::MVCDemoRibbon.Properties.Resources.GreenBtn_over;
            this.labelControlLogin.Location = new System.Drawing.Point(407, 296);
            this.labelControlLogin.Name = "labelControlLogin";
            this.labelControlLogin.Size = new System.Drawing.Size(123, 39);
            this.labelControlLogin.TabIndex = 2;
            this.labelControlLogin.Text = "登录";
            // 
            // labelControlExit
            // 
            this.labelControlExit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControlExit.Appearance.Image = global::MVCDemoRibbon.Properties.Resources.OrangeBtn_nor;
            this.labelControlExit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlExit.AppearancePressed.Image = global::MVCDemoRibbon.Properties.Resources.OrangeBtn_over;
            this.labelControlExit.Location = new System.Drawing.Point(188, 296);
            this.labelControlExit.Name = "labelControlExit";
            this.labelControlExit.Size = new System.Drawing.Size(123, 39);
            this.labelControlExit.TabIndex = 3;
            this.labelControlExit.Text = "退出";
            // 
            // labelCtrl_Keyboard
            // 
            this.labelCtrl_Keyboard.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelCtrl_Keyboard.Location = new System.Drawing.Point(453, 373);
            this.labelCtrl_Keyboard.Name = "labelCtrl_Keyboard";
            this.labelCtrl_Keyboard.Size = new System.Drawing.Size(51, 14);
            this.labelCtrl_Keyboard.TabIndex = 5;
            this.labelCtrl_Keyboard.Text = "Keyboard";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Image = global::MVCDemoRibbon.Properties.Resources.LoginUserBackground;
            this.labelControl2.Location = new System.Drawing.Point(188, 167);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(342, 42);
            this.labelControl2.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Image = global::MVCDemoRibbon.Properties.Resources.LoginPasswordBackground;
            this.labelControl3.Location = new System.Drawing.Point(188, 230);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(342, 42);
            this.labelControl3.TabIndex = 35;
            // 
            // accountTextEdit
            // 
            this.accountTextEdit.EditValue = "Test";
            this.accountTextEdit.Location = new System.Drawing.Point(248, 167);
            this.accountTextEdit.Name = "accountTextEdit";
            this.accountTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.accountTextEdit.Properties.Appearance.Options.UseFont = true;
            this.accountTextEdit.Properties.AutoHeight = false;
            this.accountTextEdit.Size = new System.Drawing.Size(282, 42);
            this.accountTextEdit.TabIndex = 36;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::MVCDemoRibbon.Properties.Resources.Loginbackground;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.accountTextEdit);
            this.Controls.Add(this.labelCtrl_Keyboard);
            this.Controls.Add(this.labelControlExit);
            this.Controls.Add(this.labelControlLogin);
            this.Controls.Add(this.rememberCheckEdit);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.displayLabelControl);
            this.Controls.Add(this.progressBarControl);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rememberCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl displayLabelControl;
        private DevExpress.XtraEditors.CheckEdit rememberCheckEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlLogin;
        private DevExpress.XtraEditors.LabelControl labelControlExit;
        private DevExpress.XtraEditors.LabelControl labelCtrl_Keyboard;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit accountTextEdit;
    }
}