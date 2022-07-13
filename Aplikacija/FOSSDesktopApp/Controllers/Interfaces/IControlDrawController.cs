using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Controllers.Interfaces
{
    public interface IControlDrawController
    {
        void StartDraw(int groupNumber, int teamPerGroup, int numOfWinnerPerGroup);
        void StartCupSystem();
    }
}
