using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View.User
{
    interface ILineChartSetupView : ICtrlView
    {
        DevExpress.XtraEditors.TextEdit TextEditMinY { get; }
        DevExpress.XtraEditors.TextEdit TextEditMaxY { get; }
        DevExpress.XtraEditors.LabelControl LabelControlSave { get; }
    }
}
