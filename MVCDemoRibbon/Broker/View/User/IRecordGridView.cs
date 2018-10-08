using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View.User
{
    interface IRecordGridView : ICtrlView
    {
        DevExpress.XtraGrid.Views.Grid.GridView GridViewRecords { get; }
        System.Windows.Forms.BindingNavigator BindingNavigator { get; }
        System.Windows.Forms.BindingSource BindingSourceRecord { get; }
        DevExpress.XtraGrid.Columns.GridColumn ColTime { get; }
        DevExpress.XtraGrid.Columns.GridColumn GetColChannel(int index);

    }
}
