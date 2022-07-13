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
    class ManageMatchesController : IManageMatchesController
    {
        private ManageMatchesWindow mmw;
        private Competition activeCompetition;
        private AdministratorController admController;
        

        public Competition ActiveCompetition
        {
            get { return this.activeCompetition; }
            set
            { 
                this.activeCompetition = value;
                this.SetDgwUnplayedMatches();
                this.SetDgwPlayedMatches();
            }
        }

        internal AdministratorController AdmController { get => admController; set => admController = value; }

        public ManageMatchesController(ManageMatchesWindow mmw, Competition activeCompetition, AdministratorController admC)
        {
            this.mmw = mmw;
            this.ActiveCompetition = activeCompetition;
            admController = admC;

        }

        public void SetDgwUnplayedMatches()
        {
            this.mmw.SetDgwUnPlayedMatches(this.activeCompetition.MatchList);
        }

        public void SetDgwPlayedMatches()
        {
            this.mmw.SetDgwPlayedMatches(this.ActiveCompetition.MatchList);
        }

        public void OpenMatchWindow(string selectedTeam1, string selectedTeam2)
        {
           Match selectedMatch = this.ActiveCompetition.FindMatch(selectedTeam1, selectedTeam2);
            if(selectedMatch == null)
            {
                MessageBox.Show("Greska kod izbora meca!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var frm = new MatchWindow(selectedMatch, this.ActiveCompetition);

            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK) 
            {
                this.ActiveCompetition.finishMatch(selectedMatch);
                SetDgwUnplayedMatches();
                SetDgwPlayedMatches();
                if (this.activeCompetition.Winner != null)
                    AdmController.SetCompetitionLabels();
            }
        }
    }
}
