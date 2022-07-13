using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms;
using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Controllers
{
    class AddTeamController : IAddTeamController
    {
        #region Attributes

        private readonly IAddTeamWindow addTeamWindow;
        public Team oldTeam;
        public Team newTeam;
        public Player selectedPlayer;
        public TeamList teamList;

        #endregion

        #region Properties

        public Team NewTeam
        {
            get { return this.newTeam; }
            set
            {
                this.newTeam = value;
                //SetDgwTeams();
                //SetDgwMatches();
            }
        }

        public Team OldTeam
        {
            get { return this.oldTeam; }
            set
            {
                this.oldTeam = value;
                //SetDgwTeams();
                //SetDgwMatches();
            }
        }

        public TeamList TeamList
        {
            get
            {
                return this.teamList;
            }
            set
            {
                this.teamList = value;
            }
        }

        #endregion

        #region Constructors

        public AddTeamController(IAddTeamWindow addTeamWindow) 
        {
            this.addTeamWindow = addTeamWindow;
            NewTeam = new Team();
            selectedPlayer = new Player();

            TeamList = new TeamList();
            GetTeamList();
        }

        #endregion

        #region DataBaseGet

        private void GetTeamList()
        {
            if (teamList.LoadFromDBbb().Result) {
                Console.WriteLine("cao");
            } //OVO OTKOMENTARISATI KADA SE METODA NAPISE
            this.addTeamWindow.SetDgwTeams(this.TeamList);
        }

        #endregion

        #region SetControls

        public void LoadPlayerInControls(string selectedPlayer)
        {
            Player Player = newTeam.FindPlayer(selectedPlayer);
            if (Player == null)
            {
                MessageBox.Show("NIJE NIKO SELEKTOVAN", "NASLOV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.selectedPlayer = Player;

            this.addTeamWindow.LoadPlayerControls(Player);
        }

        public void LoadTeamInControls(string selectedTeam)
        {
            this.OldTeam = this.TeamList.findByName(selectedTeam);
            if (this.OldTeam != null)
            {
                this.newTeam.GetAndSetPlayers(this.OldTeam.Players);
                this.addTeamWindow.LoadTeamControls(OldTeam);
            }

        }

        #endregion

        #region Methods

        public void AddNewPlayer()
        {
            string playerName = this.addTeamWindow.PlayerName;
            string playerSurname = this.addTeamWindow.PlayerSurname;
            int playerNumber = this.addTeamWindow.PlayerNumber;
            string playerPosition = this.addTeamWindow.PlayerPosition;
            bool playerCapitain = this.addTeamWindow.CbxCapitain.Checked;

            Player tmpPlayer = NewTeam.FindPlayer(playerNumber.ToString());
            if(tmpPlayer!= null)
            {
                MessageBox.Show("Igrač sa ovim brojem već postoji!");

                return;
            }

            Player newPlayer = new Player(playerName, playerSurname, 0, playerPosition, playerNumber);
            NewTeam.addPlayer(newPlayer);
            if (playerCapitain)
            {
                NewTeam.setCapitain(newPlayer);
            }
            this.addTeamWindow.SetDgwPlayers(NewTeam.Players);
            this.addTeamWindow.ClearPlayerControls();
        }

        public void DeletePlayer()
        {
            if (NewTeam.deletePlayer(selectedPlayer))
                this.addTeamWindow.SetDgwPlayers(NewTeam.Players);
            else
                MessageBox.Show("Neuspešno brisanje igrača!");
            this.addTeamWindow.ClearPlayerControls();

        }

        public void UpdatePlayer()
        {
            string playerName = this.addTeamWindow.PlayerName;
            string playerSurname = this.addTeamWindow.PlayerSurname;
            int playerNumber = this.addTeamWindow.PlayerNumber;
            string playerPosition = this.addTeamWindow.PlayerPosition;
            bool playerCapitain = this.addTeamWindow.CbxCapitain.Checked;

            Player newPlayer = new Player(playerName, playerSurname, 0, playerPosition, playerNumber);
            if (playerCapitain)
            {
                NewTeam.setCapitain(newPlayer);
            }

            // Player Player = newTeam.FindPlayer(selectedPlayer.Name);
            if (NewTeam.UpdatePlayer(selectedPlayer, newPlayer))
                this.addTeamWindow.SetDgwPlayers(NewTeam.Players);
            else
                MessageBox.Show("Neuspesan update Player-a!");
            this.addTeamWindow.ClearPlayerControls();

        }      
        
        public void AddTeam()
        {
            
            string ClubName = this.addTeamWindow.ClubName;
            string TrainerName = this.addTeamWindow.TrainerName;
            string TrainerSurname = this.addTeamWindow.TrainerSurname;
            Trainer tmpTrainer = new Trainer(TrainerName, TrainerSurname);
            this.newTeam.Trainer = tmpTrainer;
            this.NewTeam.ClubName = ClubName;

            if (this.NewTeam.TeamSize < 12) //OVO JE BITNO PROMENITI PRILIKOM TESTIRANJA
            {
                MessageBox.Show("NIJE DODATO 12 IGRACA", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.NewTeam.FindCapitain() == null)
            {
                MessageBox.Show("NISTE DODALI KAPITENA!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Team tmpTeam = null;
            tmpTeam = this.TeamList.findByName(ClubName); 
            if (tmpTeam == null)
            {
                if (NewTeam.SaveToDB().Result)
                { 
                    this.TeamList.addTeam(NewTeam);
                    this.addTeamWindow.SetDgwTeams(this.TeamList);
                    this.addTeamWindow.ClearTeamControls();
                    newTeam = new Team();
                    OldTeam = new Team();
                }
                
            }
            else
            {
                MessageBox.Show("KLUB SA OVIM IMENOM VEC POSTOJI! PROBAJTE DA AZURIRATE", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //PRIPREMLJENO ZA TESTIRANJE
            //---------------------------------------------
            //newTeam = new Team();
            //OldTeam = new Team();

        }

        public void UpdateTeam()
        {
            string ClubName = this.addTeamWindow.ClubName;
            string TrainerName = this.addTeamWindow.TrainerName;
            string TrainerSurname = this.addTeamWindow.TrainerSurname;
            Trainer tmpTrainer = new Trainer(TrainerName, TrainerSurname);
            this.newTeam.Trainer = tmpTrainer;
            this.NewTeam.ClubName = ClubName;

            if (this.NewTeam.TeamSize < 12) //OVO JE BITNO PROMENITI PRILIKOM TESTIRANJA
            {
                MessageBox.Show("NIJE DODATO 12 IGRACA", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.NewTeam.UpdateToDB(this.oldTeam).Result)
            {
                if (this.TeamList.UpdateTeam(this.OldTeam, this.NewTeam))
                {
                    this.addTeamWindow.EnableAddTeam();
                    this.addTeamWindow.UnableUpdateTeam();
                    this.addTeamWindow.SetDgwTeams(TeamList);
                    this.addTeamWindow.ClearTeamControls();
                }
                else
                {
                    MessageBox.Show("DOSLO JE DO GRESKE PRILIKOM UPDATE!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                newTeam = new Team();
                OldTeam = new Team();
            }
            else
            {
                MessageBox.Show("DOSLO JE DO GRESKE SA BAZOM ili KLUB SA OVIM IMENOM VEC POSTOJI!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            newTeam = new Team();
            OldTeam = new Team();

        }

        public void DeleteTeam(string selectedTeam)
        {
            this.OldTeam = this.TeamList.findByName(selectedTeam);
            if (this.OldTeam != null)
            {
                if (this.OldTeam.DeleteFromDB().Result)
                {
                    this.TeamList.removeTeam(this.OldTeam);
                    this.addTeamWindow.ClearTeamControls();
                    this.addTeamWindow.SetDgwTeams(TeamList);
                    this.addTeamWindow.EnableAddTeam();
                }
            }
            newTeam = new Team();
            OldTeam = new Team();
        }

        #endregion

    }
}
