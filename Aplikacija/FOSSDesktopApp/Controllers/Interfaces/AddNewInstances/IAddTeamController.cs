using FOSSDesktopApp.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface IAddTeamController : IController
    {
        Team OldTeam { get; set; }
        Team NewTeam { get; set; }
        TeamList TeamList { get; set; }

        void AddNewPlayer();
        void DeletePlayer();
        void UpdatePlayer();
        void AddTeam();
        void UpdateTeam();
        void DeleteTeam(string selectedTeam);
        void LoadPlayerInControls(string selectedPlayer);
        void LoadTeamInControls(string selectedTeam);
    }
}
