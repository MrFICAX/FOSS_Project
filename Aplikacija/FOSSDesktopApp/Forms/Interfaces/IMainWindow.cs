using FOSSDesktopApp.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface IMainWindow
    {
        Panel MainPanel { get; set; }

        void SetController(IMainController mainController);
        void OpenChildForm(Form Window);
        void setActiveWindow(Form window);
        void setActiveController(IController controller);
        void openLoginForm();
    }
}
