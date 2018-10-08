using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Jonas.Common;
using MVCDemoRibbon.Broker.Control;
using MVCDemoRibbon.Controllers;

namespace MVCDemoRibbon
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger logger = new Logger();
            string mutexName = Application.ProductName;
            try
            {
                if (Jonas.Common.SingleProgram.ExistProgram(mutexName))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    BonusSkins.Register();
                    SkinManager.EnableFormSkins();

                    logger.Debug("MVCDemoRibbon");

                    ILoginController controller = new LoginController(logger);
                    if (null != controller.MainController)
                        Application.Run(controller.MainController.View.ViewForm);
                    else
                        Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            
        }
    }
}
