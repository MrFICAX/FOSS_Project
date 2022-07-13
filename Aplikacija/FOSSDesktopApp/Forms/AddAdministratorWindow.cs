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
    public partial class AddAdministratorWindow : Form, IAddAdministratorWindow
    {
        #region Attributes



        public IAddAdministratorController addAdministratorController;

        #endregion

        #region Properties

        public string AdministratorName
        {
            get => this.tbxName.Text;
            set => this.tbxName.Text = value;
        }

        public string AdministratorSurname
        {
            get => this.tbxSurname.Text;
            set => this.tbxSurname.Text = value;
        }

        public string AdministratorEnterkey
        {
            get => this.tbxEnterkey.Text;
            set => this.tbxEnterkey.Text = value;
        }

        public DataGridView DgwAdminstrators 
        {
            get => this.dgwAdministratorList;
            set => this.dgwAdministratorList = value; 
        }

        public DataGridView DgwAdmininstratorsCompetitionList 
        { 
            get => this.dgwAdministratorsCompetitionLIst;
            set => this.dgwAdministratorsCompetitionLIst = value; 
        }

        #endregion

        #region Constructors

        public AddAdministratorWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region SetController

        internal void SetController(IAddAdministratorController mc)
        {
            addAdministratorController = mc;
        }

        void IAddAdministratorWindow.SetController(IAddAdministratorController ac)
        {
            addAdministratorController = ac;
        }

        #endregion

        #region Validation

        private bool ValidateSelection(string selectedAdministrator, string selectedCompetition)
        {
            if (String.IsNullOrEmpty(selectedAdministrator) == true || String.IsNullOrEmpty(selectedCompetition) == true)
            {
                MessageBox.Show("Niste uneli ime kluba!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

        #region SetControls

        internal void SetDgwAdministrators(List<Administrator> adminList)
        {
            string[] row;
            //  this.competitionWindow.DgwTeams.DataSource = this.SelectedCompetition.TeamList;

            this.dgwAdministratorList.Columns.Clear();
            this.dgwAdministratorList.Rows.Clear();

            this.dgwAdministratorList.ColumnCount = 2;
            if (this.dgwAdministratorList.ColumnCount == 0)
                return;
            this.dgwAdministratorList.Columns[0].Name = "IME";
            this.dgwAdministratorList.Columns[1].Name = "PREZIME";
           // this.dgwAdministratorList.Columns[2].Name = "ENTERKEY";

            int index;
            for (index = 0; index < adminList.Count; index++)
            {
                Administrator tmpAdmin = adminList.ElementAt(index);
                row = new string[] { tmpAdmin.PersonName, tmpAdmin.Surname }; //, tmpAdmin.EnterKey};

                this.dgwAdministratorList.Rows.Add(row);
            }
        }

        internal void SetDgwAdministratorsCompetitionList(List<Competition> competitions)
        {
            string[] row;
            //  this.competitionWindow.DgwTeams.DataSource = this.SelectedCompetition.TeamList;

            this.dgwAdministratorsCompetitionLIst.Columns.Clear();
            this.dgwAdministratorsCompetitionLIst.Rows.Clear();

            this.dgwAdministratorsCompetitionLIst.ColumnCount = 3;
            if (this.dgwAdministratorsCompetitionLIst.ColumnCount == 0)
                return;
            this.dgwAdministratorsCompetitionLIst.Columns[0].Name = "NAZIV";
            this.dgwAdministratorsCompetitionLIst.Columns[1].Name = "LOKACIJA";
            this.dgwAdministratorsCompetitionLIst.Columns[2].Name = "DATUM";

            int index;
            for (index = 0; index < competitions.Count; index++)
            {
                Competition tmpCompetition = competitions.ElementAt(index);
                row = new string[] { tmpCompetition.Name, tmpCompetition.Location, tmpCompetition.StartDate.ToShortDateString() };
                this.dgwAdministratorsCompetitionLIst.Rows.Add(row);
            }
        }

        public void ClearDgwAdministratorsCompetitionList()
        {
            this.dgwAdministratorsCompetitionLIst.Rows.Clear();
        }

        public void InputComboBox(CompetitionList competitionList)
        {
            this.cbxCompetitions.Items.Clear();
            //OVO ZAKOMENTARISATI KADA SE TESTIRA PRIBAVLJANJE IZ BAZE
            //competitionList = this.activeOrganizer.Events; //OVU LINIJU ZAKOMENTARISATI KADA TESTIRAMO PRIBAVLJANJE TAKMICENJA IZ BAZE!!!

            //*/

            competitionList.EventList.ForEach(el =>
            this.cbxCompetitions.Items.Add(el.Name)
            );
        }

        public void ClearAdministratorControls()
        {
            this.AdministratorName = "";
            this.AdministratorSurname = "";
            this.AdministratorEnterkey = "";
        }

        #endregion

        #region Methods

        #endregion

        #region EventHandlers

        private void BtnAddNewAdministrator_Click(object sender, EventArgs e)
        {
            addAdministratorController.AddNewAdministrator();
        }


        private void BtnDeleteAdministrator_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedAdministrator = this.DgwAdminstrators.SelectedRows[0].Cells["IME"].Value.ToString();
                    addAdministratorController.DeleteAdministrator(selectedAdministrator);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate da izaberete administratora!");
            }
        }

        private void DgwAdministratorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedAdministrator = this.DgwAdminstrators.SelectedRows[0].Cells["IME"].Value.ToString();
            this.addAdministratorController.SelectedAdministratorClicked(selectedAdministrator);
        }

        #endregion

        private void btnAddCompetition_Click(object sender, EventArgs e)
        {
            try
            {

                string selectedAdministrator = this.DgwAdminstrators.SelectedRows[0].Cells["IME"].Value.ToString();
                string selectedCompetition = cbxCompetitions.Text;
                if(ValidateSelection(selectedAdministrator, selectedCompetition))
                     this.addAdministratorController.AddCompetitionToAdministrator(selectedAdministrator, selectedCompetition);
            }
            catch(Exception)
            {
                MessageBox.Show("Morate da izaberete sudiju!");
            }

        }


        private void btnDeleteCompetition_Click(object sender, EventArgs e)
        {
            try
            {

                string selectedAdministrator = this.DgwAdminstrators.SelectedRows[0].Cells["IME"].Value.ToString();
                string selectedCompetition = this.dgwAdministratorsCompetitionLIst.SelectedRows[0].Cells["NAZIV"].Value.ToString();

                if (ValidateSelection(selectedAdministrator, selectedCompetition))
                    this.addAdministratorController.DeleteCompetitionOfAdministrator(selectedAdministrator, selectedCompetition);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate da izaberete takmicenje!");

            }

        }

    }
}
