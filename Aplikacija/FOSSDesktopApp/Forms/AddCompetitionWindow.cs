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
    public partial class AddCompetitionWindow : Form, IAddCompetitionWindow
    {
        #region Attributes

        private IAddCompetitionController addCompetitionController;

        #endregion

        #region Constructors

        public AddCompetitionWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Attributes

        public string CompetitionName
        {
            get => this.tbxCompetitionName.Text;
            set => this.tbxCompetitionName.Text = value;
        }

        public string CompetitionLocation
        {
            get => this.tbxCompetitionLocation.Text;
            set => this.tbxCompetitionLocation.Text = value;
        }

        public DateTime CompetitionDate
        {
            get => dtpCompetitionDate.Value;
        }

        public DataGridView DgwTeams
        {
            get => this.dgwTeams;
        }
        public DataGridView DgwAllTeams
        {
            get => this.dgwAllTeams;
            set => this.dgwAllTeams = value;
        }

        #endregion

        #region SetControls

        public void SetDgwTeams(Team[] TeamList)
        {
            string[] row;

            this.DgwTeams.Columns.Clear();
            this.DgwTeams.Rows.Clear();

            this.DgwTeams.ColumnCount = 4;
            if (this.DgwTeams.ColumnCount == 0)
                return;
            this.DgwTeams.Columns[0].Name = "IME KLUBA";
            this.DgwTeams.Columns[1].Name = "TRENER";
            this.DgwTeams.Columns[2].Name = "BROJ IGRAČA";
            this.DgwTeams.Columns[3].Name = "KAPITEN";


            int index;
            for (index = 0; index < TeamList.Length; index++)
            {
                Team tmpTeam = TeamList[index];
                Player capitain = tmpTeam.Capitain;
                if (capitain == null)
                    row = new string[] { tmpTeam.ClubName, tmpTeam.Trainer.PersonName + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), "Ne postoji kapiten" };
                else
                    row = new string[] { tmpTeam.ClubName, tmpTeam.Trainer.PersonName + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), tmpTeam.Capitain.PersonName + " " + tmpTeam.Capitain.Surname };

                this.DgwTeams.Rows.Add(row);
            }
        }

        public void SetDgwAllTeams(TeamList TeamList)
        {
            string[] row;

            this.DgwAllTeams.Columns.Clear();
            this.DgwAllTeams.Rows.Clear();

            this.DgwAllTeams.ColumnCount = 4;
            if (this.DgwAllTeams.ColumnCount == 0)
                return;
            this.DgwAllTeams.Columns[0].Name = "IME KLUBA";
            this.DgwAllTeams.Columns[1].Name = "TRENER";
            this.DgwAllTeams.Columns[2].Name = "BROJ IGRAČA";
            this.DgwAllTeams.Columns[3].Name = "KAPITEN";


            int index;
            for (index = 0; index < TeamList.getNumberOfTeams(); index++)
            {
                Team tmpTeam = TeamList.returnByIndex(index);
                Trainer tmpTrainer = tmpTeam.Trainer;
                Player capitain = tmpTeam.Capitain;
                if (capitain == null || tmpTrainer == null)
                    row = new string[] { tmpTeam.ClubName, "Ne postoji trener ili kapiten", tmpTeam.TeamSize.ToString(), "Ne postoji trener ili kapiten" };
                else
                    row = new string[] { tmpTeam.ClubName, tmpTeam.Trainer.PersonName + " " + tmpTeam.Trainer.Surname, tmpTeam.TeamSize.ToString(), tmpTeam.Capitain.PersonName + " " + tmpTeam.Capitain.Surname };

                this.DgwAllTeams.Rows.Add(row);
            }
        }

        #endregion

        #region Validations

        private bool ValidateCompetitionInput(string competitionName, string competitionLocation)
        {
            if (String.IsNullOrEmpty(competitionName) == true || String.IsNullOrEmpty(competitionLocation) == true)
            {
                MessageBox.Show("Niste uneli podatke o takmičenju!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!dtpCompetitionDate.Checked)
            {
                MessageBox.Show("Morate izabrati datum takmičenja.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }
            if (DateTime.Compare(DateTime.Now, dtpCompetitionDate.Value) >= 0)
            {
                MessageBox.Show("Morate uneti datum takmičenja u budućnosti.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }
            return true;
        }

        #endregion

        #region SetController

        public void SetController(IAddCompetitionController cc)
        {
            addCompetitionController = cc;
        }

        #endregion

        #region EventHandlers

        private void BtnAddNewClub_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedTeam = DgwAllTeams.SelectedRows[0].Cells["IME KLUBA"].Value.ToString();
                this.addCompetitionController.AddTeam(selectedTeam);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati klub!");
            }
        }

        private void btnAddCompetition_Click(object sender, EventArgs e)
        {
            string CompetitionName = this.CompetitionName;
            string CompetitionLocation = this.CompetitionLocation;
            DateTime CompetitionDate = this.CompetitionDate;
            if (ValidateCompetitionInput(CompetitionName, CompetitionLocation))
                this.addCompetitionController.AddNewCompetition(CompetitionName, CompetitionLocation, CompetitionDate);
        }

        private void btnRemoveSelectedClub_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedTeam = DgwTeams.SelectedRows[0].Cells["IME KLUBA"].Value.ToString();
                this.addCompetitionController.RemoveTeam(selectedTeam);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati klub!");
            }
        }

        #endregion
    }
}
