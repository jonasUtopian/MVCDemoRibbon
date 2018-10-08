using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MVCDemoRibbon.Model.View;
using MVCDemoRibbon.Broker.Control;
using Jonas.Common;
using MVCDemoRibbon.Model.Extra;
using MVCDemoRibbon.Broker.Control.User;
using MVCDemoRibbon.Broker.View.User;
using System.Windows.Forms;

namespace MVCDemoRibbon.Controller.User
{
    public class EmployeeController : ACtrlController, IEmployeeController
    {
        public EmployeeController(IMdiRibbonController mdiNavigateController, Logger logger, UserEventArgs userEventArgs)
            : base(mdiNavigateController, logger, userEventArgs)
        {
            this.ViewName = "EmployeeView";
            Initialize();
        }

        private void Initialize()
        {
            this.m_view = base.CreateView() as IEmployeeView;
            this.m_model = new EmployeeModel{
                SyncContext = m_view.SyncContext,
                Name = "张三",
                Age = 28
            };

            //试用于UI仅仅用于显示数据，而不用于接收输入
            this.m_view.Ctrl.DataBindings.Add(new Binding("EmployeeName", this.m_model, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            this.m_view.Ctrl.DataBindings.Add(new Binding("EmployeeAge", this.m_model, "Age", false, DataSourceUpdateMode.OnPropertyChanged));

            this.m_pause = true;
            this.m_stopped = false;
            this.m_thread = new Thread(new ThreadStart(this.Working));
            this.m_thread.IsBackground = true;
            this.m_thread.Start();
        }

        private void Working()
        {
            while (true)
            {
                if (m_stopped)
                {
                    break;
                }

                if (m_pause)
                {
                    Thread.Sleep(55);
                    continue;
                }

                Thread.Sleep(1000);
                m_model.Age++;
            }
        }

        public override void Start()
        {
            this.m_pause = false;
        }

        public override void Stop()
        {
            //this.m_stopped = true;
            this.m_pause = true;
        }


        #region  Property   属性
        public IEmployeeView EmployeeView
        {
            get { return m_view; }
        }
        #endregion  Property

        #region  Filed  字段
        private IEmployeeView m_view;
        private EmployeeModel m_model;
        private bool m_stopped;
        private bool m_pause;
        private Thread m_thread;
        #endregion  Filed
    }
}
