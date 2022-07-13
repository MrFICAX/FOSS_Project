using FOSSDesktopApp.Controllers.Interfaces;
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
    class MainController : IMainController
    {
        private IMainWindow mainWindow;
        private Form activeForm;
        private IController activeController;

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
        public IMainWindow MainWindow
        {
            get { return this.mainWindow; }
            set { this.mainWindow = value; }
        }


        public MainController(IMainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        void IMainController.openLoginForm()
        {
            ILoginWindow loginWindow = new LoginWindow();
            ILoginController loginController = new LoginController(loginWindow, MainWindow);
            loginWindow.SetController(loginController);
            OpenChildForm((Form)loginWindow);
        }

        void OpenChildForm(Form childForm)
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
            childForm.Location = new Point((mainWindow.MainPanel.Width - childForm.Width) / 2, (mainWindow.MainPanel.Height - childForm.Height) / 2);

            //childForm.Left = (this.Height - childForm.Width) / 2;
            //childForm.Top = (this.Height - childForm.Height) / 2;
            mainWindow.MainPanel.Controls.Add(childForm);
            mainWindow.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void IMainController.OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                activeForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Anchor = AnchorStyles.None;
            //childForm.Location = new Point((mainWindow.MainPanel.Width - childForm.Width) / 2, (mainWindow.MainPanel.Height - childForm.Height) / 2);

            //childForm.Left = (this.Height - childForm.Width) / 2;
            //childForm.Top = (this.Height - childForm.Height) / 2;
            mainWindow.MainPanel.Controls.Add(childForm);
            mainWindow.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
