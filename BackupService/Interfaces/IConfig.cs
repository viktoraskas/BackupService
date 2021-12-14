using BackupService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Interfaces
{
    public interface IConfig
    {
        public Task<AppConfig> GetAppConfigAsync();
    }
}
