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
    public partial class ProgramCommView : BaseCtrl, IProgramCommView
    {
        #region  Method 方法
        public ProgramCommView()
        {
            InitializeComponent();
        }
        #endregion  Method

        #region  Property   属性
        DevExpress.XtraEditors.TextEdit IProgramCommView.TxtWrite
        {
            get { return this.txt_Write; }
        }
        DevExpress.XtraEditors.TextEdit IProgramCommView.TxtRead
        {
            get { return this.txt_Read; }
        }
        DevExpress.XtraEditors.SimpleButton IProgramCommView.BtnWriteFileData
        {
            get { return this.btn_WriteFileData; }
        }
        DevExpress.XtraEditors.SimpleButton IProgramCommView.BtnReadFileData
        {
            get { return this.btn_ReadFileData; }
        }
        DevExpress.XtraEditors.SimpleButton IProgramCommView.BtnStartProgram
        {
            get { return this.btn_StartProgram; }
        }
        DevExpress.XtraEditors.SimpleButton IProgramCommView.BtnSelectPath
        {
            get { return this.btn_SelectPath; }
        }
        DevExpress.XtraEditors.TextEdit IProgramCommView.TxtExePath
        {
            get { return this.txt_ExePath; }
        }
        #endregion  Property
        
    }
}
