using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View.User
{
    interface IBarChartView : ICtrlView
    {
        DevExpress.XtraCharts.ChartControl ChartControl { get; }
        System.Windows.Forms.BindingSource RecordDataBindingSource { get; }
    }
}
