using FOSSDesktopApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Forms.Interfaces;
using FOSSDesktopApp.Controllers;

namespace FOSSDesktopApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Trainer t = new Trainer("Tara", "Taric");

            //Team tmp = new Team("FK ALEKSINAC", t);

            //Player capitain = new Player("Petar", "Stojanovic", 0, "Napad", 14);
            //tmp.addPlayer(new Player("Marko", "Nesic", 0, "Napad", 10));
            //tmp.addPlayer(new Player("Luka", "Simic", 0, "Napad", 11));
            //tmp.addPlayer(new Player("Pavle", "Peric", 0, "Napad", 13));

            //tmp.addPlayer(new Player("Uros", "Jankovic", 0, "Sredina", 1));
            //tmp.addPlayer(new Player("Esto", "Prijovic", 0, "Sredina", 2));
            //tmp.addPlayer(new Player("Jovan", "Avramovic", 0, "Klupa", 3));

            //tmp.addPlayer(new Player("Marko", "Stojkovic", 0, "Odbrana", 4));
            //tmp.addPlayer(new Player("Nino", "Marjanovic", 0, "Odbrana", 5));
            //tmp.addPlayer(new Player("Bogdan", "Jovanovic", 0, "Odbrana", 6));

            //tmp.addPlayer(new Player("Dalibor", "Mraovic", 0, "Golman", 7));
            //tmp.addPlayer(new Player("Jovan", "Mitic", 0, "Golman", 8));
            //tmp.addPlayer(capitain);
            //tmp.setCapitain(capitain);
            //if (tmp.SaveToDB().Result) { };

            MainWindowForm mn = new MainWindowForm();

            IMainController mc = new MainController(mn);
            mn.SetController(mc);
 

            LoginWindow loginWindow = new LoginWindow();
            ILoginController loginController = new LoginController(loginWindow, mn);
            loginWindow.SetController(loginController);

            Application.Run(mn);
        }
    }
}
