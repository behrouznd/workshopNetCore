using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Data;
using Workshop2.Interfaces;
using Workshop2.Models;

namespace Workshop2.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly SchoolContext Database;

        public LogRepository(SchoolContext context)
        {
            this.Database = context;
        }

        public void CreateLog(string controller, string actionName, string userId)
        {
            Database.logsDatas.Add(new LogsData { ActionName = actionName, ControllerName = controller, UserId = userId, CreDate = DateTime.Now });
            Database.SaveChanges();
        }
    }
}
