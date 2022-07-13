using FOSSDesktopApp.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms.Interfaces
{
   public interface IAddAdministratorWindow
    {
        string AdministratorName { get; set; }
        string AdministratorSurname{ get; set; }
        string AdministratorEnterkey { get; set; }
        DataGridView DgwAdminstrators { get; set; }
        DataGridView DgwAdmininstratorsCompetitionList { get; set; }

        void SetController(IAddAdministratorController loginController);
        void ClearAdministratorControls();
    }
}
