using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Forms;
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

namespace FOSSDesktopApp
{
    public partial class LoginWindow : Form, ILoginWindow
    {
        #region Attributes

        private ILoginController loginController;

        #endregion

        #region Properties

        public string TbxOrgUserName
        {
            get { return this.tbxOrgUserName.Text; }
            set { }
        }

        public string TbxOrgPassword
        {
            get { return this.tbxOrgPassword.Text; }
            set { }
        }

        public string TbxAdmEnterKey
        {
            get { return this.tbxAdmKey.Text; }
            set { }
        }

        #endregion

        #region Constructors

        public LoginWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void Button1_Click(object sender, EventArgs e)
        {
            loginController.LoginButtonClicked();



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            loginController.EnterKeyButtonClicked();
        }

        #endregion

        #region Methods

        public void OpenThisWindow()
        {
            this.Show();
        }

        public void SetController(ILoginController loginController)
        {
            this.loginController = loginController;
        }

        #endregion

        private void btnAddNewOrganizer_Click(object sender, EventArgs e)
        {
            this.loginController.AddNewOrganizerClicked();
        }
    }
}
