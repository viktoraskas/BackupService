using BackupService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Interfaces
{
    internal class DatabaseService : IDatabases
    {
        private string Server = "localhost";
        private int ServerPort = 1433;
        private string UserName = "sa";
        private string Password = "sa2526";
        private bool LoginSecure = false;



        public DatabaseService()
        {

        }
        public Task<Database> BackupDatabases(Database database)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Database>> GetDatabasesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Database> IntegrityCheck(Database database)
        {
            throw new NotImplementedException();
        }
    }
}
