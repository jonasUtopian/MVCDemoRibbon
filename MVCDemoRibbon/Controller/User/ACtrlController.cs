using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDemoRibbon.Broker.Control.User;
using MVCDemoRibbon.Broker.View.User;
using MVCDemoRibbon.View;
using MVCDemoRibbon.Broker.Control;
using Jonas.Common;
using MVCDemoRibbon.Model.Extra;

namespace MVCDemoRibbon.Controller.User
{
    public abstract class ACtrlController : ICtrlController
    {
        #region  Method 方法
        public ACtrlController(IMdiRibbonController mdiNavigateController, Logger logger, UserEventArgs userEventArgs)
        {
            m_userEventArgs = userEventArgs;
            m_mdiRibbonController = mdiNavigateController;
            m_logger = logger;
        }

        protected ICtrlView CreateView()
        {
            this.m_view = null;
            try
            {
                this.m_view = FactoryContrl.CreateCtrl(m_viewName) as ICtrlView;
                this.m_view.Ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            catch (Exception ex)
            {
                m_logger.Error(ex);
            }

            return this.m_view;
        }

        public virtual void Start()
        {

        }

        public virtual void Stop()
        {

        }

        #endregion  Method

        #region  Property   属性
        public string ViewName
        {
            get { return m_viewName; }
            set { m_viewName = value; }
        }

        public ICtrlView View
        {
            get { return this.m_view; }
        } 
 
        public UserEventArgs UserEventArgs
        {
            get { return m_userEventArgs; }
        }

        public IMdiRibbonController MdiRibbonController
        {
            get { return this.m_mdiRibbonController; }
        }

        public Logger Logger
        {
            get { return m_logger; }
        }
        #endregion  Property

        #region  Filed  字段
        private string m_viewName = "BaseControl";
        private ICtrlView m_view;
        private UserEventArgs m_userEventArgs;
        private IMdiRibbonController m_mdiRibbonController;
        private Logger m_logger;
        #endregion  Filed
    }
}
