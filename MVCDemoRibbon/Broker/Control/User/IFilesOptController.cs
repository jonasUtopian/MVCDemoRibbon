using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDemoRibbon.Broker.View.User;

namespace MVCDemoRibbon.Broker.Control.User
{
    interface IFilesOptController : ICtrlController
    {
        IFilesOptView FilesOptView { get; }
    }
}
