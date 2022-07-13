using FOSSDesktopApp.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface IRefereeWindow
    {
        
        string RefereeName { get; set; }
        string RefereeSurname { get; set; }
        DataGridView DgwRefereeList { get; set; }


        bool ValidateRefereeInput(string RefereeName, string RefereeSurname, int RefereeQuality);
        void SetDgwRefereeList(List<Engine.Referee> refereeList);
        void ClearRefereInput();
        void SetController(IRefereeController refereeController);
    }
}
