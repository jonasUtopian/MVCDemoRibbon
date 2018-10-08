namespace MVCDemoRibbon.View.User
{
    partial class LineChartSetupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineChartSetupView));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMinY = new DevExpress.XtraEditors.TextEdit();
            this.textEditMaxY = new DevExpress.XtraEditors.TextEdit();
            this.labelControlSave = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMinY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaxY.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(137, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Y轴最大值：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(137, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Y轴最小值：";
            // 
            // textEditMinY
            // 
            this.textEditMinY.Location = new System.Drawing.Point(223, 66);
            this.textEditMinY.Name = "textEditMinY";
            this.textEditMinY.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditMinY.Properties.Mask.BeepOnError = true;
            this.textEditMinY.Properties.Mask.EditMask = "(\\+?[0-9]*)";
            this.textEditMinY.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditMinY.Properties.NullText = "0";
            this.textEditMinY.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditMinY.Size = new System.Drawing.Size(132, 20);
            this.textEditMinY.TabIndex = 2;
            // 
            // textEditMaxY
            // 
            this.textEditMaxY.Location = new System.Drawing.Point(223, 119);
            this.textEditMaxY.Name = "textEditMaxY";
            this.textEditMaxY.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditMaxY.Properties.Mask.BeepOnError = true;
            this.textEditMaxY.Properties.Mask.EditMask = "(\\+?[0-9]*)";
            this.textEditMaxY.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditMaxY.Properties.NullText = "1000";
            this.textEditMaxY.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditMaxY.Size = new System.Drawing.Size(132, 20);
            this.textEditMaxY.TabIndex = 3;
            // 
            // labelControlSave
            // 
            this.labelControlSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControlSave.Appearance.Image = global::MVCDemoRibbon.Properties.Resources.btnnormal;
            this.labelControlSave.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlSave.AppearanceHovered.Image = global::MVCDemoRibbon.Properties.Resources.btnclick;
            this.labelControlSave.Location = new System.Drawing.Point(574, 351);
            this.labelControlSave.Name = "labelControlSave";
            this.labelControlSave.Size = new System.Drawing.Size(120, 44);
            this.labelControlSave.TabIndex = 15;
            this.labelControlSave.Text = "保存设置";
            // 
            // LineChartSetupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 416);
            this.Controls.Add(this.labelControlSave);
            this.Controls.Add(this.textEditMaxY);
            this.Controls.Add(this.textEditMinY);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "LineChartSetupView";
            this.Text = "折线图设置";
            ((System.ComponentModel.ISupportInitialize)(this.textEditMinY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaxY.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditMinY;
        private DevExpress.XtraEditors.TextEdit textEditMaxY;
        private DevExpress.XtraEditors.LabelControl labelControlSave;
    }
}