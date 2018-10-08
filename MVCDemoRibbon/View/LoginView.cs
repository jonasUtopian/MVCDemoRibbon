using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.View;

namespace MVCDemoRibbon.View
{
    public partial class LoginView : XtraForm, ILoginView
    {
        #region  Method

        public LoginView()
        {
            InitializeComponent();
            this.labelControlLogin.Click += labelControlLogin_Click;
            this.labelControlExit.Click += labelControlExit_Click;
            this.labelCtrl_Keyboard.Click += labelCtrl_Keyboard_Click;
            this.progressBarControl.Visible = false;
        }

        void labelCtrl_Keyboard_Click(object sender, EventArgs e)
        {
            if (null != OnKeyboard)
            {
                OnKeyboard(sender, e);
            }
        }

        void labelControlExit_Click(object sender, EventArgs e)
        {
            if (null != OnExit)
            {
                OnExit(sender, e);
            }
        }

        void labelControlLogin_Click(object sender, EventArgs e)
        {
            if (null != OnLogin)
            {
                OnLogin(sender, e);
            }      
        }
        /// <summary>
        /// Shows the view dialog.
        /// 模式对话框
        /// </summary>
        public void ShowViewDialog()
        {
            this.ShowDialog();
        }
        /// <summary>
        /// show the view 
        /// 非模式对话框
        /// </summary>
        public void ShowView()
        {
            this.Show();
            this.Activate();
        }
        /// <summary>
        /// Closes the view.
        /// </summary>
        public void CloseView()
        {
            this.Close();
        }
        #endregion  Method

        #region  Property

        [Bindable(true)]
        public string User
        {
            get { return this.accountTextEdit.Text; }
            set
            {
                this.accountTextEdit.Text = value;
            }
        }

        [Bindable(true)]
        public string Password
        {
            get { return this.passwordTextEdit.Text; }
            set
            {
                this.passwordTextEdit.Text = value;
            }
        }

        [Bindable(true)]
        public bool Remember
        {
            get { return this.rememberCheckEdit.Checked; }
            set
            {
                this.rememberCheckEdit.Checked = value;
            }
        }

        [Bindable(true)]
        public string Message
        {
            get { return this.labelControl1.Text; }
            set
            {
                this.labelControl1.Text = value;
            }
        }
        /// <summary>
        /// get the form
        /// </summary>
        Form IView.ViewForm
        {
            get { return this as Form; }
        }
        #endregion  Property

        #region  Filed  字段
        public event EventHandler OnLogin = null;
        public event EventHandler OnExit = null;
        public event EventHandler OnKeyboard = null;
        #endregion  Filed

    }
}
