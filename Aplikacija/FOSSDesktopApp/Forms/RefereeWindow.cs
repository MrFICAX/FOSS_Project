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
    public partial class RefereeWindow : Form, IRefereeWindow
    {
        #region Attributes

        private IRefereeController refereeController;

        #endregion

        #region Constructors

        public RefereeWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public string RefereeName
        {
            get => this.tbxRefereeName.Text;
            set => this.tbxRefereeName.Text = value;
        }

        public string RefereeSurname
        {
            get => this.tbxRefereeSurname.Text;
            set => this.tbxRefereeSurname.Text = value;
        }
        public DataGridView DgwRefereeList
        {
            get => this.dgwRefereeList;
            set => this.dgwRefereeList = value;
        }

        public int RefereeQuality
        {
            get { return (int) this.nudRefereeQuality.Value; }
        }



        #endregion

        #region SetController

        public void SetController(IRefereeController refereeController)
        {
            this.refereeController = refereeController;
        }

        #endregion

        #region Validation

        public bool ValidateRefereeInput(string RefereeName, string RefereeSurname, int RefereeQuality)
        {
            if (String.IsNullOrEmpty(RefereeName) == true || String.IsNullOrEmpty(RefereeSurname) == true || RefereeQuality < 0)
            {
                MessageBox.Show("Niste uneli podatke o sudiji!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

        #region SetControls

        public void ClearRefereInput()
        {
            this.RefereeName = "";
            this.RefereeSurname = "";
        }

        public void SetDgwRefereeList(List<Referee> referees)
        {
            string[] row;

            this.DgwRefereeList.Columns.Clear();
            this.DgwRefereeList.Rows.Clear();

            this.DgwRefereeList.ColumnCount = 3;
            if (this.DgwRefereeList.ColumnCount == 0)
                return;
            this.DgwRefereeList.Columns[0].Name = "IME";
            this.DgwRefereeList.Columns[1].Name = "PREZIME";
            this.DgwRefereeList.Columns[2].Name = "REGISTARSKI BROJ";

            int index;
            for (index = 0; index < referees.Count; index++)
            {
                Referee tmpReferee = referees.ElementAt(index);
                row = new string[] { tmpReferee.PersonName, tmpReferee.Surname, tmpReferee.Quality.ToString() }; 

                this.DgwRefereeList.Rows.Add(row);
            }
        }

        #endregion

        private void btnAddNewReferee_Click(object sender, EventArgs e)
        {
            string RefereeName = this.RefereeName;
            string RefereeSurname = this.RefereeSurname;
            int RefereeQuality = this.RefereeQuality;

            if (ValidateRefereeInput(RefereeName, RefereeSurname, RefereeQuality))
                this.refereeController.AddNewReferee(RefereeName, RefereeSurname, RefereeQuality);
        }

    }
}
