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
    interface IAddTeamWindow
    {
        string ClubName { get; set; }
        string PlayerName { get; set; }
        string PlayerSurname { get; set; }
        string TrainerName { get; set; }
        string TrainerSurname { get; set; }
        int PlayerNumber { get; set; }
        string PlayerPosition { get; set; }
        DataGridView DgwPlayers { get; set; }
        DataGridView DgwTeams { get; set; }
        CheckBox CbxCapitain { get; set; }

        DialogResult DialogResult { get; set; }

        bool ValidateInputClub();
        bool ValidateInputPlayer();
        void SetController(IAddTeamController addTeamController);
        void CloseForm();
        void LoadPlayerControls(Player player);
        void LoadTeamControls(Team team);
        void ClearPlayerControls();
        void ClearTeamControls();

        void SetDgwTeams(TeamList TeamList);
        void SetDgwPlayers(Player[] players);
        void EnableAddTeam();
        void UnableUpdateTeam();
    }
}
