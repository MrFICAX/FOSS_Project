using FOSSDesktopApp.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface ICompetitionController : IController
    {
        Competition SelectedCompetition { get; set; }

        void SetPlayers(string selectedTeam);
    }
}
