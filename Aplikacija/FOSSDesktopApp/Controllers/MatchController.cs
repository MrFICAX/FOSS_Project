using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers
{
    class MatchController : IMatchController
    {
        private IMatchWindow matchWindow;

        public MatchController(IMatchWindow matchWindow)
        {
            this.matchWindow = matchWindow;
        }
    }
}
