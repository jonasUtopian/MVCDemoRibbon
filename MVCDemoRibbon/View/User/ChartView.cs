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
    public partial class ChartView : BaseCtrl, IChartView
    {
        public ChartView()
        {
            InitializeComponent();
        }

        DevExpress.XtraCharts.ChartControl IChartView.ChartControl 
        {
            get { return this.chartControl1; } 
        }
        System.Windows.Forms.BindingSource IChartView.RecordDataBindingSource
        {
            get { return this.recordDataBindingSource; } 
        }
    }
}
