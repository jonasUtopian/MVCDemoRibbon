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
    public partial class LineChartSetupView : BaseCtrl, ILineChartSetupView
    {
        public LineChartSetupView()
        {
            InitializeComponent();
        }


        DevExpress.XtraEditors.TextEdit ILineChartSetupView.TextEditMinY
        {
            get { return this.textEditMinY; } 
        }
        DevExpress.XtraEditors.TextEdit ILineChartSetupView.TextEditMaxY
        {
            get { return this.textEditMaxY; }
        }
        DevExpress.XtraEditors.LabelControl ILineChartSetupView.LabelControlSave
        {
            get { return this.labelControlSave; }
        }
    }
}
