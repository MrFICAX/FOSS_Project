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
    public partial class TeamWindow : Form, ITeamWindow
    {
        private ITeamController teamController;
        public DataGridView DgwTeams{ get =>this.dgwTeams; set { } }
        public DataGridView DgwPlayers { get => this.dgwPlayers; set { } }

        public TeamWindow()
        {
            InitializeComponent();
        }

        public void SetController(ITeamController teamController)
        {
            this.teamController = teamController;  
        }

        private void dgwTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string selectedTeam = dgwTeams.SelectedRows[0].Cells["IME KLUBA"].Value.ToString();
                teamController.SetPlayers(selectedTeam);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste selektovali klub!");
            }
        }
    }
}
