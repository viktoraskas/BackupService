using BackupService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Interfaces
{
    internal interface IDatabases
    {
        public Task<IEnumerable<Database>> GetDatabasesAsync();
        public Task<Database> BackupDatabases(Database database);
        public Task<Database> IntegrityCheck(Database database);
    }
}
