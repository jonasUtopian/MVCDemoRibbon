using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Control.User
{
    interface ITextCtrl5Controller : ICtrlController
    {
        MVCDemoRibbon.Broker.View.User.ITextCtrl5View TextCtrl5View { get; }
    }
}
