using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface ITeamController : IController
    {
        void SetPlayers(string selectedTeam);
    }
}
