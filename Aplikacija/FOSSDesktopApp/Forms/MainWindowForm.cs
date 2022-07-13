using FOSSDesktopApp.Controllers.Interfaces;
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
    partial class MainWindowForm : Form, IMainWindow
    {
        private IMainController mainController;

        public MainWindowForm()
        {
            InitializeComponent();
        }

        #region Properties

        public Panel MainPanel
        {
            get { return this.panel1; }
            set { }
        }

        #endregion

        #region EventHandlers

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            mainController.openLoginForm();

        }

        #endregion

        #region Metods

        public void OpenChildForm(Form Window)
        {
            this.mainController.OpenChildForm(Window);
        }

        public void setActiveController(IController controller)
        {
            mainController.ActiveController = controller;
        }

        public void setActiveWindow(Form window)
        {
            mainController.ActiveForm = window;
        }

        public void SetController(IMainController mainController)
        {
            this.mainController = mainController;
        }

        public void openLoginForm()
        {
            mainController.openLoginForm();
        }


        #endregion

    }
}