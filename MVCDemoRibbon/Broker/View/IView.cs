using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCDemoRibbon.Broker.View
{
    public interface IView
    {
        /// <summary>
        /// the form
        /// </summary>
        Form ViewForm { get; }
    }
}
