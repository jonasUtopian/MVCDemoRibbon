using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using MVCDemoRibbon.Broker.Control;
using MVCDemoRibbon.Broker.Control.User;
using MVCDemoRibbon.Broker.View;
using MVCDemoRibbon.Broker.View.User;
using MVCDemoRibbon.View;
using Jonas.Common;
using MVCDemoRibbon.Model.Extra;
using DevExpress.XtraBars.Navigation;

namespace MVCDemoRibbon.Controller
{
    class MainRibbonController : AMainController, IMdiRibbonController
    {
        #region  Method

        public MainRibbonController(Logger logger)
            :base(logger)
        {
            this.ViewName = "MainRibbonView";
            m_pages = new Dictionary<string, NavigationPage>();
            m_userCtrls = new Dictionary<string, ICtrlController>();
            m_userEventArgs = new UserEventArgs();
            m_curUserName = string.Empty;
            this.Initialize();
        }

        /// <summary>
        /// Initialize the view
        /// </summary>
        private void Initialize()
        {
            base.Logger.Info("MainRibbonController.Initialize");
            this.m_view = base.CreateView() as IMainRibbonView;

            InitializeSkins();

            foreach (BarItem button in this.m_view.ButtonItems)
            {
                if (button.Visibility == BarItemVisibility.Never)
                    continue;

                button.ItemClick += button_ItemClick;
            }

            this.m_view.Ribbon.ApplicationButtonClick += Ribbon_ApplicationButtonClick;

            InitializeNotifyicon();

            this.m_view.BarListItemExportChart.Strings.Add("折线图");
            this.m_view.BarListItemExportChart.Strings.Add("柱状图");

            this.m_view.ViewForm.FormClosing += ViewForm_FormClosing;
            this.m_view.ViewForm.SizeChanged += ViewForm_SizeChanged;
        }

        void BarListItemSingleChart_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            using (DevExpress.Utils.WaitDialogForm dlg = new DevExpress.Utils.WaitDialogForm("请稍等",
                "初始化数据...",
                new System.Drawing.Size(200, 50),
                this.m_view.ViewForm))
            {

            }
        }

        private void InitializeNotifyicon() 
        {
            this.m_view.NotifyIconRibbon.Icon = Properties.Resources.logo;
            this.m_view.NotifyIconRibbon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.m_view.NotifyIconRibbon.BalloonTipText = "最小化到托盘了";
            this.m_view.NotifyIconRibbon.Text = "jonas.wang";
            this.m_view.NotifyIconRibbon.Visible = true;
            this.m_view.NotifyIconRibbon.DoubleClick += NotifyIconShowForm;
    
            System.Windows.Forms.MenuItem[] mnuItms = new System.Windows.Forms.MenuItem[3];  
            mnuItms[0] = new System.Windows.Forms.MenuItem();   
            mnuItms[0].Text = "显示窗口";
            mnuItms[0].Click += new System.EventHandler(this.NotifyIconShowForm);   
            mnuItms[1] = new System.Windows.Forms.MenuItem("-");   
            mnuItms[2] = new System.Windows.Forms.MenuItem();   
            mnuItms[2].Text = "退出系统";   
            mnuItms[2].Click += new System.EventHandler(this.ExitSelect);   
            mnuItms[2].DefaultItem = true;
            this.m_view.NotifyIconRibbon.ContextMenu = new System.Windows.Forms.ContextMenu(mnuItms);
        } 

        public void ExitSelect(object sender, System.EventArgs e) 
        {
            this.m_view.ViewForm.Close();
        }

        public void NotifyIconShowForm(object sender, EventArgs e) 
        {
            if (this.m_view.ViewForm.WindowState == System.Windows.Forms.FormWindowState.Minimized) 
            {
                this.m_view.ViewForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                this.m_view.ViewForm.Show();
                this.m_view.ViewForm.ShowInTaskbar = true;
            } 
        }

