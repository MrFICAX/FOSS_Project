using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface IAdministratorController : IController
    {
        void LoadActiveCompetition(string selectedCompetition);
        void OpenCompetitionWindow(string selectedCompetition);
        void OpenLoginForm();
        void OpenManageMatchesWindow(string selectedCompetition);
        void OpenTeamsWindow(string selectedCompetition);
    }
}
