using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MVCDemoRibbon.Broker.View;
using Jonas.Common.Bindings;
using System.Threading;

namespace MVCDemoRibbon.View
{
    public partial class MainRibbonView : DevExpress.XtraEditors.XtraForm, IMainRibbonView
    {
        #region  Method

        public MainRibbonView()
        {
            InitializeComponent();
            m_syncContext = SynchronizationContext.Current;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SynchronizationContextProvider.CreateSynchronizationContext(WindowsFormsSynchronizationContext.Current);
        }

        /// <summary>
        /// Shows the view dialog.
        /// </summary>
        public void ShowViewDialog()
        {
            this.ShowDialog();
        }
        /// <summary>
        /// show the view 
        /// </summary>
        public void ShowView()
        {
            this.Show();
            this.Activate();
        }
        /// <summary>
        /// Closes the view.
        /// </summary>
        public void CloseView()
        {
            this.Close();
        }

        public void OnUpdateUI(Action action)
        {
            m_syncContext.Post(new SendOrPostCallback(o =>
            {
                action();
            }), null);
        }

        #endregion  Method

        #region  Property

        public Form ViewForm
        {
            get { return this as Form; }
        }

        public DevExpress.XtraBars.Navigation.NavigationFrame ViewsFrame 
        {
            get { return this.viewsFrame; } 
        }

        public BarButtonItem[] ButtonItems
        {
            get
            {
                List<BarButtonItem> items = new List<BarButtonItem>(64);
                foreach (BarItem item in this.ribbon.Items)
                {
                    if (item is BarButtonItem)
                    {
                        BarButtonItem button = item as BarButtonItem;
                        items.Add(button);
                    }
                }

                return items.ToArray();
            }
        }
        public DevExpress.XtraBars.BarStaticItem BarStaticItemUser 
        {
            get { return this.barStaticItemUser; } 
        }
        public DevExpress.XtraBars.BarButtonItem BarButtonItemAuthorityInfo 
        {
            get { return this.barButtonItemAuthorityInfo; } 
        }

        DevExpress.XtraBars.Ribbon.RibbonControl IMainRibbonView.Ribbon 
        {
            get { return this.ribbon; }
        }

        DevExpress.XtraBars.SkinRibbonGalleryBarItem IMainRibbonView.SkinRibbonGalleryBarItem 
        {
            get { return this.skinRibbonGalleryBarItem; }
        }

        DevExpress.XtraBars.PopupMenu IMainRibbonView.PopMenuAppearance 
        {
            get { return this.pmAppearance; } 
        }

        DevExpress.LookAndFeel.DefaultLookAndFeel IMainRibbonView.DefaultLookAndFeel 
        {
            get { return this.defaultLookAndFeel; } 
        }

        System.Windows.Forms.NotifyIcon IMainRibbonView.NotifyIconRibbon 
        {
            get { return this.notifyIconRibbon; }  
        }

        public DevExpress.XtraBars.BarStaticItem BarStaticItemDatasource 
        {
            get { return this.barStaticItemDatasource; } 
        }

        public System.Windows.Forms.Timer TimerAuthorityCheck 
        {
            get { return this.timerAuthorityCheck; }  
        }

        public DevExpress.XtraBars.BarListItem BarListItemSingleChart 
        {
            get { return this.barListItemSingleChart; }  
        }
        public DevExpress.XtraBars.BarStaticItem BarStaticItemSelectChart 
        {
            get { return this.barStaticItemSelectChart; }  
        }

        public DevExpress.XtraBars.BarListItem BarListItemExportChart 
        {
            get { return this.barListItemExportChart; } 
        }
        public DevExpress.XtraBars.BarStaticItem BarStaticItemExportChart 
        {
            get { return this.barStaticItemExportChart; } 
        }
        #endregion  Property

        #region Filed 字段
        private SynchronizationContext m_syncContext;
        #endregion

    }
}