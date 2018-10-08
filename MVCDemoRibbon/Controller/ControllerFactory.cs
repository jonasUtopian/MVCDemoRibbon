using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MVCDemoRibbon.Broker.Control;
using MVCDemoRibbon.Broker.Control.User;

namespace MVCDemoRibbon.Controller
{
    public static class ControllerFactory
    {
        #region  Method
        // 采用System.Activator 类的CreateInstance方法。
        // 但是在动态创建时，可能会动态使用到外部应用的DLL中类的实例，则此时需要进行反编译操作，使用Reflection命名控件下的Assembly类。
        // 先使用Assembly类载入DLL，再根据类的全路径获取类
        // Assembly tempAssembly = Assembly.LoadFrom(vDllName);
        // Type typeofControl = tempAssembly.GetType(vFullClassName);
        // object result = Activator.CreateInstance(typeofControl, objParam);

        /// <summary>
        /// 主界面控制器
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static object CreateController(string name, object[] parameters = null)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string fullName = string.Format("{0}.Controllers.{1}", assembly.GetName().Name, name);
                Type type = Type.GetType(fullName);

                object obj = null;
                if (null == parameters)
                    obj = Activator.CreateInstance(type);
                else
                    obj = Activator.CreateInstance(type, parameters);

                return obj;
            }
            catch (Exception ex)
            {   
                throw ex;
            } 
        }

        /// <summary>
        /// 自定义控件控制器
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ICtrlController CreateUserController(string name, object[] parameters = null)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string fullName = string.Format("{0}.Controller.User.{1}", assembly.GetName().Name, name);
                Type type = Type.GetType(fullName);

                object obj = null;
                if (null == parameters)
                    obj = Activator.CreateInstance(type);
                else
                    obj = Activator.CreateInstance(type, parameters);

                return obj as ICtrlController;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion  Method
    }
}
