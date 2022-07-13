using FOSSDesktopApp.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface IOrganizerWindow
    {
        Panel OrganiserPanel { get; set; }
        string LblUserName { get; set; }
        string LblDateOfLogin { get; set; }
        string LblNameOfSelectedCompetition { get; set; }
        string LblLocationOfSelectedCompetition { get; set; }
        string LblDateOfSelectedCompetition { get; set; }
        ComboBox CbxSelectCompetition { get; }
        string LblWinnerOfSelectedCompetition { get; set; }


        void SetController(IOrganizerController organizerController);
    }
}
