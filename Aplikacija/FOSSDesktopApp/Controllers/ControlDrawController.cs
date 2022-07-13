using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Controllers
{
    class ControlDrawController : IControlDrawController
    {
        private readonly ControlDrawWindow cw;
        private Competition activeCompetition;

        public Competition ActiveCompetition 
        {
            get { return this.activeCompetition; }
            set 
            {
                this.activeCompetition = value;
                this.cw.SetTeamNumberLabel(this.ActiveCompetition.TeamList.Length.ToString());
            }
        }

        public ControlDrawController(ControlDrawWindow cw, Competition activeCompetition)
        {
            this.cw = cw;
            this.ActiveCompetition = activeCompetition;
            SetControls();
            CheckIfDrawIsPossible();
        }

        private void CheckIfDrawIsPossible()
        {
            if(this.ActiveCompetition.MatchList.Length > 0)
            {
                this.cw.UnableButton();
            }
        }

        public void SetControls()
        {
            this.cw.SetCbxGroupNumber();
            //this.cw.SetCbxNumOfWinnerPerGroup();
            this.cw.SetCbxTeamsPerGroup();
        }

        public void StartDraw(int groupNumber, int teamPerGroup, int numOfWinnerPerGroup)
        {
            if(this.ActiveCompetition.MatchList.Length == 0)
                this.ActiveCompetition.startGroupPhase(groupNumber, teamPerGroup, numOfWinnerPerGroup);
            else
            {
                MessageBox.Show("Za ovaj mec je vec kreira zrebni sistem!");
            }
        }

        public void StartCupSystem()
        {
            if (this.ActiveCompetition.MatchList.Length == 0)
                this.ActiveCompetition.startDrawPhase();
            else
            {
                MessageBox.Show("Za ovaj mec je vec kreira zrebni sistem!");
            }

        }
    }
}
