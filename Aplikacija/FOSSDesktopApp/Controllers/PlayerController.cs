using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers
{
    class PlayerController : IPlayerController
    {
        private readonly IPlayerWindow playerWindow;

        public PlayerController(IPlayerWindow playerWindow)
        {
            this.playerWindow = playerWindow;
        }
    }
}
