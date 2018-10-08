using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.View;

namespace MVCDemoRibbon.Broker.Control
{
    public interface IController
    {
        IView View { get; }
        void ShowViewDialog();
        void ShowView();
        void CloseView();
    }
}
