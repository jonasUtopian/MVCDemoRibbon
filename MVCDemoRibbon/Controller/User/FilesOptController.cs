using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.Control;
using MVCDemoRibbon.Broker.Control.User;
using MVCDemoRibbon.Broker.View.User;
using MVCDemoRibbon.Broker.Model;
using Jonas.Common;
using MVCDemoRibbon.Model.View;
using MVCDemoRibbon.Model.Extra;

namespace MVCDemoRibbon.Controller.User
{
    class FilesOptController : ACtrlController, IFilesOptController
    {
        #region  Method
        public FilesOptController(IMdiRibbonController mdiNavigateController, Logger logger, UserEventArgs userEventArgs)
            : base(mdiNavigateController, logger, userEventArgs)
        {
            this.ViewName = "FilesOptView";
            Initialize();
        }

        void Initialize()
        {
            this.m_view = base.CreateView() as IFilesOptView;
            this.m_model = new FileOptModel();
            this.InitializeModel();
        }

        /// <summary>
        /// Initialize the view to be shown
        /// </summary>
        private void InitializeModel()
        {
            System.Windows.Forms.Cursor currentCursor = System.Windows.Forms.Cursor.Current;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            try
            {
                this.m_model.SourcePathName = "杭州...";
                this.m_model.DesPathName = "玉山...";

                this.m_view.Ctrl.DataBindings.Add(new Binding("SourcePathName", this.m_model, "SourcePathName", false, DataSourceUpdateMode.OnPropertyChanged));
                this.m_view.Ctrl.DataBindings.Add(new Binding("DesPathName", this.m_model, "DesPathName", false, DataSourceUpdateMode.OnPropertyChanged));

                this.m_view.OnSelectSourcePath += BtnSelectFromPath_Click;
                this.m_view.OnSelectDesPath += BtnSelectToPath_Click;
                this.m_view.OnCopyFile += BtnCopy_Click;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                System.Windows.Forms.Cursor.Current = currentCursor;
            }

        }

        void BtnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(this.m_model.SourcePathName)
                 && Directory.Exists(this.m_model.DesPathName))
                {
                    string desName = string.Format("{0}\\{1}", this.m_model.DesPathName, this._fileName);
                    System.IO.File.Copy(this.m_model.SourcePathName, desName, false);
                }
            }
            catch (Exception ex)
            {
                //Jonas.Common.Logger.Error(ex.Message);
            }
        }

        void BtnSelectToPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (DialogResult.OK == dialog.ShowDialog())
                this.m_model.DesPathName = dialog.SelectedPath;                
        }

        void BtnSelectFromPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.RestoreDirectory = true;
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (DialogResult.OK == dialog.ShowDialog())
            {
                this.m_model.SourcePathName = dialog.FileName;
                this._fileName = dialog.SafeFileName;
            }
        }

        #endregion  Method

        #region  Property   属性
        public IFilesOptView FilesOptView
        {
            get { return this.m_view; }
        }

        #endregion  Property


        #region  Filed

        /// <summary>
        /// the view
        /// </summary>
        private IFilesOptView m_view;
        private IFileOptModel m_model;
        private string _fileName = string.Empty;
        #endregion  Filed
    }
}
