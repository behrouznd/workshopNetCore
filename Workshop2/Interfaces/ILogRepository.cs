using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop2.Interfaces
{
    public interface ILogRepository
    {
        void CreateLog(string controller, string actionName, string userId);
    }
}
