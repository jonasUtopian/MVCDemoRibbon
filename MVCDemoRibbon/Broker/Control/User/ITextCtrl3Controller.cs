using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Control.User
{
    interface ITextCtrl3Controller : ICtrlController
    {
        MVCDemoRibbon.Broker.View.User.ITextCtrl3View TextCtrl3View { get; }
    }
}
