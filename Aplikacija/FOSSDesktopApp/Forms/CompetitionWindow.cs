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
    public partial class CompetitionWindow : Form, ICompetitionWindow
    {
        private ICompetitionController competitionController;


        public DataGridView DgwTeams
        { 
            get => this.dgwTeams; 
        }

        public DataGridView DgwMatches 
        { 
            get => this.dgwMatches; 
        }

        public DataGridView DgwPlayers
        {
            get => this.dgwPlayers;
        }

        public CompetitionWindow()
        {
            InitializeComponent();
        }

        public void SetController(ICompetitionController competitionController)
        {
            this.competitionController = competitionController;
        }


        private void dgwTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string selectedTeam = dgwTeams.SelectedRows[0].Cells["IME KLUBA"].Value.ToString();
                competitionController.SetPlayers(selectedTeam);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste selektovali klub!");
            }
        }

    }
}
