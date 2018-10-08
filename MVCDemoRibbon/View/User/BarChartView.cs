using MVCDemoRibbon.Broker.View.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCDemoRibbon.View.User
{
    public partial class BarChartView : BaseCtrl, IBarChartView
    {
        public BarChartView()
        {
            InitializeComponent();
        }

        DevExpress.XtraCharts.ChartControl IBarChartView.ChartControl
        {
            get { return this.chartControl1; }
        }
        System.Windows.Forms.BindingSource IBarChartView.RecordDataBindingSource
        {
            get { return this.bindingSource1; }
        }
    }
}
