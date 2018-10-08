using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Control.User
{
    interface ITextCtrl2Controller : ICtrlController
    {
        MVCDemoRibbon.Broker.View.User.ITextCtrl2View TextCtrl2View { get; }
    }
}
