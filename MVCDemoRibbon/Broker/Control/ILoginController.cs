using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Control
{
    interface ILoginController
    {
        MVCDemoRibbon.Broker.View.ILoginView LoginView { get; }

        IController MainController { get; }
    }
}
