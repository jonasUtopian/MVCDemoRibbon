using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MVCDemoRibbon.Broker.View.User;
using System.Threading;

namespace MVCDemoRibbon.View.User
{
    public partial class BaseCtrl : XtraUserControl, ICtrlView
    {
        public BaseCtrl()
        {
            InitializeComponent();
            m_syncContext = SynchronizationContext.Current;
        }

        public Control Ctrl
        {
            get { return this as Control; }
        }

        public SynchronizationContext SyncContext
        {
            get { return m_syncContext; }
        }

        private SynchronizationContext m_syncContext;
    }
}
