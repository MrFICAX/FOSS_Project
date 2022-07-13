using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    interface IMainController : IController
    {
        Form ActiveForm { get; set; }
        IController ActiveController { get; set; }
        void OpenChildForm(Form childForm);
        void openLoginForm();
    }
}
