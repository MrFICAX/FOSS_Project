using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace FOSSDesktopApp.Engine
{
    interface IDataBaseCommunication
    {
    

        Task<bool> LoadFromDB();
        Task<bool> SaveToDB();
    }
}
