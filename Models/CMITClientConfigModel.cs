using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class CMITClientConfigModel
    {
        public string configFileName { get; set; }
        public CMITSettingsSection settingsSection { get; set; }
        public AppSettings appSettings { get; set; }
    }
}
