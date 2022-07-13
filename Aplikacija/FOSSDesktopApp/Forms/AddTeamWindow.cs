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
    public partial class AddTeamWindow : Form, IAddTeamWindow
    {
        #region Attributes

        private IAddTeamController addTeamController;

        #endregion

        #region Constructors

        public AddTeamWindow()
        {
            InitializeComponent();
            this.UnableUpdateTeam();
        }

        #endregion

        #region Properties

        public string ClubName
        {
            get => this.tbxClubName.Text; 
            set => this.tbxClubName.Text = value; 
        }
        public string PlayerName 
        { 
            get => this.tbxPlayerName.Text; 
            set => this.tbxPlayerName.Text = value; 
        }
        public string PlayerSurname 
        { 
            get => this.tbxPlayerSurname.Text; 
            set => this.tbxPlayerSurname.Text = value; 
        }
        public int PlayerNumber 
        { 
            get => (int) this.nudPlayerNumber.Value; 
            set => this.nudPlayerNumber.Value = value; 
        }
        public string PlayerPosition 
        { 
            get => this.tbxPlayerPosition.Text; 
            set => this.tbxPlayerPosition.Text = value; 
        }
        DataGridView IAddTeamWindow.DgwPlayers 
        {
            get => this.DgwPlayers; 
            set => this.DgwPlayers = value; 
        }
        public string TrainerName 
        {
            get => this.tbxTrainerName.Text; 
            set => this.tbxTrainerName.Text = value; 
        }
        public string TrainerSurname 
        { 
            get => this.tbxTrainerSurname.Text; 
            set => this.tbxTrainerSurname.Text = value; 
        }
        public DataGridView DgwTeams 
        {   
            get => this.dgwTeams;
            set => this.dgwTeams = value; 
        }
        public CheckBox CbxCapitain 
        { 
            get => this.cbxCapitain;
            set => this.cbxCapitain = value; 
        }

        #endregion

        #region Methods

        public void SetController(IAddTeamController addTeamController)
        {
            this.addTeamController = addTeamController;
        }

        public bool ValidateInputClub()
        { 
            if (String.IsNullOrEmpty(this.ClubName) == true || String.IsNullOrEmpty(this.TrainerName) == true || String.IsNullOrEmpty(this.TrainerSurname) == true)
            {
                MessageBox.Show("Niste uneli ime kluba!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateInputPlayer()
        {
            if (String.IsNullOrEmpty(this.PlayerName) == true || String.IsNullOrEmpty(this.PlayerSurname) == true || String.IsNullOrEmpty(this.PlayerPosition) == true || this.PlayerNumber < 0 || this.PlayerNumber > 100)
            {
                MessageBox.Show("Greška prilikom unosa podataka o igraču!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true; 
        }

        public void LoadPlayerControls(Player player)
        {
            this.PlayerName = player.PersonName;
            this.PlayerSurname = player.Surname;
            this.PlayerPosition = player.Position;
            this.PlayerNumber = player.Num;
            this.cbxCapitain.Checked = player.Captain;
        }

        public void LoadTeamControls(Team team)
        {
            this.ClubName = team.ClubName;
            this.TrainerName = team.Trainer.PersonName;
            this.TrainerSurname = team.Trainer.Surname;
            SetDgwPlayers(team.Players);
            this.UnableAddTeam();
            this.EnableUpdateTeam();
        }

        public void SetDgwTeams(TeamList TeamList)
        {
            string[] row;
            //  this.competitionWindow.DgwTeams.DataSource = this.SelectedCompetition.TeamList;

            this.dgwTeams.Columns.Clear();
            this.dgwTeams.Rows.Clear();

            this.DgwTeams.ColumnCount = 4;
            if (this.DgwTeams.ColumnCount == 0)
                return;
            this.DgwTeams.Columns[0].Name = "IME KLUBA";
            this.DgwTeams.Columns[1].Name = "TRENER";
            this.DgwTeams.Columns[2].Name = "BROJ IGRAČA";
            this.DgwTeams.Columns[3].Name = "KAPITEN";


            int index;
            for (index = 0; index < TeamList.getNumberOfTeams(); index++)
            {
                Team tmpTeam = TeamList.returnByIndex(index);
                Player tmpCapitain = tmpTeam.Capitain;
                Trainer tmpTrainer = tmpTeam.Trainer;
                /*if (capitain == null)
                    row = new string[] { tmpTeam.Name, tmpTeam.Trainer.Name + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), "Ne postoji kapiten" };
                if (tmpTeam.Trainer == null)
                    row = new string[] { tmpTeam.Name, "trener nepoznat", tmpTeam.TeamSize.ToString(), "nepoznat kapetan" };
                else
                    row = new string[] { tmpTeam.Name, tmpTeam.Trainer.Name + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), tmpTeam.Capitain.Name + " " + tmpTeam.Capitain.Surname };
                */
                if(tmpTeam != null && tmpTrainer != null && tmpCapitain != null)
                    row = new string[] { tmpTeam.ClubName, tmpTeam.Trainer.PersonName + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), tmpCapitain.PersonName + " " + tmpCapitain.Surname };
                else if(tmpTeam != null)
                {
                    row = new string[] { tmpTeam.ClubName, "Trener nepoznat", tmpTeam.TeamSize.ToString(), "Kapiten nepoznat" };
                }
                else
                {
                    MessageBox.Show("Greska  prilikom prikazivanja liste timova! Tim u listi je null!");
                    break;
                }

                this.DgwTeams.Rows.Add(row);
            }
        }

        public void SetDgwPlayers(Player[] players)
        {
            this.DgwPlayers.Columns.Clear();
            this.DgwPlayers.Rows.Clear();

            //   this.competitionWindow.DgwPlayers.DataSource = players;
            this.DgwPlayers.ColumnCount = 7;
            if (this.DgwPlayers.ColumnCount == 0)
                return;
            this.DgwPlayers.Columns[0].Name = "IME ";
            this.DgwPlayers.Columns[1].Name = "PREZIME";
            this.DgwPlayers.Columns[2].Name = "BROJ GOLOVA";
            this.DgwPlayers.Columns[3].Name = "KAPITEN";
            this.DgwPlayers.Columns[4].Name = "KARTONI";
            this.DgwPlayers.Columns[5].Name = "BROJ";
            this.DgwPlayers.Columns[6].Name = "POZICIJA";

            int index;
            for (index = 0; index < players.Length; index++)
            {
                Player tmpPlayer = players[index];
                if (tmpPlayer != null)
                {
                    string[] row = new string[] { tmpPlayer.PersonName, tmpPlayer.Surname, tmpPlayer.GoalNum.ToString(), tmpPlayer.Captain.ToString(), tmpPlayer.Cards.ToString(), tmpPlayer.Num.ToString(), tmpPlayer.Position };
                    this.DgwPlayers.Rows.Add(row);
                }
            }
        }

        public void CloseForm()
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }



        public void ClearPlayerControls()
        {
            PlayerName = "";
            PlayerSurname = "";
            PlayerPosition = "";
            PlayerNumber = 0;
            CbxCapitain.Checked = false;
        }

        public void ClearTeamControls()
        {
            ClubName = "";
            TrainerName = "";
            TrainerSurname = "";
            this.DgwPlayers.Columns.Clear();
            this.DgwPlayers.Rows.Clear();
            this.ClearPlayerControls();
            this.UnableUpdateTeam();

        }

        public void UnableUpdateTeam()
        {
            this.btnUpdateTeam.Enabled = false;
        }

        public void UnableAddTeam()
        {
            this.btnAddTeam.Enabled = false;
        }

        public void EnableUpdateTeam()
        {
            this.btnUpdateTeam.Enabled = true;
        }

        public void EnableAddTeam()
        {
            this.btnAddTeam.Enabled = true;
        }


        #endregion

        #region EventHandlers

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (ValidateInputPlayer())
                addTeamController.AddNewPlayer();

        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            addTeamController.DeletePlayer();
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            if (ValidateInputPlayer())
                this.addTeamController.UpdatePlayer();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if(ValidateInputClub())
                addTeamController.AddTeam();
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            //this.EnableAddTeam();
            //this.UnableUpdateTeam();
            this.addTeamController.UpdateTeam();
        }

        private void btnDeleteClub_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedTeam = DgwTeams.SelectedRows[0].Cells["IME KLUBA"].Value.ToString();
                addTeamController.DeleteTeam(selectedTeam);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati klub!");
            }
        }

        private void DgwPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string selectedPlayer = DgwPlayers.SelectedRows[0].Cells["BROJ"].Value.ToString();
                addTeamController.LoadPlayerInControls(selectedPlayer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska kod selektovanja igraca! " + ex.Message + " - " + ex.Source);
            }
        }

        private void dgwTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string selectedTeam = DgwTeams.SelectedRows[0].Cells["IME KLUBA"].Value.ToString();
                addTeamController.LoadTeamInControls(selectedTeam);
                this.UnableAddTeam();
                this.EnableUpdateTeam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska kod selektovanja klubova! " + ex.Message + " - " + ex.Source);
            }
        }

        #endregion

    }
}
