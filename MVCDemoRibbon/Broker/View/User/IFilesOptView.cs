using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View.User
{
    interface IFilesOptView : ICtrlView
    {
        string SourcePathName { get; set; }
        string DesPathName { get; set; }

        event EventHandler OnSelectSourcePath;

        event EventHandler OnSelectDesPath;

        event EventHandler OnCopyFile;
    }
}
