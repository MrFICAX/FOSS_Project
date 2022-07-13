using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms;
using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers
{
    class TeamController : ITeamController 
    {
        private readonly TeamWindow teamWindow;
        private Competition selectedCompetition;

        public Competition SelectedCompetition
        {
            get { return this.selectedCompetition; }
            set
            {
                this.selectedCompetition = value;
                SetDgwTeams();
                
            }
        }

        private void SetDgwTeams()
        {
            string[] row;
            //  this.competitionWindow.DgwTeams.DataSource = this.SelectedCompetition.TeamList;

            this.teamWindow.DgwTeams.ColumnCount = 4;
            if (this.teamWindow.DgwTeams.ColumnCount == 0)
                return;
            this.teamWindow.DgwTeams.Columns[0].Name = "IME KLUBA";
            this.teamWindow.DgwTeams.Columns[1].Name = "TRENER";
            this.teamWindow.DgwTeams.Columns[2].Name = "BROJ IGRAČA";
            this.teamWindow.DgwTeams.Columns[3].Name = "KAPITEN";


            int index;
            for (index = 0; index < this.selectedCompetition.TeamList.Length; index++)
            {
                Team tmpTeam = this.selectedCompetition.TeamList[index];
                Player capitain = tmpTeam.Capitain;
                //OVO OBAVEZNO ISPRAVITI!@!!!


                if (capitain == null)
                    row = new string[] { tmpTeam.ClubName, tmpTeam.Trainer.PersonName + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), "Ne postoji kapiten" };
                else if (tmpTeam.Trainer == null)
                    row = new string[] { tmpTeam.ClubName, "Trener nepoznat", tmpTeam.TeamSize.ToString(), "Ne postoji kapiten" };
                else
                    row = new string[] { tmpTeam.ClubName, tmpTeam.Trainer.PersonName + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), tmpTeam.Capitain.PersonName + " " + tmpTeam.Capitain.Surname };

                this.teamWindow.DgwTeams.Rows.Add(row);
            }
        }

        public void SetPlayers(string selectedTeam)
        {
            Team tmpTeam = selectedCompetition.FindTeam(selectedTeam);
            SetDgwPlayers(tmpTeam.Players);
        }

        private void SetDgwPlayers(Player[] players)
        {
            string capitain = "NE";
            this.teamWindow.DgwPlayers.Columns.Clear();
            this.teamWindow.DgwPlayers.Rows.Clear();

            //   this.competitionWindow.DgwPlayers.DataSource = players;
            this.teamWindow.DgwPlayers.ColumnCount = 5;
            if (this.teamWindow.DgwPlayers.ColumnCount == 0)
                return;
            this.teamWindow.DgwPlayers.Columns[0].Name = "IME ";
            this.teamWindow.DgwPlayers.Columns[1].Name = "PREZIME";
            //this.teamWindow.DgwPlayers.Columns[2].Name = "BROJ GOLOVA";
            this.teamWindow.DgwPlayers.Columns[2].Name = "KAPITEN";
            //this.teamWindow.DgwPlayers.Columns[4].Name = "KARTONI";
            this.teamWindow.DgwPlayers.Columns[3].Name = "BROJ";
            this.teamWindow.DgwPlayers.Columns[4].Name = "POZICIJA";

            int index;
            for (index = 0; index < players.Length; index++)
            {
                capitain = "NE";
                Player tmpPlayer = players[index];
                if (tmpPlayer.Captain)
                    capitain = "DA";
                if (tmpPlayer != null)
                {
                    string[] row = new string[] { tmpPlayer.PersonName, tmpPlayer.Surname, capitain, tmpPlayer.Num.ToString(), tmpPlayer.Position };
                    this.teamWindow.DgwPlayers.Rows.Add(row);
                }
            }
        }

        public TeamController(TeamWindow teamWindow, Competition activeCompetition)
        {
            this.teamWindow = teamWindow;
            this.SelectedCompetition = activeCompetition;
        }
    }
}
