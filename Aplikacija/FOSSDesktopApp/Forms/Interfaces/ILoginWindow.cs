using FOSSDesktopApp.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Forms.Interfaces
{
    interface ILoginWindow
    {
        string TbxOrgUserName { get; set; }
        string TbxOrgPassword { get; set; }
        string TbxAdmEnterKey { get; set; }
    
        void SetController(ILoginController loginController);
        void Hide();
    }
}
