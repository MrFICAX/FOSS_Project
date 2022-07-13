using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms.Interfaces;

namespace FOSSDesktopApp.Controllers
{
    class CompetitionController :ICompetitionController
    {
        private readonly ICompetitionWindow competitionWindow;
        private Competition selectedCompetition;

        public Competition SelectedCompetition 
        {
            get { return this.selectedCompetition; }
            set
            {
                this.selectedCompetition = value;
                SetDgwTeams();
                SetDgwMatchesNew();
            } 
        }

        private void SetDgwTeams()
        {
            string[] row;
            //  this.competitionWindow.DgwTeams.DataSource = this.SelectedCompetition.TeamList;

            this.competitionWindow.DgwTeams.ColumnCount = 4;
            if (this.competitionWindow.DgwTeams.ColumnCount == 0)
                return;
            this.competitionWindow.DgwTeams.Columns[0].Name = "IME KLUBA";
            this.competitionWindow.DgwTeams.Columns[1].Name = "TRENER";
            this.competitionWindow.DgwTeams.Columns[2].Name = "BROJ IGRAČA";
            this.competitionWindow.DgwTeams.Columns[3].Name = "KAPITEN";


            int index;
            for(index=0; index < this.selectedCompetition.TeamList.Length;index++)
            {
                Team tmpTeam = this.selectedCompetition.TeamList[index];
                Player capitain = tmpTeam.Capitain;
                //OVO OBAVEZNO ISPRAVITI!@!!!


                if (capitain == null)
                    row = new string[] { tmpTeam.ClubName, tmpTeam.Trainer.PersonName + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), "Ne postoji kapiten"};
                else if(tmpTeam.Trainer == null)
                    row = new string[] { tmpTeam.ClubName, "Trener nepoznat", tmpTeam.TeamSize.ToString(), "Ne postoji kapiten" };
                else
                    row = new string[] { tmpTeam.ClubName, tmpTeam.Trainer.PersonName + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), tmpTeam.Capitain.PersonName + " " + tmpTeam.Capitain.Surname };

