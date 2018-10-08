using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.View.User;

namespace MVCDemoRibbon.View.User
{
    public partial class FilesOptView : BaseCtrl, IFilesOptView
    {
        #region  Method 方法
        public FilesOptView()
        {
            InitializeComponent();
            this.btn_SelectFromPath.Click += btn_SelectFromPath_Click;
            this.btn_SelectToPath.Click += btn_SelectToPath_Click;
            this.btn_Copy.Click += btn_Copy_Click;
        }

        void btn_Copy_Click(object sender, EventArgs e)
        {
            if (null != OnCopyFile)
            {
                OnCopyFile(sender, e);
            }
        }

        void btn_SelectToPath_Click(object sender, EventArgs e)
        {
            if (null != OnSelectDesPath)
            {
                OnSelectDesPath(sender, e);
            }
        }

        void btn_SelectFromPath_Click(object sender, EventArgs e)
        {
            if (null != OnSelectSourcePath)
            {
                OnSelectSourcePath(sender, e);
            }
        }
        #endregion  Method

        #region  Property   属性
        [Bindable(true)]
        public string SourcePathName
        {
            get { return sourcePathName; }
            set
            {
                sourcePathName = value;
                this.txt_FromPath.Text = value;
            }
        }

        [Bindable(true)]
        public string DesPathName
        {
            get { return desPathName; }
            set
            {
                desPathName = value;
                this.txt_ToPath.Text = value;
            }
        }

        #endregion  Property

        #region  Filed  字段
        public event EventHandler OnSelectSourcePath = null;
        public event EventHandler OnSelectDesPath = null;
        public event EventHandler OnCopyFile = null;
        /// <summary>
        /// The sourcePathName
        /// </summary>
        private string sourcePathName;
        /// <summary>
        /// The desPathName
        /// </summary>
        private string desPathName;
        #endregion  Filed
    }
}