        void ViewForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.m_view.ViewForm.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                this.m_view.ViewForm.ShowInTaskbar = false;
                this.m_view.NotifyIconRibbon.ShowBalloonTip(1000);
            }
        }

        void InitializeSkins()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinPopupMenu(this.m_view.PopMenuAppearance);
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(this.m_view.SkinRibbonGalleryBarItem, true);
            this.m_view.PopMenuAppearance.ItemLinks[1].BeginGroup = true;

            string skinName = Configure.AppSettings.GetSkinName();
            if (!string.IsNullOrEmpty(skinName))
            {
                this.m_view.DefaultLookAndFeel.LookAndFeel.SkinName = skinName;
            }
        }

        private static bool canCloseFunc(System.Windows.Forms.DialogResult parameter)
        {
            if (parameter != System.Windows.Forms.DialogResult.Cancel)
                return true;
            else
                return false;
        }

        void ViewForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "确定", Result = System.Windows.Forms.DialogResult.Yes };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "取消", Result = System.Windows.Forms.DialogResult.No };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Description = "确认退出软件？" };

            action.Commands.Add(command1);
            action.Commands.Add(command2);

            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutProperties properties = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutProperties()
            {
                ButtonSize = new System.Drawing.Size(100, 35),
                Style = DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutStyle.MessageBox
            };

            Predicate<System.Windows.Forms.DialogResult> predicate = canCloseFunc;
            if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this.m_view.ViewForm, action, properties, predicate) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                this.CloseChildren();
                Configure.AppSettings.SaveSkinName(this.m_view.DefaultLookAndFeel.LookAndFeel.SkinName);
            }
        }

        void Ribbon_ApplicationButtonClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            FlyoutMessageBox.Show("click", "hello world", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button1);
        }

        void MainViewTypeListItem_ListItemClick(object sender, ListItemClickEventArgs e)
        {

        }

        /// <summary>
        /// called when BarButtonItem been clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (null == e.Item.Tag)
                return;

            string tag = e.Item.Tag.ToString();
            if (string.IsNullOrEmpty(tag))
                return;

            try
            {
                string[] cmds = tag.Split('_');
                if (null == cmds
                    || cmds.Length != 2)
                {
                    return;
                }

                if (cmds[0].Equals("View"))
                {
                    OnShowChildView(cmds[1], sender, e); 
                }
                else if (cmds[0].Equals("Operate"))
                {
                    OnClickOperate(cmds[1]);
                }

            }
            catch (Exception ex)
            {
                base.Logger.Error(ex);
            }        
        }

        private void OnClickOperate(string funcName)
        {
            switch (funcName)
            {
                case "Exit":
                    {
                        if (OnExit())
                        {
                            System.Windows.Forms.Application.Exit();
                        }
                        break;
                    }
                case "Min":
                    {
                        this.m_view.ViewForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                        break;
                    }
                case "Help":
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("帮助");
                        break;
                    }
                default:
                    break;
            }
        }

        private bool OnExit()
        {
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "确定", Result = System.Windows.Forms.DialogResult.Yes };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "取消", Result = System.Windows.Forms.DialogResult.No };
            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Description = "退出软件？" };

            action.Commands.Add(command1);
            action.Commands.Add(command2);

            DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutProperties properties = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutProperties()
            {
                ButtonSize = new System.Drawing.Size(100, 35),
                Style = DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutStyle.MessageBox
            };

            Predicate<System.Windows.Forms.DialogResult> predicate = canCloseFunc;
            if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this.m_view.ViewForm, action, properties, predicate) == System.Windows.Forms.DialogResult.No)
            {
                return false;
            }
            else
            {
                CloseChildren();
                return true;
            }
        }

        private void OnShowChildView(string controllerName, object sender = null, ItemClickEventArgs e=null)
        {
            if (m_userCtrls.ContainsKey(m_curUserName))
                m_userCtrls[m_curUserName].Stop();

            NavigationPage page = FindView(controllerName);
            if (null == page)
                page = CreatePage(controllerName);

            m_userCtrls[controllerName].Start();
            m_view.ViewsFrame.SelectedPage = page;
            m_curUserName = controllerName;
        }

        private NavigationPage CreatePage(string controllerName)
        {
            object[] param = new object[] { this, base.Logger, m_userEventArgs };
            ICtrlController controller = ControllerFactory.CreateUserController(controllerName, param);
            m_userCtrls.Add(controllerName, controller);

            NavigationPage page = new NavigationPage();
            page.Controls.Add(controller.View.Ctrl);

            this.m_pages.Add(controllerName, page);
            this.m_view.ViewsFrame.Pages.Add(page);

            return page;
        }

        public NavigationPage FindView(string name)
        {
            if (this.m_pages.ContainsKey(name))
                return this.m_pages[name];
            else
                return null;
        }

        public ICtrlView FindChildView(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// close all child views
        /// </summary>
        public void CloseChildren()
        {
            if (0 < this.m_userCtrls.Count)
            {
                foreach (var item in this.m_userCtrls)
                    item.Value.Stop();

                this.m_userCtrls.Clear();
            }

            if (null != this.m_pages)
                this.m_pages.Clear();

            this.m_view.ViewsFrame.Pages.Clear();
        }

        public void ShowChildView(string viewName)
        {
            OnShowChildView(viewName);
        }
        #endregion  Method

        #region  Property   属性
        public IMainRibbonView MainRibbonView
        {
            get { return this.m_view; }
        }
        #endregion  Property

        #region  Filed

        private IMainRibbonView m_view;
        private Dictionary<string, NavigationPage> m_pages;
        private Dictionary<string, ICtrlController> m_userCtrls;
        private UserEventArgs m_userEventArgs;
        private string m_curUserName;
        #endregion  Filed

    }
}
