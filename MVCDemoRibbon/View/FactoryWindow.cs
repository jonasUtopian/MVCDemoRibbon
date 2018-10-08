using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.View
{
    public static class FactoryWindow
    {
        /// <summary>
        /// Creates the view.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Object.</returns>
        public static object CreateView(string name, object[] parameters = null)
        {
            object obj = null;
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string fullName = string.Format("{0}.View.{1}", assembly.GetName().Name, name);
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

        public static object CreateChildView(string name, object[] parameters = null)
        {
            object obj = null;
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string fullName = string.Format("{0}.View.Child.{1}", assembly.GetName().Name, name);
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
