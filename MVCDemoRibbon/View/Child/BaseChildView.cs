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
using System.Threading;

namespace MVCDemoRibbon.View.Child
{
    public partial class BaseChildView : XtraForm
    {
        #region  Method

        public BaseChildView()
        {
            InitializeComponent();
            m_syncContext = SynchronizationContext.Current;
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

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (!isAllowedToClose)
            {
                e.Cancel = true;
            }
        }

        public void OnUpdateUI(Action action)
        {
            SyncContext.Post(new SendOrPostCallback(o =>
            {
                action();
            }), null);
        }
        #endregion  Method

        #region  Property

        /// <summary>
        /// get the form
        /// </summary>
        public Form ViewForm
        {
            get { return this as Form; }
        }

        public bool isAllowedToClose
        {
            get;
            set;
        }

        public SynchronizationContext SyncContext
        {
            get { return m_syncContext; }
            protected set { m_syncContext = value; }
        }
        #endregion  Property

        #region  Filed  字段
        private SynchronizationContext m_syncContext;
        #endregion  Filed   
    }
}
