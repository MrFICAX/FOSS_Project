using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface IControlDrawWindow
    {
        string LblTeamNumber { get; set; }
        ComboBox CbxGroupNumber { get; }
        ComboBox CbxTeamsPerGroup { get; }
        ComboBox CbxNumOfWinnerPerGroup { get; }
    }
}
