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
    public partial class TableControlTextView : BaseCtrl, ITableControlTextView
    {
        #region  Method 方法
        public TableControlTextView()
        {
            InitializeComponent();
        }

        #endregion  Method

        #region  Property   属性
        System.Windows.Forms.DataVisualization.Charting.Chart ITableControlTextView.Chart 
        {
            get { return this.chart1; } 
        }
        DevExpress.XtraEditors.TextEdit ITableControlTextView.Txt_mseconds
        {
            get { return this.txt_mseconds; }
        }
        DevExpress.XtraEditors.TextEdit ITableControlTextView.Txt_date
        {
            get { return this.txt_date; }
        }
        DevExpress.XtraEditors.SimpleButton ITableControlTextView.Sbt_transform
        {
            get { return this.sbt_transform; }
        }
        #endregion  Property

        private void sbAdd_Click(object sender, EventArgs e)
        {

        }

        private void sbZoomUp_Click(object sender, EventArgs e)
        {

        }

        private void btZoomDown_Click(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {
           
        }
    }
}
