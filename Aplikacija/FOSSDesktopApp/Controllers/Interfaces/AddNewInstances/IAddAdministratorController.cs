using FOSSDesktopApp.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface IAddAdministratorController
    {
        Organizer ActiveOrganizer { get; set; }

        void AddNewAdministrator();
        void DeleteAdministrator(string selectedAdministrator);
        void SelectedAdministratorClicked(string selectedAdministrator);
        void AddCompetitionToAdministrator(string selectedAdministrator, string selectedCompetition);
        void DeleteCompetitionOfAdministrator(string selectedAdministrator, string selectedCompetition);
    }
}
