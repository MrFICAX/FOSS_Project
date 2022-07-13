using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms;
using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Windows.Forms;

namespace FOSSDesktopApp.Controllers
{
    class LoginController : ILoginController
    {
        #region Attributes

        private readonly ILoginWindow loginWindow;
        private readonly IMainWindow mainWindow;

        #endregion

        #region Constructors

        public LoginController(ILoginWindow loginWindow, IMainWindow mainWindow)
        {
            this.loginWindow = loginWindow;
            this.mainWindow = mainWindow;
        }

        #endregion

        #region Methods

        public void EnterKeyButtonClicked()
        {
            String enterKey = this.loginWindow.TbxAdmEnterKey;
            if (!CheckInputAdministator(enterKey))
                return;

             Administrator administrator = new Administrator(enterKey);
            
            if (administrator.LoadFromDB().Result)
            {
                if (administrator.CheckEnterKey(enterKey))
                {
                    OpenAdministratorWindow(administrator);
                }
                else
                {
                    MessageBox.Show("EnterKey je netacan!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Greska prilikom komunikacije sa bazom!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoginButtonClicked()
        {
            String userName = this.loginWindow.TbxOrgUserName;
            String password = this.loginWindow.TbxOrgPassword;
            if (!CheckInputOrganiser(userName, password))
                return;

            Organizer organizer = new Organizer(userName, password);

            //SVE ISPOD JE SPREMNO ZA PROBU
            //organizer.SaveToDB(); //OVO DODATI SAMO JEDNOM KADA SE POKRENE APLIKACIJA DA PROBAMO DODAVANJE ORGANIZATORA U BAZU

            //organizer.SaveToDB();
            //return;



            if (organizer.LoadFromDBb().Result) { }

            else
            {
                MessageBox.Show("Ne radi komunikacija sa bazom!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (organizer.Login(userName,password)) 
            {
                OpenOrganizerWindow(organizer);
            }
            else
            {
                MessageBox.Show("Username ili šifra nisu tačni!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }

        #endregion

        #region Validation

        private bool CheckInputAdministator(string enterKey)
        {
            if (String.IsNullOrEmpty(enterKey) == true)
            {
                MessageBox.Show("EnterKey polje je prazno!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckInputOrganiser(string userName, string password)
        {
            if (String.IsNullOrEmpty(userName) == true || String.IsNullOrEmpty(password) == true)
            {
                MessageBox.Show("Unesite sve parametre!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true; 

        }

        #endregion

        #region TestMethods

        //USELESS FUNKCIJA
        public void OpenAdministratorWindow(/*Administrator administrator*/)
        {
            AdministratorWindow administratorWindow = new AdministratorWindow();
            IAdministratorController administratorController = new AdministratorController(administratorWindow, mainWindow/*, administrator*/);
            administratorWindow.SetController(administratorController);
           

            this.mainWindow.OpenChildForm(administratorWindow);
            SetMainWindow(administratorWindow, administratorController);
        }

        //USELESS FUNKCIJA
        public void OpenOrganizerWindow(/*Organizer organizer*/)
        {
            OrganizerWindow organizerWindow = new OrganizerWindow();
            IOrganizerController organizerController = new OrganizerController(organizerWindow, mainWindow);
            organizerWindow.SetController(organizerController);


            this.mainWindow.OpenChildForm(organizerWindow);
            SetMainWindow(organizerWindow, organizerController);
        }

        #endregion

        #region OpenWindowMethods

        public void SetMainWindow(Form Window, IController Controller)
        {
            this.mainWindow.setActiveWindow(Window);
            this.mainWindow.setActiveController(Controller);
        }

        private void OpenOrganizerWindow(Organizer organizer)
        {
            OrganizerWindow organizerWindow = new OrganizerWindow();
            IOrganizerController organizerController = new OrganizerController(organizerWindow, mainWindow, organizer);
            organizerWindow.SetController(organizerController);


            this.mainWindow.OpenChildForm(organizerWindow);
            SetMainWindow(organizerWindow, organizerController);
        }

        public void OpenAdministratorWindow(Administrator administrator)
        {
            AdministratorWindow administratorWindow = new AdministratorWindow();
            IAdministratorController administratorController = new AdministratorController(administratorWindow, mainWindow, administrator);
            administratorWindow.SetController(administratorController);


            this.mainWindow.OpenChildForm(administratorWindow);
            SetMainWindow(administratorWindow, administratorController);
        }

        public void AddNewOrganizerClicked()
        {
            var frm = new AddOrganizerWindow();

            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                frm.Close();
            }
        }

        #endregion

    }
}
