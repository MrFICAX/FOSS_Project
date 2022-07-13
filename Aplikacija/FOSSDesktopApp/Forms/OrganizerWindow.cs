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
    public partial class OrganizerWindow : Form, IOrganizerWindow
    {

        #region Attributes

        private IOrganizerController organizerController;

        #endregion

        #region Properties

        public string LblUserName
        {
            get { return this.lblUserName.Text; }
            set { this.lblUserName.Text = value; }
        }

        public string LblDateOfLogin
        {
            get { return this.lblDateOfLogin.Text; }
            set { this.lblDateOfLogin.Text = value; }
        }

        public string LblNameOfSelectedCompetition
        {
            get { return this.lblNameOfSelectedCompetition.Text; }
            set { this.lblNameOfSelectedCompetition.Text = value; }
        }

        public string LblLocationOfSelectedCompetition
        {
            get { return this.lblLocationOfSelectedCompetition.Text; }
            set { this.lblLocationOfSelectedCompetition.Text = value; }
        }

        public string LblDateOfSelectedCompetition
        {
            get { return this.lblDateOfSelectedCompetition.Text; }
            set { this.lblDateOfSelectedCompetition.Text = value; }
        }

        public ComboBox CbxSelectCompetition
        {
            get { return this.cbxSelectCompetition; }           
        }

        public Panel OrganiserPanel
        {
            get { return this.panel1; }
            set { }
        }

        public string LblWinnerOfSelectedCompetition
        {
            get => this.lblWinnerOfCompetition.Text;
            set => this.lblWinnerOfCompetition.Text = value;
        }

        #endregion

        #region Constructors

        public OrganizerWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region SetController

        public void SetController(IOrganizerController organizerController)
        {
            this.organizerController = organizerController;
        }

        #endregion

        #region EventHandlers

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selected = this.cbxSelectCompetition.GetItemText(this.cbxSelectCompetition.SelectedItem);
            string selectedCompetition = cbxSelectCompetition.Text;
            organizerController.LoadActiveCompetition(selectedCompetition);
        }

        private void btnOverviewCompetition_Click(object sender, EventArgs e)
        {
            //PROBATI I JEDNO I DRUGO- KAO PARAMETAR METODE PROSLEDITI DOBIJENI STRING
            //string selected = this.cbxSelectCompetition.GetItemText(this.cbxSelectCompetition.SelectedItem);
            //string selected2 = cbxSelectCompetition.Text;
            string selectedCompetition = cbxSelectCompetition.Text;
            organizerController.OpenCompetitionWindow(selectedCompetition);
        }

        private void btnAddNewCompetition_Click(object sender, EventArgs e)
        {
            organizerController.OpenAddNewCompetitionWindow();
        }

        private void btnAddAdministrator_Click(object sender, EventArgs e)
        {
            organizerController.OpenAddAdministratorWindow();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            organizerController.OpenLoginForm();
        }

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            organizerController.OpenAddNewClub();
        }

        private void btnAddReferee_Click(object sender, EventArgs e)
        {
            organizerController.OpenAddNewReferee();
        }

        private void btnControlDraw_Click(object sender, EventArgs e)
        {
            string selectedCompetition = cbxSelectCompetition.Text;
            organizerController.OpenControlDraw(selectedCompetition);
        }

        #endregion
    }
}
