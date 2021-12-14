using BackupService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Interfaces
{
    public class ConfigService : IConfig
    {
        //private AppConfig appConfig;
        private readonly IConfiguration _configuration;
        public ConfigService(IConfiguration configuration)
        {
            _configuration=configuration;
        }
        public async Task<AppConfig> GetAppConfigAsync()
        {
            var appConfig = _configuration.GetSection("AppConfig").Get<AppConfig>();
            return await Task.FromResult(appConfig);
        }
    }
}
