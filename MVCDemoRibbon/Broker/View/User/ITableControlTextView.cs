using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View.User
{
    public interface ITableControlTextView : ICtrlView
    {
        System.Windows.Forms.DataVisualization.Charting.Chart Chart { get; }
        DevExpress.XtraEditors.TextEdit Txt_mseconds { get; }
        DevExpress.XtraEditors.TextEdit Txt_date { get; }
        DevExpress.XtraEditors.SimpleButton Sbt_transform { get; }
    }
}
