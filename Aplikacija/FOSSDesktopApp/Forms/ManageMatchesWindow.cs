using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms
{
    public partial class ManageMatchesWindow : Form, IManageMatchesWindow
    {
        #region Attributes

        public IManageMatchesController manageMatchesController;

        #endregion

        #region Constructors

        public ManageMatchesWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public IManageMatchesController ManageMatchesController
        {
            get { return this.manageMatchesController; }
            set { this.manageMatchesController = value; }
        }

        public DataGridView DgwUnplayedMatches 
        {
            get => this.dgwUnplayedMatches;
            set => this.dgwUnplayedMatches = value; 
        }

        public DataGridView DgwPlayedMatches 
        { 
            get => this.dgwPlayedMatches; 
            set => this.dgwPlayedMatches = value; 
        }

        #endregion

        #region SetController

        public void SetController(IManageMatchesController manageMatchesController)
        {
            ManageMatchesController = manageMatchesController;
        }

        #endregion

        #region SetControls

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

        public void SetDgwUnPlayedMatches(Engine.Match[] matchList)
        {
            string LevelOfCompetition;

            string[] row = new string[] { };
            //  this.competitionWindow.DgwTeams.DataSource = this.SelectedCompetition.TeamList;
            this.DgwUnplayedMatches.Columns.Clear();
            this.DgwUnplayedMatches.Rows.Clear();


            DgwUnplayedMatches.ColumnCount = 5;
            if (DgwUnplayedMatches.ColumnCount == 0)
                return;
            DgwUnplayedMatches.Columns[0].Name = "DOMAĆI";
            //this.competitionWindow.DgwTeams.Columns[1].Name = "REZULTAT";
            DgwUnplayedMatches.Columns[1].Name = "GOSTI";
            DgwUnplayedMatches.Columns[2].Name = "SUDIJA";
            DgwUnplayedMatches.Columns[3].Name = "FAZA";
            DgwUnplayedMatches.Columns[4].Name = "DATUM";


            int index;
            for (index = 0; index < matchList.Length; index++)
            {
                Match tmpMatch = matchList[index];
                Team tmpTeam1 = tmpMatch.Teams[0];
                Team tmpTeam2 = tmpMatch.Teams[1];
                Referee tmpReferee = tmpMatch.Referee;
                LevelOfCompetition = tmpMatch.SpecificNumber;
                if(tmpMatch.Level == "draw")
                    LevelOfCompetition = GetLevelOfCompetition(tmpMatch.SpecificNumber);
                if (tmpMatch == null)
                    break;
                else
                {
                    if(tmpMatch.Winner == null)
                    {
                        if (tmpReferee != null)
                            row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName, tmpReferee.PersonName + " " + tmpReferee.Surname, LevelOfCompetition, tmpMatch.Date.ToString() };
                        else
                        {
                            if (tmpTeam1 != null && tmpTeam2 != null)
                                row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName, "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                            else
                                if(tmpTeam1 != null && tmpTeam2 == null)
                                    row = new string[] { tmpTeam1.ClubName, "Drugi klub nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                                else
                                    if (tmpTeam1 == null && tmpTeam2 != null)
                                        row = new string[] { "Prvi klub nepoznat", tmpTeam2.ClubName, "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                                    else
                                        row = new string[] { "Prvi klub nepoznat", "Drugi klub nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };

                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                DgwUnplayedMatches.Rows.Add(row);
            }
        }

        public void SetDgwPlayedMatches(Engine.Match[] matchList)
        {
            string LevelOfCompetition;
            string[] row;
            //  this.competitionWindow.DgwTeams.DataSource = this.SelectedCompetition.TeamList;
            this.dgwPlayedMatches.Columns.Clear();
            this.dgwPlayedMatches.Rows.Clear();


            dgwPlayedMatches.ColumnCount = 6;
            if (dgwPlayedMatches.ColumnCount == 0)
                return;
            dgwPlayedMatches.Columns[0].Name = "DOMAĆI";
            //this.competitionWindow.DgwTeams.Columns[1].Name = "REZULTAT";
            dgwPlayedMatches.Columns[1].Name = "GOSTI";
            dgwPlayedMatches.Columns[2].Name = "POBEDNIK";
            dgwPlayedMatches.Columns[3].Name = "SUDIJA";
            dgwPlayedMatches.Columns[4].Name = "FAZA";
            dgwPlayedMatches.Columns[5].Name = "DATUM";


            int index;
            for (index = 0; index < matchList.Length; index++)
            {
                Match tmpMatch = matchList[index];
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
                    if (tmpMatch.Winner != null)
                    {
                        if (tmpReferee != null)
                        {
                            if (tmpTeam1 != null && tmpTeam2 != null)
                                if (tmpMatch.Scores[0] != tmpMatch.Scores[1])
                                {
                                    row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName, tmpMatch.Winner.ClubName, tmpReferee.PersonName + " " + tmpReferee.Surname, LevelOfCompetition, tmpMatch.Date.ToString() };
                                }
                                else
                                {
                                    row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName, "NERESENO", tmpReferee.PersonName + " " + tmpReferee.Surname, LevelOfCompetition, tmpMatch.Date.ToString() };
                                }
                            else
                                row = new string[] { "Prvi klub nepoznat", "Drugi klub nepoznat", "Pobednik nepoznat", tmpReferee.PersonName + " " + tmpReferee.Surname, LevelOfCompetition, tmpMatch.Date.ToString() };                        
                        }                                              
                        else
                        {
                            if (tmpTeam1 != null && tmpTeam2 != null)
                                if (tmpMatch.Scores[0] != tmpMatch.Scores[1])
                                { 
                                    row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName, tmpMatch.Winner.ClubName, "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                                }
                                else
                                {
                                     row = new string[] { tmpTeam1.ClubName, tmpTeam2.ClubName, "NERESENO", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                                }
                           else
                                    row = new string[] { "Prvi klub nepoznat", "Drugi klub nepoznat", "Pobednik nepoznat", "Sudija: nepoznat", LevelOfCompetition, tmpMatch.Date.ToString() };
                            }
                    }
                    else
                    {
                        continue;
                    }
                }
                dgwPlayedMatches.Rows.Add(row);
            }
        }

        #endregion

        #region EventHandlers

        private void dgwUnplayedMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedTeam1 = dgwUnplayedMatches.SelectedRows[0].Cells["DOMAĆI"].Value.ToString();
            string selectedTeam2 = dgwUnplayedMatches.SelectedRows[0].Cells["GOSTI"].Value.ToString();

            this.ManageMatchesController.OpenMatchWindow(selectedTeam1, selectedTeam2);

               
        }

        #endregion
    }
}
