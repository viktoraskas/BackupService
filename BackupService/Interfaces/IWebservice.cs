using BackupService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Interfaces
{
    public interface IWebservice
    {
        public Task<(bool, string)> PostMessage(IEnumerable<Database> databases);
    }
}
