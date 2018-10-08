using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Model
{
    interface ILoginModel
    {
        string User { get; set; }
        string Password { get; set; }
        bool Remember { get; set; }
        string Message { get; set; }
    }
}
