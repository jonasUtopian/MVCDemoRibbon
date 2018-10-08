using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.View
{
    public static class FactoryContrl
    {
        /// <summary>
        /// Creates the view.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Object.</returns>
        public static object CreateCtrl(string name, object[] parameters = null)
        {
            object obj = null;
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string fullName = string.Format("{0}.View.User.{1}", assembly.GetName().Name, name);
                Type type = Type.GetType(fullName);

                if (null == parameters)
                    obj = Activator.CreateInstance(type);
                else
                    obj = Activator.CreateInstance(type, parameters);
            }
            catch (Exception)
            {
                throw;
            }
            
            return obj;
        }
    }
}
