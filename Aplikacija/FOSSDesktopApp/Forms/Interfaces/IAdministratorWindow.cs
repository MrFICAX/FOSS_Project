using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface IAdministratorWindow
    {
        Panel AdministratorPanel { get; }
        string LblUserName { get; set; }
        string LblDateOfLogin { get; set; }
        string LblNameOfSelectedCompetition { get; set; }
        string LblLocationOfSelectedCompetition { get; set; }
        string LblDateOfSelectedCompetition { get; set; }
        ComboBox CbxSelectCompetition { get; }
        string LblWinnerOfSelectedCompetition { get; set; }

        void SetController(IAdministratorController organizerController);
        void SetCbxCompetitionControls(List<Competition> eventList);
        void SetCompetitionLabelControls(Competition selectedCompetition);
    }
}
