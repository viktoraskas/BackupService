using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Models
{
    public  class AppConfig
    {
        public  string? SqlServer { get; set; }
        public  int SqlServerPort { get; set; }
        public  string? SqlUserName { get; set; }
        public  string? SqlUserNameSecure { get; set; }
        public  string? SqlPassword  { get; set; }
        public  string? SqlPasswordSecure { get; set; }
        public  bool SqlLoginSecure { get; set; }
        public  string? FtpServer { get; set; }
        public  int  FtpServerPort { get; set; }
        public  bool FtpSSL { get; set; }
        public  string? FtpUserName { get; set; }
        public  string? FtpUserNameSecure { get; set; }
        public  string? FtpPassword { get; set; }
        public  string? FtpPasswordSecure { get; set; }
        public  string? WsServerUrl { get; set; }
        public  string? WsId { get; set; }
        public  string? WsIdSecure { get; set; }
        public  string? WsPassword { get; set; }
        public  string? WsPasswordSecure { get; set; }
    }
}
