using MVCDemoRibbon.Broker.View.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Control.User
{
    public interface IEmployeeController : ICtrlController
    {
        IEmployeeView EmployeeView { get; }
    }
}
