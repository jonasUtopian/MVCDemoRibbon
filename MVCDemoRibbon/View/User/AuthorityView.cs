using Jonas.Tool.Authority;
using MVCDemoRibbon.Configure;
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
    public partial class AuthorityView : BaseCtrl
    {
        public AuthorityView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string key = AppSettings.GetAuthorityKey();
            if (key.Equals(string.Empty))
            {
                this.labelControlDisplay.Text = "软件未授权，请及时输入授权码进行授权！";
                return;
            }

            this.memoEditDesKey.Text = key;
            Security.CryptographyKey = AppSettings.GetCryptographyKey();
            string sourceKey = Security.GetSourceKey(key);
            if (sourceKey.Equals(ComputerInfo.GetLocalComputerInfo()))
            {
                AppSettings.SaveAuthorityKey(this.memoEditDesKey.Text);
                this.labelControlDisplay.Text = "软件授权成功，欢迎使用！";
            }
            else
            {
                this.labelControlDisplay.Text = "软件授权码无效，请及时处理！";
            }
        }

        private void labelControlAuthority_Click(object sender, EventArgs e)
        {
            if (this.memoEditDesKey.Text.Equals(string.Empty))
            {
                this.labelControlDisplay.Text = "请输入授权码！";
                return;
            }

            try
            {
                Security.CryptographyKey = AppSettings.GetCryptographyKey();
                string sourceKey = Security.GetSourceKey(this.memoEditDesKey.Text);
                if (sourceKey.Equals(ComputerInfo.GetLocalComputerInfo()))
                {
                    AppSettings.SaveAuthorityKey(this.memoEditDesKey.Text);
                    this.labelControlDisplay.Text = "软件授权成功，欢迎使用！";
                }
                else
                {
                    this.labelControlDisplay.Text = "软件授权码无效，请重试！";
                }
            }
            catch (Exception ex)
            {
                this.memoEditDesKey.Text = string.Empty;
                this.labelControlDisplay.Text = "软件授权失败，请重试！";
            }
        }
    }
}
