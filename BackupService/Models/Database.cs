using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupService.Models
{
    internal class Database
    {
        public string? DatabaseName { get; set; }    
        public decimal? DatabaseSize { get; set; }
        public string? BackupPath { get; set; } 
        public string? BackupType { get; set; } 
        public bool? Backup { get; set; }
        public bool? IsBackuped { get; set; }
        public bool? Compress { get; set; }
        public bool? IsCompressed { get; set; }
        public bool? Upload { get; set; }
        public bool? IsUploaded { get; set; }
        public bool? Check { get; set; }
        public bool? IsChecked { get; set; }

    }
}
