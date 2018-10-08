using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.Control;
using MVCDemoRibbon.Broker.View;
using MVCDemoRibbon.View;
using Jonas.Tool.UserKeyBoard;
using MVCDemoRibbon.Configure;
using MVCDemoRibbon.Controller;
using Jonas.Tool.Authority;
using Jonas.Common;
using Jonas.Database.OrmLite.Control.Repositories;
using Jonas.Database.OrmLite.Model;

namespace MVCDemoRibbon.Controllers
{
    class LoginController : ILoginController
    {
        #region  Method

        public LoginController(Logger logger)
        {
            m_logger = logger;
            this.Initialize();
        }

        private void Initialize()
        {
            this.m_login = false;

            AccountRepository accountRepository = new AccountRepository();
            m_accounts = accountRepository.All();

            this.m_view = new LoginView();

            string account = string.Empty;
            string password = string.Empty;
            AppSettings.GetRemember(ref account, ref password);
            if (m_accounts != null)
            {
                try
                {
                    Account user = m_accounts.First(item => item.Name.Equals(account));
                    this.m_view.Remember = true;
                    this.m_view.User = account;
                    this.m_view.Password = password;
                }
                catch (Exception)
                {
                }
            }

            this.m_view.OnLogin += view_OnLogin;
            this.m_view.OnExit += view_OnExit;
            this.m_view.OnKeyboard += view_OnKeyboard;
            this.m_view.ViewForm.ShowDialog();
        }

        void view_OnKeyboard(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            KeyBoard keyBoard = KeyBoard.CreateKeyBoard(ctrl.Location);
            keyBoard.ShowDialog();
        }

        void view_OnExit(object sender, EventArgs e)
        {
            m_view.ViewForm.Close();   
        }

        void view_OnLogin(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker() { WorkerReportsProgress = true };
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        private bool CheckAccount(ref string message)
        {
            if (string.Empty == this.m_view.User)
            {
                message = "请输入账号!";
                return false;
            }

            try
            {
                Account user = m_accounts.First(item => item.Name.Equals(this.m_view.User));
                if (!user.Password.Equals(this.m_view.Password))
                {
                    message = "密码错误!";
                    return false;
                }

                if (this.m_view.Remember)
                {
                    AppSettings.SaveRemember(this.m_view.User, this.m_view.Password);
                }

                return true;
            }
            catch (Exception)
            {
                message = "账号不存在!";
            }

            return false;
        }

        private bool CheckAuthority()
        {
            string deskey = AppSettings.GetAuthorityKey();
            if (null == deskey
                || deskey.Equals(string.Empty))
            {
                m_register = false;
                //this._view.DisplayStateLabelControl.Text = "软件未授权，请及时处理！";
                return false;
            }

            Security.CryptographyKey = AppSettings.GetCryptographyKey();
            string sourceKey = Security.GetSourceKey(deskey);
            if (sourceKey.Equals(ComputerInfo.GetLocalComputerInfo()))
            {
                m_register = true;
                //this._view.DisplayStateLabelControl.Text = "软件已授权，欢迎使用！";
                return true;
            }
            else
            {
                m_register = false;
                //this._view.DisplayStateLabelControl.Text = "软件授权码不匹配，请及时处理！";
                return false;
            }
        }

        private void Login(BackgroundWorker worker)
        {
            int step = 0;
            worker.ReportProgress(step++, "开始登陆");

            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                worker.ReportProgress(step++, string.Format("登陆中,{0}s ...", i + 1));
            }
            
            string message = "登陆成功!";
            this.m_login = CheckAccount(ref message);
            worker.ReportProgress(step++, message);
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            try
            {
                //using (DevExpress.Utils.WaitDialogForm dlg = new DevExpress.Utils.WaitDialogForm("请稍等", "正在登录中...",
                //new System.Drawing.Size(200, 50),
                //this.m_view.ViewForm))
                //{
                    this.Login(worker);
                //}
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.m_login)
            {
                m_mainController = new MainRibbonController(m_logger) as IController;
                m_view.ViewForm.Close();
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.m_view.Message = e.UserState.ToString();
        }
        #endregion  Method

        #region  Property
        public ILoginView LoginView
        {
            get { return m_view; }
        }
        public IController MainController
        {
            get { return m_mainController; }
        }

        #endregion  Property

        #region  Filed

        /// <summary>
        /// the view
        /// </summary>
        private ILoginView m_view;
        private IController m_mainController;
        private bool m_login;
        private bool m_register;
        private Logger m_logger;
        private IList<Account> m_accounts;
        #endregion  Filed
    }
}
