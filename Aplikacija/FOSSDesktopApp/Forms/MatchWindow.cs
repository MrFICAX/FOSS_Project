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
    public partial class MatchWindow : Form, IMatchWindow
    {
        #region Attributes

        private IMatchController matchController;
        private RefereeList refereeList;
        private Match selectedMatch;
        private Competition activeCompetition;

        #endregion

        #region Properties

        public Match SelectedMatch
        {
            get { return this.selectedMatch; }
            set 
            { 
                this.selectedMatch = value;
                //this.selectedMatch.isOngoing = true;
                this.SetTeamControls();
                this.SetMatchControls();
                this.SetResultControls();
            }
        }

        public RefereeList RefereeList
        {
            get { return this.refereeList; }
            set { this.refereeList = value; }
        }

        public ComboBox CbxRefereeList
        {
            get => this.cbxRefereeList;
            set => this.cbxRefereeList = value;
        }

        public DataGridView DgwPlayerListTeam1
        {
            get { return this.dgwPlayerListTeam1; }
        }

        public DataGridView DgwPlayerListTeam2
        {
            get { return this.dgwPlayerListTeam2; }
        }

        public Competition ActiveCompetition { get => activeCompetition; set => activeCompetition = value; }

        #endregion

        #region Constructors

        public MatchWindow(Match selectedMatch, Competition activeCompetition)
        {
            InitializeComponent();
            SelectedMatch = selectedMatch;
            if (SelectedMatch.isOngoing == true)
                SetMatchStarted();
            ActiveCompetition = activeCompetition;
            RefereeListSetup();
           
        }


        #endregion

        #region SetController

        public void SetController(IMatchController matchController)
        {
            this.matchController = matchController;
        }

        #endregion

        #region SetTeamControls

        public void SetTeamControls()
        {
            this.lblTeam1Name.Text = this.selectedMatch.Teams[0].ClubName;
            this.lblTeam2Name.Text = this.selectedMatch.Teams[1].ClubName;


            SetDgwPlayersTeam1(this.selectedMatch.Teams[0].Players);
            SetDgwPlayersTeam2(this.selectedMatch.Teams[1].Players);
        }

        public void SetResultControls()
        {
            this.lblTeam1Result.Text = this.selectedMatch.Scores[0].ToString();
            this.lblTeam2Result.Text = this.selectedMatch.Scores[1].ToString();

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

        public void SetMatchControls()
        {
            this.lblDateOfMatch.Text = this.selectedMatch.Date.ToString("dd:MM:yyyy hh:mm");
            string levelOfMatch = this.selectedMatch.SpecificNumber;
            if (this.selectedMatch.Level == "draw")
                levelOfMatch = this.GetLevelOfCompetition(levelOfMatch);
            this.lblLevelOfMatch.Text = levelOfMatch;
        }
        private void SetDgwPlayersTeam1(Player[] players)
        {
            DgwPlayerListTeam1.Columns.Clear();
            DgwPlayerListTeam1.Rows.Clear();

            //   this.competitionWindow.DgwPlayers.DataSource = players;
            DgwPlayerListTeam1.ColumnCount = 11;
            if (DgwPlayerListTeam1.ColumnCount == 0)
                return;
            DgwPlayerListTeam1.Columns[0].Name = "IME ";
            DgwPlayerListTeam1.Columns[1].Name = "PREZIME";
            DgwPlayerListTeam1.Columns[2].Name = "BROJ GOLOVA";
            DgwPlayerListTeam1.Columns[3].Name = "DODAJ GOL";
            DgwPlayerListTeam1.Columns[4].Name = "PONIŠTI GOL";
            DgwPlayerListTeam1.Columns[5].Name = "KAPITEN";
            DgwPlayerListTeam1.Columns[6].Name = "KARTONI";
            DgwPlayerListTeam1.Columns[7].Name = "DODAJ KARTON";
            DgwPlayerListTeam1.Columns[8].Name = "PONIŠTI KARTON";
            DgwPlayerListTeam1.Columns[9].Name = "BROJ";
            DgwPlayerListTeam1.Columns[10].Name = "POZICIJA";

            int index;
            for (index = 0; index < players.Length; index++)
            {
                Player tmpPlayer = players[index];
                if (tmpPlayer != null)
                {
                    string[] row = new string[] { tmpPlayer.PersonName, tmpPlayer.Surname, tmpPlayer.GoalNumInMatch.ToString(), tmpPlayer.Captain.ToString(), tmpPlayer.Cards.ToString(), tmpPlayer.Num.ToString(), tmpPlayer.Position };
                    // DgwPlayerListTeam1.Rows.Add(row);

                    DataGridViewButtonCell btn = new DataGridViewButtonCell();
                    btn.Value = "Dodaj gol";
                    //btn.HeaderText = "Click Data";
                    //btn.Text = "Click Here";
                    //btn.Name = "btn";
                    btn.UseColumnTextForButtonValue = true;

                    DataGridViewButtonCell btn2 = new DataGridViewButtonCell();
                    btn2.Value = "Ponisti gol";
                    //btn.HeaderText = "Click Data";
                    //btn.Text = "Click Here";
                    //btn.Name = "btn";
                    btn2.UseColumnTextForButtonValue = true;

                    DataGridViewButtonCell btn3 = new DataGridViewButtonCell();
                    btn3.Value = "Dodaj karton";
                    //btn.HeaderText = "Click Data";
                    //btn.Text = "Click Here";
                    //btn.Name = "btn";
                    btn3.UseColumnTextForButtonValue = true;

                    DataGridViewButtonCell btn4 = new DataGridViewButtonCell();
                    btn4.Value = "Ponisti karton";
                    //btn.HeaderText = "Click Data";
                    //btn.Text = "Click Here";
                    //btn.Name = "btn";
                    btn4.UseColumnTextForButtonValue = true;


                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(DgwPlayerListTeam1);
                    newRow.Cells[0].Value = tmpPlayer.PersonName;
                    newRow.Cells[1].Value = tmpPlayer.Surname;
                    newRow.Cells[2].Value = tmpPlayer.GoalNumInMatch.ToString();
                    newRow.Cells[3] = btn;
                    newRow.Cells[4] = btn2;
                    if(tmpPlayer.Captain)
                        newRow.Cells[5].Value = "DA";
                    else
                        newRow.Cells[5].Value = "NE";
                    newRow.Cells[6].Value = tmpPlayer.Cards.ToString();
                    newRow.Cells[7] = btn3;
                    newRow.Cells[8] = btn4;
                    newRow.Cells[9].Value = tmpPlayer.Num;
                    newRow.Cells[10].Value = tmpPlayer.Position;

                    DgwPlayerListTeam1.Rows.Add(newRow);



                }
            }
        }

        private void SetDgwPlayersTeam2(Player[] players)
        {
            DgwPlayerListTeam2.Columns.Clear();
            DgwPlayerListTeam2.Rows.Clear();

            //   this.competitionWindow.DgwPlayers.DataSource = players;
            DgwPlayerListTeam2.ColumnCount = 11;
            if (DgwPlayerListTeam2.ColumnCount == 0)
                return;
            DgwPlayerListTeam2.Columns[0].Name = "IME ";
            DgwPlayerListTeam2.Columns[1].Name = "PREZIME";
            DgwPlayerListTeam2.Columns[2].Name = "BROJ GOLOVA";
            DgwPlayerListTeam2.Columns[3].Name = "DODAJ GOL";
            DgwPlayerListTeam2.Columns[4].Name = "PONIŠTI GOL";
            DgwPlayerListTeam2.Columns[5].Name = "KAPITEN";
            DgwPlayerListTeam2.Columns[6].Name = "KARTONI";
            DgwPlayerListTeam2.Columns[7].Name = "DODAJ KARTON";
            DgwPlayerListTeam2.Columns[8].Name = "PONIŠTI KARTON";
            DgwPlayerListTeam2.Columns[9].Name = "BROJ";
            DgwPlayerListTeam2.Columns[10].Name = "POZICIJA";

            int index;
            for (index = 0; index < players.Length; index++)
            {
                Player tmpPlayer = players[index];
                if (tmpPlayer != null)
                {
                   // string[] row = new string[] { tmpPlayer.Name, tmpPlayer.Surname, tmpPlayer.GoalNumInMatch.ToString(), tmpPlayer.isCapirain.ToString(), tmpPlayer.Cards.ToString(), tmpPlayer.Number.ToString(), tmpPlayer.Position };
                    // DgwPlayerListTeam1.Rows.Add(row);

                    DataGridViewButtonCell btn = new DataGridViewButtonCell();
                    btn.Value = "Dodaj gol";
                    btn.UseColumnTextForButtonValue = true;

                    DataGridViewButtonCell btn2 = new DataGridViewButtonCell();
                    btn2.Value = "Ponisti gol";
                    btn2.UseColumnTextForButtonValue = true;

                    DataGridViewButtonCell btn3 = new DataGridViewButtonCell();
                    btn3.Value = "Dodaj karton";
                    btn3.UseColumnTextForButtonValue = true;

                    DataGridViewButtonCell btn4 = new DataGridViewButtonCell();
                    btn4.Value = "Ponisti karton";
                    btn4.UseColumnTextForButtonValue = true;


                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(DgwPlayerListTeam2);
                    newRow.Cells[0].Value = tmpPlayer.PersonName;
                    newRow.Cells[1].Value = tmpPlayer.Surname;
                    newRow.Cells[2].Value = tmpPlayer.GoalNumInMatch.ToString();
                    newRow.Cells[3] = btn;
                    newRow.Cells[4] = btn2;
                    if (tmpPlayer.Captain)
                        newRow.Cells[5].Value = "DA";
                    else
                        newRow.Cells[5].Value = "NE";
                    newRow.Cells[6].Value = tmpPlayer.Cards.ToString();
                    newRow.Cells[7] = btn3;
                    newRow.Cells[8] = btn4;
                    newRow.Cells[9].Value = tmpPlayer.Num;
                    newRow.Cells[10].Value = tmpPlayer.Position;

                    DgwPlayerListTeam2.Rows.Add(newRow);



                }
            }
        }

        #endregion

        #region RefereeControls

        public void SetCbxRefereeList()
        {
            
            SetCbxRefereeList(refereeList.Referees);
        }


        private void RefereeListSetup()
        {
            RefereeList = new RefereeList();
            if (RefereeList.LoadFromDB().Result)
                this.SetCbxRefereeList();


            //ProbniPodaciSudije(); //OVO ZAKOMENTARISATI, PROBNA FUNKCIJA JE U PITANJU
        }

        //public void ProbniPodaciSudije()
        //{
        //    Referee refw = new Referee("Marko", "Markovic", 10);
        //    Referee resadf = new Referee("Marko", "Markovic", 10);
        //    Referee r231w = new Referee("Marko", "Markovic", 10);
        //    Referee rwqrw = new Referee("Marko", "Markovic", 10);

        //    this.RefereeList.Add(refw);
        //    this.RefereeList.Add(resadf);
        //    this.RefereeList.Add(r231w);
        //    this.RefereeList.Add(rwqrw);

        //}

        private void SetCbxRefereeList(List<Referee> referees)
        {
            CbxRefereeList.Items.Clear();

            referees.ForEach(el =>
            CbxRefereeList.Items.Add(el.PersonName + " " + el.Surname +" - Reg. broj: "+ el.Quality)
            );
        }

        private void cbxRefereeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedCompetition = cbxRefereeList.Text;
            int selectedRefereeIndex = cbxRefereeList.SelectedIndex;
            Referee selectedReferee = this.RefereeList.FindByIndex(selectedRefereeIndex);
            if (selectedReferee != null)
                this.SelectedMatch.Referee = selectedReferee;

        }

        private void SetMatchStarted()
        {
            this.lblIsLive.Text = "Mec je pokrenut!";
            this.btnStartMatch.Enabled = false;
        }


        #endregion

        #region DataGridViewCellClickMethods

        private void dgwPlayerListTeam1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.selectedMatch.isOngoing == false)
            {
                MessageBox.Show("Mec nije pokrenut, morate kliknuti na dugme da najpre pokrenete mec!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = e.RowIndex;

            string selectedPlayer = dgwPlayerListTeam1.SelectedRows[0].Cells["BROJ"].Value.ToString();
            Team scored = this.selectedMatch.Teams[0];
            Team received = this.SelectedMatch.Teams[1];

            Player tmpPlayer = scored.FindPlayer(selectedPlayer);


            if (e.ColumnIndex == 3) //DODAJ GOL
            {
                this.selectedMatch.setGoal(scored, tmpPlayer);
                this.activeCompetition.addGoalToPlayer(tmpPlayer);
                this.activeCompetition.SetGoalToTeamStatistics(scored, received);

                this.SetResultControls();
                this.SetDgwPlayersTeam1(this.selectedMatch.Teams[0].Players);
            }
            else if (e.ColumnIndex == 4) //PONISTI GOL
            {
                if(this.selectedMatch.undoGoal(scored, tmpPlayer))
                {
                        this.activeCompetition.undoGoalToPlayer(tmpPlayer);
                        this.activeCompetition.UndoGoalToTeamStatistics(scored, received);
                        this.SetResultControls();
                        this.SetDgwPlayersTeam1(this.selectedMatch.Teams[0].Players);
                }
            }
            else if (e.ColumnIndex == 7) //DODAJ KARTON
            {
                if (tmpPlayer.setCard())
                {
                    this.activeCompetition.addCardToPlayer(tmpPlayer);
                    this.SetDgwPlayersTeam1(this.selectedMatch.Teams[0].Players);
                }
            }
            else if (e.ColumnIndex == 8) //PONISTI KARTON
            {
                if (tmpPlayer.undoCard())
                {
                    this.activeCompetition.undoCardToPlayer(tmpPlayer);
                    this.SetDgwPlayersTeam1(this.selectedMatch.Teams[0].Players);
                }
            }
        }

        private void dgwPlayerListTeam2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.selectedMatch.isOngoing == false)
            {
                MessageBox.Show("Mec nije pokrenut, morate kliknuti na dugme da najpre pokrenete mec!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = e.RowIndex;

            string selectedPlayer = dgwPlayerListTeam2.SelectedRows[0].Cells["BROJ"].Value.ToString();
            Team received = this.selectedMatch.Teams[0];
            Team scored = this.SelectedMatch.Teams[1];
            Player tmpPlayer = scored.FindPlayer(selectedPlayer);


            if (e.ColumnIndex == 3) //DODAJ GOL
            {
                this.selectedMatch.setGoal(scored, tmpPlayer);
                this.activeCompetition.addGoalToPlayer(tmpPlayer);
                this.activeCompetition.SetGoalToTeamStatistics(scored, received);
                this.SetResultControls();
                this.SetDgwPlayersTeam2(this.selectedMatch.Teams[1].Players);
            }
            else if (e.ColumnIndex == 4) //PONISTI GOL
            {
                if (this.selectedMatch.undoGoal(scored, tmpPlayer))
                {
                    this.activeCompetition.undoGoalToPlayer(tmpPlayer);
                    this.activeCompetition.UndoGoalToTeamStatistics(scored, received);
                    this.SetResultControls();
                    this.SetDgwPlayersTeam2(this.selectedMatch.Teams[1].Players);
                }
            }
            else if (e.ColumnIndex == 7) //DODAJ KARTON
            {
                if (tmpPlayer.setCard())
                {
                    this.activeCompetition.addCardToPlayer(tmpPlayer);
                    this.SetDgwPlayersTeam2(this.selectedMatch.Teams[1].Players);
                }
            }
            else if (e.ColumnIndex == 8) //PONISTI KARTON
            {
                if (tmpPlayer.undoCard())
                {
                    this.activeCompetition.undoCardToPlayer(tmpPlayer);
                    this.SetDgwPlayersTeam2(this.selectedMatch.Teams[1].Players);
                }
            }
        }

        #endregion

        #region EventHandlers

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            this.selectedMatch.start();
            SetMatchControls();
            if (this.selectedMatch.UpdateToDB().Result)
                SetMatchStarted();
            else
                this.selectedMatch.pause();
        }

        private void btnFinishMatch_Click(object sender, EventArgs e)
        {
            if(this.selectedMatch.isOngoing == false)
            {
                MessageBox.Show("Mec nije pokrenut, morate kliknuti na dugme da najpre pokrenete mec!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.selectedMatch.Referee == null)
            {
                MessageBox.Show("Niste selektovali sudiju za ovaj mec!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.selectedMatch.Level == "draw" && this.selectedMatch.Scores[0] == this.selectedMatch.Scores[1])
            {
                MessageBox.Show("Mec u kup sistemu mora da ima pobednika!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach(Player p in this.selectedMatch.Teams[0].Players)
            {
                p.GoalNumInMatch = 0;
            }
            foreach (Player p in this.selectedMatch.Teams[1].Players)
            {
                p.GoalNumInMatch = 0;
            }


            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }

        #endregion







    }
}
