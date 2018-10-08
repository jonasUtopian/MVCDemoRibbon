using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using MVCDemoRibbon.Broker.Report;

namespace MVCDemoRibbon.View.Report
{
    public partial class ClassReport : DevExpress.XtraReports.UI.XtraReport, IControlReport
    {
        public ClassReport()
        {
            InitializeComponent();
        }

        public void SetBindingDataSource(object dataSource)
        {
            this.objectDataSource1.DataSource = dataSource;
            this.CreateDocument();
        }
    }
}
