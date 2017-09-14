using InnovationApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnovationWebAPICore
{
    interface IUserAPI : IDisposable
    {
        List<User> GetUsers();
    }
}
