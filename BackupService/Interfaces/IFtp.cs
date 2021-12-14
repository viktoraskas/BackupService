using BackupService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Interfaces
{
    internal interface IFtp
    {
        public Task<Database> Upload(Database database);
    }
}
