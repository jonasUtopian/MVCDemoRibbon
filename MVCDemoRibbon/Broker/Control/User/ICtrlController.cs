using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Control.User
{
    public interface ICtrlController
    {
        string ViewName { get; set; }
        View.User.ICtrlView View { get; }
        void Start();
        void Stop();
    }
}
