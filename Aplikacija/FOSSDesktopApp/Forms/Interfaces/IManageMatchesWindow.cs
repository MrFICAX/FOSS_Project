using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface IManageMatchesWindow
    {
        DataGridView DgwUnplayedMatches { get; set; }
        DataGridView DgwPlayedMatches { get; set; }
    }
}
