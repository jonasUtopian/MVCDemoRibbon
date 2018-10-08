using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.Control;
using MVCDemoRibbon.Broker.View;
using MVCDemoRibbon.View;
using Jonas.Common;

namespace MVCDemoRibbon.Controller
{
    public abstract class AMainController : IController
    {
        #region  Method
        public AMainController(Logger logger)
        {
            m_logger = logger;
        }
        /// <summary>
        /// set the specified view.
        /// </summary>
        /// <param name="view">The view.</param>
        public IView CreateView()
        {
            this.m_view = FactoryWindow.CreateView(this.m_viewName) as IView;
            return this.m_view;
        }

        /// <summary>
        /// Shows the view dialog.
        /// 模式对话框
        /// </summary>
        public void ShowViewDialog()
        {
            m_view.ViewForm.ShowDialog();
        }
        /// <summary>
        /// show the view 
        /// 非模式对话框
        /// </summary>
        public void ShowView()
        {
            m_view.ViewForm.Show();
            m_view.ViewForm.Activate();
        }
        /// <summary>
        /// Closes the view.
        /// </summary>
        public void CloseView()
        {
            m_view.ViewForm.Close();
        }
        #endregion  Method
        
        #region  Property

        /// <summary>
        /// get the view
        /// </summary>
        public IView View
        {
            get { return this.m_view; }
        }

        public string ViewName
        {
            get { return m_viewName; }
            set { m_viewName = value; }
        }

        public Logger Logger
        {
            get { return m_logger; }
        }
        #endregion  Property

        #region  Filed
        protected const string _ViewRibbon = "Ribbon";
        protected const string _ViewNavigate = "Navigate";
        /// <summary>
        /// The view
        /// </summary>
        private IView m_view;
        private string m_viewName;
        private Logger m_logger;
        #endregion  Filed
    }
}
