using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Control.User
{
    interface ITextCtrl4Controller : ICtrlController
    {
        MVCDemoRibbon.Broker.View.User.ITextCtrl4View TextCtrl4View { get; }
    }
}
