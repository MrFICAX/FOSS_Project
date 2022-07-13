using FOSSDesktopApp.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface IPlayerWindow
    {
        void SetController(IPlayerController playerController);
    }
}
