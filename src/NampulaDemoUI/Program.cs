using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nampula.UI;
using System.Windows.Forms;
using NampulaDemoDI;
using NampulaDemoDI.Factory;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var app = Nampula.UI.Application.GetInstance();

            app.OnStartCreateMenu += app_OnStartCreatMenu;
            app.OnStartConnection += app_OnStartConnection;

            if (app.StartApplication("Nampula", eAppType.SAPForms))
                System.Windows.Forms.Application.Run(app.MainForm());
                    

        }

        private static void app_OnStartConnection(object sender, ApplicationEventArgs e)
        {
            new DBNampula().Start(Nampula.UI.Application.GetInstance().GetParam());

        }

        private static void app_OnStartCreatMenu(object sender, ApplicationEventArgs e)
        {
            var moduloMenu = Nampula.UI.Application.GetInstance().GetMenu(MenuID.cBoUIModulesMenu);
            var menuGroup = new Nampula.UI.MenuItem(moduloMenu, BoMenuType.mt_POPUP,"Nampula Demo");
            var menuNampulaForm = new Nampula.UI.MenuItem(menuGroup, BoMenuType.mt_STRING, "teste");
                menuNampulaForm.OnAfterClick += menuNampulaForm_OnAfterClick;

        }

        private static void menuNampulaForm_OnAfterClick(object sender, MenuEventArgs e)
        {
            new Form1().Show();
        }
    }
}
