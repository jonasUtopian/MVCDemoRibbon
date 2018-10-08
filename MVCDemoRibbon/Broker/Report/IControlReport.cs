using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Report
{
    public interface IControlReport
    {
        /// <summary>
        /// Sets the binding data source.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        void SetBindingDataSource(object dataSource);
    }
}
