using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDemoRibbon.Broker.View.User;
using MVCDemoRibbon.Broker.View;

namespace MVCDemoRibbon.Broker.Control
{
    public interface IMdiRibbonController
    {
        IMainRibbonView MainRibbonView { get; }
        ICtrlView FindChildView(string viewName);
        void CloseChildren();
        void ShowChildView(string viewName);
    }
}
