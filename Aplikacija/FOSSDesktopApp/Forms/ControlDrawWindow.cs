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
    public partial class ControlDrawWindow : Form, IControlDrawWindow
    {

        #region Attributes 
        
        private IControlDrawController controlDrawController;
        private int groupNumber;
        private int teamPerGroup;
        private int numOfWinnerPerGroup;
        private int numOfTeamsInCompetition;
        #endregion

        #region Properties

        public IControlDrawController ControlDrawController
        {
            get { return this.controlDrawController; }
        }

        public int GroupNumber 
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; } 
        }

        public int TeamPerGroup 
        {
            get { return this.teamPerGroup; }
            set { this.teamPerGroup = value; } 
        }

        public void UnableButton()
        {
            this.btnStartDraw.Enabled = false;
        }

        public int NumOfWinnerPerGroup
        {
            get { return this.numOfWinnerPerGroup; }
            set { this.numOfWinnerPerGroup = value; }
        }

        public int NumOfTeamsInCompetition
        {
            get { return this.numOfTeamsInCompetition; }
            set { this.numOfTeamsInCompetition = value; }
        }
        public string LblTeamNumber
        {
            get { return this.lblTeamNumber.Text; }
            set { this.lblTeamNumber.Text = value; }
        }

        public ComboBox CbxGroupNumber
        {
            get { return this.cbxGroupNumber; }
        }
        
        public ComboBox CbxTeamsPerGroup
        {
            get { return this.cbxTeamsPerGroup; }
        }

        public ComboBox CbxNumOfWinnerPerGroup
        {
            get { return this.cbxNumOfWinnerPerGroup; }
        }

        #endregion

        #region Constructors

        public ControlDrawWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region SetControls

        public void SetTeamNumberLabel(string number)
        {
            this.NumOfTeamsInCompetition = Int32.Parse(number);
            this.LblTeamNumber = number;
        }

        public void SetCbxGroupNumber()
        {
            this.CbxGroupNumber.Items.Clear();
            int i;
            for(i = 2;i<=16;i*=2)
            CbxGroupNumber.Items.Add(i);
            i = i / 2;
            this.GroupNumber = i;
        }

        public void SetCbxTeamsPerGroup()
        {
            this.CbxTeamsPerGroup.Items.Clear();
            int i;
            for (i = 3;i<=8;i++)
                CbxTeamsPerGroup.Items.Add(i);

            i--;
            this.teamPerGroup = i;
        }

        public void SetCbxNumOfWinnerPerGroup(int groupNumber)
        {
            
            if (String.IsNullOrEmpty(groupNumber.ToString()) == true)
            {
                MessageBox.Show("Morate najpre selektovati broj ekipa po grupi!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.CbxNumOfWinnerPerGroup.Items.Clear();
                int i;
                this.NumOfWinnerPerGroup = this.TeamPerGroup / 2;
                if (this.NumOfWinnerPerGroup % 2 != 0)
                {
                    this.NumOfWinnerPerGroup++;
                }
                    for (i = 1; i <= this.numOfWinnerPerGroup; i*=2)
                    CbxNumOfWinnerPerGroup.Items.Add(i);

                i/=2;
            }
        }

        public bool ValidateInputs(int groupNumber, int teamPerGroup)
        {
            

            int brojMogucihEkipa = GroupNumber * TeamPerGroup;
            if(brojMogucihEkipa != this.NumOfTeamsInCompetition)
            {
                MessageBox.Show("Morate izabrati tacan broj grupa i ekipa po grupi u odnosu na broj prijavljenih ekipa, promenite format!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Validacija uspešna! Poklapa Vam se broj selektovanih parametara sa broj prijavljenih klubova!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        #endregion

        #region SetController

        public void setController(IControlDrawController controlDrawControler)
        {
            this.controlDrawController = controlDrawControler;
        }

        #endregion

        #region EventHandlers

        private void btnValidateFormat_Click(object sender, EventArgs e)
        {
            if (rdbCombinedPhase.Checked != true)
               MessageBox.Show("Morate selektovati kombinovani format!");
            
            string GroupNumber = cbxGroupNumber.Text;
            string TeamsPerGroup = CbxTeamsPerGroup.Text;
            if(!ValidateString(GroupNumber) || !ValidateString(TeamsPerGroup))
            {
                return;
            }

            this.GroupNumber = Int32.Parse(cbxGroupNumber.Text);
            this.TeamPerGroup = Int32.Parse(CbxTeamsPerGroup.Text);
            ValidateInputs(this.GroupNumber, this.TeamPerGroup);
        }

        private bool ValidateString(string text)
        {
            if (String.IsNullOrEmpty(text) == true )
            {
                MessageBox.Show("Morate postaviti kontrole!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnStartDraw_Click(object sender, EventArgs e)
        {

            if (rdbDrawPhase.Checked == true)
            {
                if(ValidateDrawInput())
                this.ControlDrawController.StartCupSystem();
            }
            else if (rdbGroupPhase.Checked == true)
            {
                if(this.numOfTeamsInCompetition < 3)
                {
                    MessageBox.Show("Morate imati najmanje 3 kluba u sistemu!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.ControlDrawController.StartDraw(1, this.numOfTeamsInCompetition, 1);
            }
            else if (rdbCombinedPhase.Checked == true)
            {
                string GroupNumber = cbxGroupNumber.Text;
                string TeamsPerGroup = CbxTeamsPerGroup.Text;
                string WinnerPerGroup = CbxNumOfWinnerPerGroup.Text;
                if (!ValidateString(GroupNumber) || !ValidateString(TeamsPerGroup) || !ValidateString(WinnerPerGroup))
                {
                    return;
                }
                this.GroupNumber = Int32.Parse(GroupNumber);
                this.TeamPerGroup = Int32.Parse(TeamsPerGroup);
                this.NumOfWinnerPerGroup = Int32.Parse(WinnerPerGroup);
                if (!ValidateInputs(this.GroupNumber, this.TeamPerGroup))
                {
                    return;
                }

                this.ControlDrawController.StartDraw(this.GroupNumber, this.TeamPerGroup, this.NumOfWinnerPerGroup);
            }
            

        }

        private bool ValidateDrawInput()
        {
            int index = 1;
            bool flag = false;
            for (index = 2; index <= this.NumOfTeamsInCompetition; index *= 2)
            {
                if(this.NumOfTeamsInCompetition == index)
                {
                    flag = true;
                    break;
                }
            }
            if(!flag)
                MessageBox.Show("Broj klubova nije odgovarajuci, mora da bude 2^n!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return flag;
        }


        #endregion


        private void cbxTeamsPerGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TeamPerGroup = Int32.Parse(CbxTeamsPerGroup.Text);
          
            this.SetCbxNumOfWinnerPerGroup(this.TeamPerGroup);
        }

        private void rdbTreePhase_CheckedChanged(object sender, EventArgs e)
        {
            TurnOffVisibility();
        }

        private void rdbCombinedPhase_CheckedChanged(object sender, EventArgs e)
        {
            TurnOnVisibility();
        }

        private void rdbGroupPhase_CheckedChanged(object sender, EventArgs e)
        {
            TurnOffVisibility();

        }

        private void TurnOffVisibility()
        {
            this.cbxGroupNumber.Enabled = false;
            this.cbxNumOfWinnerPerGroup.Enabled = false;
            this.cbxTeamsPerGroup.Enabled = false;
            this.btnValidateFormat.Enabled = false;
        }

        private void TurnOnVisibility()
        {
            this.cbxGroupNumber.Enabled = true;
            this.cbxNumOfWinnerPerGroup.Enabled = true;
            this.cbxTeamsPerGroup.Enabled = true;
            this.btnValidateFormat.Enabled = true;
        }

        private void TurnOffStartDraw()
        {
            this.btnStartDraw.Enabled = false;
        }
    }
}
