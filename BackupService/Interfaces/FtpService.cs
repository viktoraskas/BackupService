using BackupService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Interfaces
{
    internal class FtpService : IFtp
    {
        public Task<Database> Upload(Database database)
        {
            throw new NotImplementedException();
        }
    }
}
