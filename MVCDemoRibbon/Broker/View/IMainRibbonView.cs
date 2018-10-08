using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View
{
    public interface IMainRibbonView : IView
    {
        /// <summary>
        /// Gets the button item.
        /// </summary>
        /// <value>The button item.</value>
        BarButtonItem[] ButtonItems { get; }
        DevExpress.XtraBars.Ribbon.RibbonControl Ribbon { get; }
        DevExpress.XtraBars.SkinRibbonGalleryBarItem SkinRibbonGalleryBarItem { get; }
        DevExpress.XtraBars.PopupMenu PopMenuAppearance { get; }
        DevExpress.LookAndFeel.DefaultLookAndFeel DefaultLookAndFeel { get; }

        System.Windows.Forms.NotifyIcon NotifyIconRibbon { get; }

        DevExpress.XtraBars.BarStaticItem BarStaticItemDatasource { get; }
        DevExpress.XtraBars.BarStaticItem BarStaticItemUser { get; }
        DevExpress.XtraBars.BarButtonItem BarButtonItemAuthorityInfo { get; }
        System.Windows.Forms.Timer TimerAuthorityCheck { get; }
        DevExpress.XtraBars.BarListItem BarListItemSingleChart { get; }
        DevExpress.XtraBars.BarStaticItem BarStaticItemSelectChart { get; }
        DevExpress.XtraBars.BarListItem BarListItemExportChart { get; }
        DevExpress.XtraBars.BarStaticItem BarStaticItemExportChart { get; }

        DevExpress.XtraBars.Navigation.NavigationFrame ViewsFrame { get; }
        void OnUpdateUI(Action action);
    }
}
