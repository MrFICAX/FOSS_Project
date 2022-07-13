using FOSSDesktopApp.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface IRefereeController : IController
    {

        void AddNewReferee(string refereeName, string refereeSurname, int refereeQuality);
    }
}
