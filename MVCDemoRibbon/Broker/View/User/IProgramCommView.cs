using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View.User
{
    interface IProgramCommView : ICtrlView
    {
        DevExpress.XtraEditors.TextEdit TxtWrite { get; }
        DevExpress.XtraEditors.TextEdit TxtRead { get; }
        DevExpress.XtraEditors.SimpleButton BtnWriteFileData { get; }
        DevExpress.XtraEditors.SimpleButton BtnReadFileData { get; }
        DevExpress.XtraEditors.SimpleButton BtnStartProgram { get; }
        DevExpress.XtraEditors.SimpleButton BtnSelectPath { get; }
        DevExpress.XtraEditors.TextEdit TxtExePath { get; }
    }
}
