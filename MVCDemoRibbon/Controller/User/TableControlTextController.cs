using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDemoRibbon.Broker.Control;
using MVCDemoRibbon.Broker.Control.User;
using MVCDemoRibbon.Broker.View.User;
using MVCDemoRibbon.View;
using Jonas.Common;
using MVCDemoRibbon.Model.Extra;

namespace MVCDemoRibbon.Controller.User
{
    class TableControlTextController : ACtrlController, ITableControlTextController
    {
        #region  Method
        public TableControlTextController(IMdiRibbonController mdiNavigateController, Logger logger, UserEventArgs userEventArgs)
            : base(mdiNavigateController, logger, userEventArgs)
        {
            this.ViewName = "TableControlTextView";
            Initialize();
        }

        /// <summary>
        /// Initialize the view to be shown
        /// </summary>
        private void Initialize()
        {
            try
            {
                this.m_view = base.CreateView() as ITableControlTextView;
                InitChartData();
                this.m_view.Sbt_transform.Click += Sbt_transform_Click;
            }
            catch (Exception ex)
            {
                base.Logger.Error(ex);
            }
            
        }

        private void InitChartData()
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("Record.log", Encoding.Default);
            String line;
            List<DateTime> xs = new List<DateTime>();
            List<int> ys = new List<int>();
            while ((line = sr.ReadLine()) != null)
            {
                string[] lines = line.Split('\x09');
                DateTime xPoint = DateTime.FromFileTime(long.Parse(lines[1]));
                xs.Add(xPoint);
                int yPoint = int.Parse(lines[2]);
                ys.Add(yPoint);
            }
            this.m_view.Chart.Series[0].Points.DataBindXY(xs, ys);
            this.m_view.Chart.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;   //设置是否交错显示,比如数据多的时间分成两行来显示 

            sr.Close();
        }

        void Sbt_transform_Click(object sender, EventArgs e)
        {
            try
            {
                double mseconds = double.Parse(this.m_view.Txt_mseconds.Text.Trim());
                System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
                DateTime dt = startTime.AddMilliseconds(mseconds);
                this.m_view.Txt_date.Text = dt.ToString("yyyy/MM/dd HH:mm:ss:ffff");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("时间转换出错!");
            }
            
        }

        #endregion  Method

        #region  Property   属性
        ITableControlTextView ITableControlTextController.TableControlTextView 
        {
            get { return this.m_view; }
        }
        #endregion  Property

        #region  Filed

        /// <summary>
        /// the view
        /// </summary>
        private ITableControlTextView m_view;
        #endregion  Filed

    }
}
