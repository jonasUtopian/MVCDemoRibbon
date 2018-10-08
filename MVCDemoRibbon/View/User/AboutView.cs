using MVCDemoRibbon.Broker.View.User;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MVCDemoRibbon.View.User
{
    partial class AboutView : BaseCtrl, IAboutView
    {
        public AboutView()
        {
            InitializeComponent();
        }

        LabelControl IAboutView.ProductLabel
        {
            get { return this.labelProductName; }
        }

        LabelControl IAboutView.VersionLabel
        {
            get { return this.labelVersion; }
        }

        LabelControl IAboutView.CopyrightLabel
        {
            get {return this.labelCopyright; }
        }

        LabelControl IAboutView.CompanyNameLabel
        {
            get { return this.labelCompanyName; }
        }

        SimpleButton IAboutView.OkButton
        {
            get { return this.okButton; }
        }


        LabelControl IAboutView.AssemblyDescriptionLabel
        {
            get { return this.textBoxDescription ; }
        }

      
    }
}
