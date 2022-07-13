using FOSSDesktopApp.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface IAddCompetitionWindow
    {
        string CompetitionName { get; set; }
        string CompetitionLocation { get; set; }
        DateTime CompetitionDate { get; }
        DataGridView DgwTeams { get; }
        DataGridView DgwAllTeams { get; set; }

        void SetDgwTeams(Team[] TeamList);
        void SetDgwAllTeams(TeamList TeamList);


    }
}
