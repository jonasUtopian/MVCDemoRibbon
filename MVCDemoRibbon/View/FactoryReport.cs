using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.View
{
    public static class FactoryReport
    {
        #region  Method

        static FactoryReport()
        {
            m_Dic = new Dictionary<string, XtraReport>();
            string key = "ClassReport";
            XtraReport report = CreateReport(key) as XtraReport;
            m_Dic.Add(key, report);
        }

        public static object CreateReport(string name, object[] parameters = null)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string fullName = string.Format("{0}.Views.Report.{1}", assembly.GetName().Name, name);
            Type type = Type.GetType(fullName);

            object obj = null;
            if (null == parameters)
            {
                obj = Activator.CreateInstance(type);
            }
            else
            {
                obj = Activator.CreateInstance(type, parameters);
            }

            return obj;
        }

        public static object GetReport(string name)
        {
            if (m_Dic.ContainsKey(name))
            {
                return m_Dic[name];                
            }
            else
            {
                return null;                         
            }
        }
        #endregion  Method

        #region  Filed

        private static Dictionary<string, XtraReport> m_Dic;

        #endregion  Filed
    }
}
