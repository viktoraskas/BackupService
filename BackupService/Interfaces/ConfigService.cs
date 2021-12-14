using BackupService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Interfaces
{
    internal class ConfigService : IConfig
    {
        private AppConfig appConfig;
        public ConfigService()
        {

        }
        public AppConfig GetAppConfig()
        {
            throw new NotImplementedException();
        }
    }
}
