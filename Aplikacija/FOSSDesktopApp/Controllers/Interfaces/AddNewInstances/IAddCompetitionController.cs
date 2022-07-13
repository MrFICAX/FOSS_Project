using FOSSDesktopApp.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface IAddCompetitionController : IController
    {
        TeamList TeamList { get; set; }
        IOrganizerController ActiveOrganizerController { get; set; }

        void AddNewCompetition(string competitionName, string competitionLocation, DateTime competitionDate);
        void AddTeam(string selectedTeam);
        void RemoveTeam(string selectedTeam);
    }
}
