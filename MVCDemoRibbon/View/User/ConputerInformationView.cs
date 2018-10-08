using Jonas.Tool.Authority;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCDemoRibbon.View.User
{
    public partial class ConputerInformationView : BaseCtrl
    {
        public ConputerInformationView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (DevExpress.Utils.WaitDialogForm dlg = new DevExpress.Utils.WaitDialogForm("请稍等",
                "查询设备信息...",
                new System.Drawing.Size(200, 50),
                base.ParentForm))
            {
                this.memoEditPCInfo.Text = ComputerInfo.GetLocalComputerInfo();
            }
        }

        private void labelControlGetDesKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.memoEditPCInfo.Text);
            MessageBox.Show("设备信息已复制到剪贴板！");
        }
    }
}
