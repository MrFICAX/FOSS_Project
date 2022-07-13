using FOSSDesktopApp.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface ICompetitionWindow
    {
        DataGridView DgwTeams { get;}
        DataGridView DgwMatches { get;}
        DataGridView DgwPlayers { get; }

        void SetController(ICompetitionController competitionController);
    }
}
