using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCDemoRibbon.Broker.View.User
{
    public interface IGridControlTextView : ICtrlView
    {
        BindingSource ClassesBindingSource { get; }
        BindingSource StudentsBindingSource  {  get;  }
        GridView GridView { get; }
        BindingNavigator BindingNavigator { get; }
        Button BtnPrePrint { get; }
        SimpleButton BtnAddClass { get; }
        SimpleButton BtnDelClass { get; }
        DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit StudentRepository { get; }
    }
}
