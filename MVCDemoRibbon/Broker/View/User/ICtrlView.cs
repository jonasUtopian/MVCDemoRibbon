using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View.User
{
    public interface ICtrlView
    {
        System.Windows.Forms.Control Ctrl { get; }
        SynchronizationContext SyncContext { get; }
    }
}
