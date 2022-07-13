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
    public partial class AdministratorWindow : Form , IAdministratorWindow
    {
        #region Attributes

        private IAdministratorController administratorController;

        #endregion

        #region Properties

        public Panel AdministratorPanel 
        {
            get => pnlAdministrator; 
        }

        public string LblUserName 
        { 
            get => this.lblUserName.Text; 
            set => this.lblUserName.Text = value; 
        }

        public string LblDateOfLogin 
        { 
            get => this.lblDateOfLogin.Text; 
            set => this.lblDateOfLogin.Text = value; 
        }

        public string LblNameOfSelectedCompetition 
        { 
            get => this.lblNameOfSelectedCompetition.Text; 
            set => this.lblNameOfSelectedCompetition.Text = value; 
        }
        
        public string LblLocationOfSelectedCompetition 
        { 
            get => this.lblLocationOfSelectedCompetition.Text; 
            set => this.lblLocationOfSelectedCompetition.Text = value; 
        }
        
        public string LblDateOfSelectedCompetition 
        { 
            get => this.lblDateOfSelectedCompetition.Text; 
            set => this.lblDateOfSelectedCompetition.Text = value; 
        }

        public ComboBox CbxSelectCompetition 
        {
            get { return this.cbxSelectCompetition; }
        }

        public string LblWinnerOfSelectedCompetition 
        {
            get => this.lblWinnerOfCompetition.Text; 
            set => this.lblWinnerOfCompetition.Text = value; 
        }

        #endregion

        #region Constructors

        public AdministratorWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region SetController

        public void SetController(IAdministratorController administratorController)
        {
            this.administratorController = administratorController;
        }

        #endregion

        #region SetControls

        public void SetCbxCompetitionControls(List<Competition> eventList)
        {
            throw new NotImplementedException();
        }

        public void SetCompetitionLabelControls(Competition selectedCompetition)
        {
            this.LblNameOfSelectedCompetition = selectedCompetition.Name;
            this.LblLocationOfSelectedCompetition = selectedCompetition.Location;
            this.LblDateOfSelectedCompetition = selectedCompetition.StartDate.ToShortDateString();
        }

        #endregion

        #region EventHandlers

        private void btnCompetitionOverview_Click(object sender, EventArgs e)
        {
            string selectedCompetition = cbxSelectCompetition.Text;

            administratorController.OpenCompetitionWindow(selectedCompetition);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            administratorController.OpenLoginForm();
        }

        private void btnTeamOverview_Click(object sender, EventArgs e)
        {
            string selectedCompetition = cbxSelectCompetition.Text;
            administratorController.OpenTeamsWindow(selectedCompetition);
        }

        private void btnManageMatches_Click(object sender, EventArgs e)
        {
            string selectedCompetition = cbxSelectCompetition.Text;

            administratorController.OpenManageMatchesWindow(selectedCompetition);
        }

        #endregion

        private void cbxSelectCompetition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompetition = cbxSelectCompetition.Text;
            administratorController.LoadActiveCompetition(selectedCompetition);
        }
    }
}
