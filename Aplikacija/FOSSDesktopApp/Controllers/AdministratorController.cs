using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms;
using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Controllers
{
    class AdministratorController : IAdministratorController
    {
        #region Attributes

        private readonly IAdministratorWindow administratorWindow;
        private readonly IMainWindow mainWindow;
        private Form activeForm;
        private CompetitionList competitionList;
        private Competition activeCompetition;
        private Administrator activeAdministrator;

    #endregion

        #region Properties

        public Form ActiveForm
        {
            get { return this.activeForm; }
            set { this.activeForm = value; }
        }


        public CompetitionList CompetitionList
        {
            get { return this.competitionList; }
            set
            {
                this.competitionList = value;
                InputComboBox();
            }
        }

        public Competition ActiveCompetition
        {
            get { return this.activeCompetition; }
            set
            {
                this.activeCompetition = value;

                var frm = new LoadingDialogWindow();
                frm.Owner = (Form)this.administratorWindow;
                frm.Show();

                if (this.activeCompetition.LoadFromDB().Result){ }
                frm.Close();
                SetCompetitionLabels();
                ChangeCompetitionWindow();
            }
        }

        public Administrator ActiveAdministrator
        {
            get { return this.activeAdministrator; }
            set
            {
                this.activeAdministrator = value;
                this.CompetitionList = this.ActiveAdministrator.Competitions;
                SetOrganizerLabels();
            }
        }

        #endregion

        #region SetControls

        private void InputComboBox()
        {
            this.administratorWindow.CbxSelectCompetition.Items.Clear();


            competitionList.EventList.ForEach(el =>
            this.administratorWindow.CbxSelectCompetition.Items.Add(el.Name)
            );
        }

        private void SetOrganizerLabels()
        {
            this.administratorWindow.LblUserName = activeAdministrator.PersonName;
            this.administratorWindow.LblDateOfLogin = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
        }

        public void SetCompetitionLabels()
        {
            this.administratorWindow.LblNameOfSelectedCompetition = activeCompetition.Name;
            this.administratorWindow.LblLocationOfSelectedCompetition = activeCompetition.Location;
            this.administratorWindow.LblDateOfSelectedCompetition = activeCompetition.StartDate.ToString("MM/dd/yyyy h:mm tt");
            if(this.activeCompetition.Winner != null)
                this.administratorWindow.LblWinnerOfSelectedCompetition = activeCompetition.Winner;
            else
                this.administratorWindow.LblWinnerOfSelectedCompetition = "Ne postoji pobednik";
        }

        #endregion

        #region Constructors

        public AdministratorController(IAdministratorWindow administratorWindowa, IMainWindow mainWindow)
        {
            this.administratorWindow = administratorWindowa;
            this.mainWindow = mainWindow;
        }

        public AdministratorController(IAdministratorWindow administratorWindowa, IMainWindow mainWindow, Administrator activeAdministrator) : this(administratorWindowa, mainWindow)
        {
            ActiveAdministrator = activeAdministrator;
           // TestDodavanjTakmicenjaOrganizatoru();
        }

        private void TestDodavanjTakmicenjaOrganizatoru()
        {
            /*
            CompetitionList lista = new CompetitionList();
            Competition c1 = new Competition("Aleksinac Futsal turnir", "Aleksinac", DateTime.Now, new Organizer());
            Team tmpTeam = new Team("FK DONJA DUBRAVA", new Trainer("Marko", "Markovic"));
            Team tmpTeam2 = new Team("FK SOKOBANJA", new Trainer("Stefan", "Stefanovic"));
            Team tmpTeam3 = new Team("FK ALEKSINAC", new Trainer("Stefan", "Stefanovic"));
            Team tmpTeam4 = new Team("FK GORNJA DUBRAVA", new Trainer("Stefan", "Stefanovic"));
            Team tmpTeam5 = new Team("cxvbxcb", new Trainer("Stefan", "Stefanovic"));
            Team tmpTeam6 = new Team("FK GqwerBRAVA", new Trainer("Stefan", "Stefanovic"));

            Team tmpTeam7 = new Team("cxvbdsfgA", new Trainer("Stefan", "Stefanovic"));
            Team tmpTeam8 = new Team("FdRAVA", new Trainer("Stefan", "Stefanovic"));

            Team tmpTeam9 = new Team("FK GewVA", new Trainer("Stefan", "Stefanovic"));

            //c1.addTeam(tmpTeam);
            //c1.addTeam(tmpTeam2);
            //c1.addTeam(tmpTeam3);
            //c1.addTeam(tmpTeam4);
            ////c1.addTeam(tmpTeam6);

            // c1.addTeam(tmpTeam7);
            //c1.addTeam(tmpTeam8);

            // c1.addTeam(tmpTeam9);

            Player capitain = new Player("Filip", "Markovic", 0, "Attack", 14);
            tmpTeam.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 10));
            tmpTeam.addPlayer(new Player("Stefan", "Stefanovic", 0, "Attack", 11));
            tmpTeam.addPlayer(new Player("Nikola", "Trajkovic", 0, "Attack", 13));

            tmpTeam.addPlayer(new Player("Nikola", "Jankovic", 0, "Attack", 1));
            tmpTeam.addPlayer(new Player("Stefan", "Janackovic", 0, "Attack", 2));
            tmpTeam.addPlayer(new Player("Nikola", "Markovic", 0, "Attack", 3));

            tmpTeam.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 4));
            tmpTeam.addPlayer(new Player("Stefan", "Markovic", 0, "Attack", 5));
            tmpTeam.addPlayer(new Player("Nikola", "Jovanovic", 0, "Attack", 6));

            tmpTeam.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 7));
            tmpTeam.addPlayer(new Player("Stefan", "Stankovic", 0, "Attack", 8));
            tmpTeam.addPlayer(capitain);
            tmpTeam.setCapitain(capitain);
            c1.addTeam(tmpTeam);
            //c1.addTeam(new Team("FK GORNJA DUBRAVA", new Trainer("Marko", "Stankovic")));
            //c1.addTeam(new Team("FK DONJA MORAVA", new Trainer("Marko", "Stefanovic")));

            capitain = new Player("Filip", "Markovic", 0, "Attack", 14);
            tmpTeam2.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 10));
            tmpTeam2.addPlayer(new Player("Stefan", "Stefanovic", 0, "Attack", 11));
            tmpTeam2.addPlayer(new Player("Nikola", "Trajkovic", 0, "Attack", 13));

            tmpTeam2.addPlayer(new Player("Nikola", "Jankovic", 0, "Attack", 1));
            tmpTeam2.addPlayer(new Player("Stefan", "Janackovic", 0, "Attack", 2));
            tmpTeam2.addPlayer(new Player("Nikola", "Markovic", 0, "Attack", 3));

            tmpTeam2.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 4));
            tmpTeam2.addPlayer(new Player("Stefan", "Markovic", 0, "Attack", 5));
            tmpTeam2.addPlayer(new Player("Nikola", "Jovanovic", 0, "Attack", 6));

            tmpTeam2.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 7));
            tmpTeam2.addPlayer(new Player("Stefan", "Stankovic", 0, "Attack", 8));
            tmpTeam2.addPlayer(capitain);
            tmpTeam2.setCapitain(capitain);
            c1.addTeam(tmpTeam2);

            capitain = new Player("Filip", "Markovic", 0, "Attack", 14);
            tmpTeam3.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 10));
            tmpTeam3.addPlayer(new Player("Stefan", "Stefanovic", 0, "Attack", 11));
            tmpTeam3.addPlayer(new Player("Nikola", "Trajkovic", 0, "Attack", 13));

            tmpTeam3.addPlayer(new Player("Nikola", "Jankovic", 0, "Attack", 1));
            tmpTeam3.addPlayer(new Player("Stefan", "Janackovic", 0, "Attack", 2));
            tmpTeam3.addPlayer(new Player("Nikola", "Markovic", 0, "Attack", 3));

            tmpTeam3.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 4));
            tmpTeam3.addPlayer(new Player("Stefan", "Markovic", 0, "Attack", 5));
            tmpTeam3.addPlayer(new Player("Nikola", "Jovanovic", 0, "Attack", 6));

            tmpTeam3.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 7));
            tmpTeam3.addPlayer(new Player("Stefan", "Stankovic", 0, "Attack", 8));
            tmpTeam3.addPlayer(capitain);

            tmpTeam3.setCapitain(capitain);
            c1.addTeam(tmpTeam3);

            capitain = new Player("Filip", "Markovic", 0, "Attack", 14);
            tmpTeam4.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 10));
            tmpTeam4.addPlayer(new Player("Stefan", "Stefanovic", 0, "Attack", 11));
            tmpTeam4.addPlayer(new Player("Nikola", "Trajkovic", 0, "Attack", 13));

            tmpTeam4.addPlayer(new Player("Nikola", "Jankovic", 0, "Attack", 1));
            tmpTeam4.addPlayer(new Player("Stefan", "Janackovic", 0, "Attack", 2));
            tmpTeam4.addPlayer(new Player("Nikola", "Markovic", 0, "Attack", 3));

            tmpTeam4.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 4));
            tmpTeam4.addPlayer(new Player("Stefan", "Markovic", 0, "Attack", 5));
            tmpTeam4.addPlayer(new Player("Nikola", "Jovanovic", 0, "Attack", 6));

            tmpTeam4.addPlayer(new Player("Marko", "Markovic", 0, "Attack", 7));
            tmpTeam4.addPlayer(new Player("Stefan", "Stankovic", 0, "Attack", 8));
            c1.addTeam(tmpTeam4);
            tmpTeam4.addPlayer(capitain);
            tmpTeam4.setCapitain(capitain);
            lista.addEvent(c1);

            Match noviM = new Match(tmpTeam, tmpTeam2, new Referee("Marko", "Marinkovic", 9), DateTime.Now, "", "");
            c1.addMatch(noviM);


            activeAdministrator.Events = lista;
            */
            CompetitionList = this.activeAdministrator.Competitions;
        }

        #endregion

        #region Methods

        private void ChangeCompetitionWindow()
        {
            if (ActiveForm == null)
                OpenCompetitionWindow(ActiveCompetition.Name);

            if (ActiveForm.GetType() == typeof(CompetitionWindow))
                OpenCompetitionWindow(ActiveCompetition.Name);

        }

        public void LoadActiveCompetition(string selectedCompetition)
        {
            ActiveCompetition = competitionList.findByname(selectedCompetition);
        }

        public void OpenCompetitionWindow(string selectedCompetition)
        {
            if (ActiveCompetition == null)
            {
                MessageBox.Show("Morate izabrati takmičenje iz padajućeg menija.",
                               "Obavestenje",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }
            CompetitionWindow cw = new CompetitionWindow();

            ICompetitionController cc = new CompetitionController(cw, ActiveCompetition);
            cw.SetController(cc);
            OpenChildForm(cw, false);

            ActiveForm = cw;
        }

        void OpenChildForm(Form childForm, bool flag) //samo za prikaz forme
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Anchor = AnchorStyles.None;
            if (flag)
                childForm.Location = new Point((administratorWindow.AdministratorPanel.Width - childForm.Width) / 2, (administratorWindow.AdministratorPanel.Height - childForm.Height) / 2);

            //childForm.Left = (this.Height - childForm.Width) / 2;
            //childForm.Top = (this.Height - childForm.Height) / 2;
            administratorWindow.AdministratorPanel.Controls.Add(childForm);
            administratorWindow.AdministratorPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void OpenLoginForm()
        {
            mainWindow.openLoginForm();
        }

        public void OpenManageMatchesWindow(string selectedCompetition)
        {
            if (ActiveCompetition == null)
            {
                MessageBox.Show("Morate izabrati takmičenje iz padajućeg menija.",
                               "Obavestenje",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }
            ManageMatchesWindow mmw = new ManageMatchesWindow();

            IManageMatchesController mmc = new ManageMatchesController(mmw, ActiveCompetition, this);
            mmw.SetController(mmc);
            OpenChildForm(mmw, false);

            ActiveForm = mmw;
        }

        public void OpenTeamsWindow(string selectedCompetition)
        {
            if (ActiveCompetition == null)
            {
                MessageBox.Show("Morate izabrati takmičenje iz padajućeg menija.",
                               "Obavestenje",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }
            TeamWindow cw = new TeamWindow();

            ITeamController cc = new TeamController(cw, ActiveCompetition);
            cw.SetController(cc);
            OpenChildForm(cw, false);

            ActiveForm = cw;
        }

        #endregion
    }
}
