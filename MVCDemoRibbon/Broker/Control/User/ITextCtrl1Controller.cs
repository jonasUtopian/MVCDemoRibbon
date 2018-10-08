using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Control.User
{
    interface ITextCtrl1Controller : ICtrlController
    {
        MVCDemoRibbon.Broker.View.User.ITextCtrl1View TextCtrl1View { get; }
    }
}
