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
    public partial class PlayerWindow : Form, IPlayerWindow
    {
        private IPlayerController playerController;

        public PlayerWindow()
        {
            InitializeComponent();
        }

        public void SetController(IPlayerController playerController)
        {
            this.playerController = playerController;
        }
    }
}
