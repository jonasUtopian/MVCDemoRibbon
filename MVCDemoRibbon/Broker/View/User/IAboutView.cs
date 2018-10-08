using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View.User
{
    public interface IAboutView : ICtrlView
    {
        DevExpress.XtraEditors.LabelControl ProductLabel{ get; }
        DevExpress.XtraEditors.LabelControl VersionLabel { get; }
        DevExpress.XtraEditors.LabelControl CopyrightLabel { get; }
        DevExpress.XtraEditors.LabelControl CompanyNameLabel { get; }
        DevExpress.XtraEditors.SimpleButton OkButton { get; }
        DevExpress.XtraEditors.LabelControl AssemblyDescriptionLabel { get; }

    }
}
