using FOSSDesktopApp.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface IOrganizerController : IController
    {
        void OpenCompetitionWindow(String nameOfCompetition);
        void OpenAddAdministratorWindow();
        void OpenLoginForm();
        void OpenAddNewCompetitionWindow();
        void LoadActiveCompetition(string nameOfCompetition);
        void ChangeCompetitionWindow();
        void OpenAddNewClub();
        void OpenAddNewReferee();
        void AddNewCompetition(Competition newCompetition);
        void OpenControlDraw(string selectedCompetition);
    }
}
