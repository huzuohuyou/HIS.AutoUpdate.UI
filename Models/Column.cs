using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class Column
    {
        public string ConfigFileName { get; set; }

        public string MoudleName { get; set; }
        public string SettingsSectionName { get; set; }
        public string CurrentVersionURL { get; set; }
        
    }
}
