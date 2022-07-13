using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOSSDesktopApp.Engine;
using System.Drawing;
using FOSSDesktopApp.Forms;

namespace FOSSDesktopApp.Controllers
{
    class OrganizerController : IOrganizerController
    {
        #region Attributes

        private readonly IOrganizerWindow organizerWindow;
        private readonly IMainWindow mainWindow;
        private Form activeForm;
        private IController activeController;
        private CompetitionList competitionList;
        private Competition activeCompetition;
        private Organizer activeOrganizer;

        #endregion

        #region Properties

        public Form ActiveForm
        {
            get { return this.activeForm; }
            set { this.activeForm = value; }
        }
        public IController ActiveController
        {
            get { return this.activeController; }
            set { this.activeController = value; }
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
                frm.Owner = (Form)this.organizerWindow;
                frm.Show();

                if (this.activeCompetition.LoadFromDB().Result) { }
                frm.Close();
                SetCompetitionLabels();
                ChangeCompetitionWindow();
            }
        }

        public Organizer ActiveOrganizer
        {
            get { return this.activeOrganizer; }
            set
            {
                this.activeOrganizer = value;
                this.CompetitionList = this.ActiveOrganizer.Events;
                SetOrganizerLabels();
            }
        }

        #endregion

        #region ControlsSetters

        private void InputComboBox()
        {
            this.organizerWindow.CbxSelectCompetition.Items.Clear();
            //OVO ZAKOMENTARISATI KADA SE TESTIRA PRIBAVLJANJE IZ BAZE
          
            
            //*/

            competitionList.EventList.ForEach(el =>
            this.organizerWindow.CbxSelectCompetition.Items.Add(el.Name)
            );
        }

        private void TestDodavanjTakmicenjaOrganizatoru()
        {
            /*
            ///* TEST PODACI
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


            ActiveOrganizer.Events = lista;
            */
            CompetitionList = this.activeOrganizer.Events;
        }

        private void SetOrganizerLabels()
        {
            this.organizerWindow.LblUserName = activeOrganizer.Username;
            this.organizerWindow.LblDateOfLogin = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
        }

        private void SetCompetitionLabels()
        {
            this.organizerWindow.LblNameOfSelectedCompetition = activeCompetition.Name;
            this.organizerWindow.LblLocationOfSelectedCompetition = activeCompetition.Location;
            this.organizerWindow.LblDateOfSelectedCompetition = activeCompetition.StartDate.ToString("MM/dd/yyyy h:mm tt");
            if (this.activeCompetition.Winner != null)
                this.organizerWindow.LblWinnerOfSelectedCompetition = activeCompetition.Winner;
            else
                this.organizerWindow.LblWinnerOfSelectedCompetition = "Ne postoji pobednik";

        }

        #endregion

        #region Contructors

        public OrganizerController(IOrganizerWindow organizerWindow, IMainWindow mainWindow)
        {
            this.organizerWindow = organizerWindow;
            this.mainWindow = mainWindow;

        }

        public OrganizerController(IOrganizerWindow organizerWindow, IMainWindow mainWindow, Organizer organizer) : this(organizerWindow, mainWindow)
        {
            ActiveOrganizer = organizer;
            TestDodavanjTakmicenjaOrganizatoru();
        }

        #endregion

        #region Methods

        private void ChangeCompetitionWindow()
        {
            if (ActiveForm == null)
                OpenCompetitionWindow(ActiveCompetition.Name);

            if (ActiveForm.GetType() == typeof(CompetitionWindow))
                OpenCompetitionWindow(ActiveCompetition.Name);
            if (ActiveForm.GetType() == typeof(AddCompetitionWindow))
                OpenCompetitionWindow(ActiveCompetition.Name);
        }

        public void LoadActiveCompetition(string nameOfCompetition)
        {
            Competition selected = competitionList.findByname(nameOfCompetition);
            if (selected != null)
                ActiveCompetition = selected;
            else
                MessageBox.Show("GRESKA KOD TRAZENJA TAKMICENJA");
        }

        public void OpenCompetitionWindow(String nameOfCompetition)
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

        public void OpenAddAdministratorWindow()
        {
            AddAdministratorWindow aaw = new AddAdministratorWindow();

            IAddAdministratorController mc = new AddAdministratorController(aaw, this.ActiveOrganizer);
            aaw.SetController(mc);
            OpenChildForm((Form) aaw, false);

            ActiveForm = aaw;
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
            if(flag)
               childForm.Location = new Point((organizerWindow.OrganiserPanel.Width - childForm.Width) / 2, (organizerWindow.OrganiserPanel.Height - childForm.Height) / 2);

            //childForm.Left = (this.Height - childForm.Width) / 2;
            //childForm.Top = (this.Height - childForm.Height) / 2;
            organizerWindow.OrganiserPanel.Controls.Add(childForm);
            organizerWindow.OrganiserPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void IOrganizerController.OpenLoginForm()
        {
            mainWindow.openLoginForm();
        }

        public void OpenAddNewCompetitionWindow()
        {
            AddCompetitionWindow acw = new AddCompetitionWindow();

            IAddCompetitionController cc = new AddCompetitionController(acw, this);
            acw.SetController(cc);
            OpenChildForm(acw, false);

            ActiveForm = acw;
        }

        public void AddNewCompetition(Competition newCompetition)
        {
            if(newCompetition.TeamList.Length <= 1)
            {
                MessageBox.Show("Morate dodati minimum 2 kluba prilikom kreiranja takmicenja!",
               "Obavestenje",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                return;
            }
            newCompetition.Org = activeOrganizer;
            if (newCompetition.SaveToDBb(this.ActiveOrganizer).Result) {
                ActiveOrganizer.AddCompetition(newCompetition);
                ActiveOrganizer = ActiveOrganizer;
                //this.ActiveCompetition = newCompetition;
                this.activeCompetition = newCompetition;
                SetCompetitionLabels();
                ChangeCompetitionWindow();

            }
        }

        //USELESS FUNKCIJA
        void IOrganizerController.ChangeCompetitionWindow()
        {
            if(ActiveForm.GetType() == typeof(CompetitionWindow))
                 OpenCompetitionWindow(ActiveCompetition.Name);
        }

        public void OpenAddNewClub()
        {
            AddTeamWindow atw = new AddTeamWindow();

            IAddTeamController mc = new AddTeamController(atw);
            atw.SetController(mc);
            OpenChildForm((Form)atw, true);

            ActiveForm = atw;
        }

        public void OpenAddNewReferee()
        {
            RefereeWindow rw = new RefereeWindow();

            IRefereeController rc = new RefereeController(rw);
            rw.SetController(rc);
            OpenChildForm((Form)rw, true);

            ActiveForm = rw;
        }

        public void OpenControlDraw(string selectedCompetition)
        {
            if (ActiveCompetition == null)
            {
                MessageBox.Show("Morate izabrati takmičenje iz padajućeg menija.",
                               "Obavestenje",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }
            
            
            ControlDrawWindow cdw = new ControlDrawWindow();

            IControlDrawController cdc = new ControlDrawController(cdw, ActiveCompetition);
            cdw.setController(cdc);
            OpenChildForm(cdw, false);

            ActiveForm = cdw;
            
        }

        #endregion
    }
}
