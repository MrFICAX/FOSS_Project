using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface ILoginController : IController
    {
        void LoginButtonClicked();
        void EnterKeyButtonClicked();
        void AddNewOrganizerClicked();
    }
}