                this.competitionWindow.DgwTeams.Rows.Add(row);
            }
        }

        private string GetLevelOfCompetition(string level)
        {
            int result2 = level.Split('.').Length - 1;
            switch (result2)
            {
                case 0:
                    return "FINALE";
                case 1:
                    return "POLUFINALE";
                case 2:
                    return "ČETVRTFINALE";
                case 3:
                    return "OSMINA FINALA";
                case 4:
                    return "ŠESNAESTINA FINALA";
                default:
                    return "1. kolo kup sistema";
            }
        }

        private void SetDgwMatchesNew()
        {
            string LevelOfCompetition;
            string[] row;
            //  this.competitionWindow.DgwTeams.DataSource = this.SelectedCompetition.TeamList;
            this.competitionWindow.DgwMatches.Columns.Clear();
            this.competitionWindow.DgwMatches.Rows.Clear();


            competitionWindow.DgwMatches.ColumnCount = 6;
            if (competitionWindow.DgwMatches.ColumnCount == 0)
                return;
            competitionWindow.DgwMatches.Columns[0].Name = "DOMAĆI";
            //this.competitionWindow.DgwTeams.Columns[1].Name = "REZULTAT";
            competitionWindow.DgwMatches.Columns[1].Name = "GOSTI";
            competitionWindow.DgwMatches.Columns[2].Name = "POBEDNIK";
            competitionWindow.DgwMatches.Columns[3].Name = "SUDIJA";
            competitionWindow.DgwMatches.Columns[4].Name = "FAZA";
            competitionWindow.DgwMatches.Columns[5].Name = "DATUM";


            int index;
            for (index = 0; index < this.selectedCompetition.MatchList.Length; index++)
            {
                Match tmpMatch = this.selectedCompetition.MatchList[index];
                Team tmpTeam1 = tmpMatch.Teams[0];
                Team tmpTeam2 = tmpMatch.Teams[1];
                Referee tmpReferee = tmpMatch.Referee;
                LevelOfCompetition = tmpMatch.SpecificNumber;
                if (tmpMatch.Level == "draw")
                    LevelOfCompetition = GetLevelOfCompetition(tmpMatch.SpecificNumber);

                if (tmpMatch == null)
                    break;
                else
                {
                    if(tmpMatch.Winner == null)
                    {
                        if (tmpReferee != null)
                            row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName,"Pobednik nepoznat", tmpReferee.PersonName + " " + tmpReferee.Surname, LevelOfCompetition, tmpMatch.Date.ToString() };
                        else
                        {
                            if (tmpTeam1 != null && tmpTeam2 != null)
                                row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName, "Pobednik nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                            else
                                if (tmpTeam1 != null && tmpTeam2 == null)
                                row = new string[] { tmpTeam1.ClubName, "Drugi klub nepoznat", "Pobednik nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                            else
                                    if (tmpTeam1 == null && tmpTeam2 != null)
                                row = new string[] { "Prvi klub nepoznat", tmpTeam2.ClubName, "Pobednik nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                            else
                                row = new string[] { "Prvi klub nepoznat", "Drugi klub nepoznat", "Pobednik nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };

                        }
                    }
                    else
                    {
                        if (tmpReferee != null)
                            row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName, tmpMatch.Winner.ClubName, tmpReferee.PersonName + " " + tmpReferee.Surname, LevelOfCompetition, tmpMatch.Date.ToString() };
                        else
                        {
                            if (tmpTeam1 != null && tmpTeam2 != null)
                                row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName, tmpMatch.Winner.ClubName, "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                            else
                                if (tmpTeam1 != null && tmpTeam2 == null)
                                row = new string[] { tmpTeam1.ClubName, "Drugi klub nepoznat", "Pobednik nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                            else
                                    if (tmpTeam1 == null && tmpTeam2 != null)
                                row = new string[] { "Prvi klub nepoznat", tmpTeam2.ClubName, "Pobednik nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                            else
                                row = new string[] { "Prvi klub nepoznat", "Drugi klub nepoznat", "Pobednik nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };

                        }
                    }
                }
                this.competitionWindow.DgwMatches.Rows.Add(row);
            }
        }

        private void SetDgwPlayers(Player[] players)
        {
            string capitain = "NE";
            this.competitionWindow.DgwPlayers.Columns.Clear();
            this.competitionWindow.DgwPlayers.Rows.Clear();

            //   this.competitionWindow.DgwPlayers.DataSource = players;
            this.competitionWindow.DgwPlayers.ColumnCount = 5;
            if (this.competitionWindow.DgwPlayers.ColumnCount == 0)
                return;
            this.competitionWindow.DgwPlayers.Columns[0].Name = "IME ";
            this.competitionWindow.DgwPlayers.Columns[1].Name = "PREZIME";
            //this.competitionWindow.DgwPlayers.Columns[2].Name = "BROJ GOLOVA";
            this.competitionWindow.DgwPlayers.Columns[2].Name = "KAPITEN";
            //this.competitionWindow.DgwPlayers.Columns[4].Name = "KARTONI";
            this.competitionWindow.DgwPlayers.Columns[3].Name = "BROJ";
            this.competitionWindow.DgwPlayers.Columns[4].Name = "POZICIJA";

            int index;
            for (index = 0; index < players.Length; index++)
            {
                capitain = "NE";
                Player tmpPlayer = players[index];
                if (tmpPlayer.Captain)
                    capitain = "DA";
                if(tmpPlayer != null)
                {
                    string[] row = new string[] { tmpPlayer.PersonName, tmpPlayer.Surname, capitain, tmpPlayer.Num.ToString(), tmpPlayer.Position};
                    this.competitionWindow.DgwPlayers.Rows.Add(row);
                }
            }
        }

        public void SetPlayers(string selectedTeam)
        {
            Team tmpTeam = selectedCompetition.FindTeam(selectedTeam);
            SetDgwPlayers(tmpTeam.Players);
        }

        public CompetitionController(ICompetitionWindow competitionWindow)
        {
            this.competitionWindow = competitionWindow;
        }

        public CompetitionController(ICompetitionWindow competitionWindow, Competition competition)
        {
            this.competitionWindow = competitionWindow;
            SelectedCompetition = competition;
        }
    }
}
