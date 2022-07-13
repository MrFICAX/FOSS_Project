using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Controllers
{
    class AddCompetitionController : IAddCompetitionController
    {
        #region Attributes

        private readonly AddCompetitionWindow addCompetitionWindow;
        private readonly Competition newCompetition;
        private IOrganizerController activeOrganizerController;
        private TeamList teamList;

        #endregion

        #region Properties

        public TeamList TeamList
        {
            get => this.teamList; 
            set => this.teamList = value; 
        }

        public IOrganizerController ActiveOrganizerController 
        {
            get { return this.activeOrganizerController; }
            set { this.activeOrganizerController = value; }
        }


        #endregion

        #region Constructors

        public AddCompetitionController(AddCompetitionWindow cw, OrganizerController organizer)
        {
            this.addCompetitionWindow = cw;
            newCompetition = new Competition();
            this.ActiveOrganizerController = organizer;
            TeamList = new TeamList();
            LoadAllClubs();
        }

        #endregion

        #region Methods

        public void LoadAllClubs()
        {
            if (TeamList.LoadFromDBbb().Result)
            {
                Console.WriteLine("Pribavili smo klubove");
            }

            //TeamList lista = new TeamList();
          
            /*Team tmpTeam = new Team("FK DONJA DUBRAVA", new Trainer("Marko", "Markovic"));
            Player capitain = new Player("Filip", "Markovic", 0, "Attack", 14);
            tmpTeam.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 10));
            tmpTeam.addPlayer(new Player("Stefan", "Markovic", 0, "Attack", 11));
            tmpTeam.addPlayer(new Player("Nikola", "Markovic", 0, "Attack", 13));
            tmpTeam.addPlayer(capitain);
            tmpTeam.setCapitain(capitain);

            Team t2 = new Team("FK GORNJA DUBRAVA", new Trainer("Marko", "Stankovic"));
            Team t3 = new Team("FK DONJA MORAVA", new Trainer("Marko", "Stefanovic"));

            lista.addTeam(tmpTeam);
            lista.addTeam(t2);
            lista.addTeam(t3);

            TeamList = lista;*/
            this.addCompetitionWindow.SetDgwAllTeams(TeamList);
        }

        public void AddTeam(string selectedTeam)
        {
            Team tmpTeam;
            Team nullable;
            tmpTeam = this.TeamList.findByName(selectedTeam);
            if(tmpTeam == null)
                MessageBox.Show("Morate selektovati klub!");
            else
            {
                nullable = newCompetition.FindTeam(selectedTeam);
                if(nullable == null)
                {
                    newCompetition.AddTeam(tmpTeam);
                    this.addCompetitionWindow.SetDgwTeams(this.newCompetition.TeamList);
                }
                else
                {
                    MessageBox.Show("Ovakav klub već postoji!");
                }
            }
        }

        public void AddNewCompetition(string competitionName, string competitionLocation, DateTime competitionDate)
        {
            this.newCompetition.Name = competitionName;
            this.newCompetition.Location = competitionLocation;
            this.newCompetition.StartDate = competitionDate;
            this.newCompetition.DrawPhase.Root.Date = competitionDate;

           ActiveOrganizerController.AddNewCompetition(this.newCompetition);
        }

        public void RemoveTeam(string selectedTeam)
        {
            Team tmpTeam ;
            Team nullable;
            tmpTeam = this.TeamList.findByName(selectedTeam);
            if (tmpTeam == null)
                MessageBox.Show("Morate selektovati klub!");
            else
            {
                nullable = newCompetition.FindTeam(selectedTeam);
                if (nullable != null)
                {
                    newCompetition.RemoveTeam(tmpTeam);
                    this.addCompetitionWindow.SetDgwTeams(this.newCompetition.TeamList);
                }
                else
                {
                    MessageBox.Show("Ovakav klub ne postoji!");
                }
            }
        }

        #endregion
    }
}
