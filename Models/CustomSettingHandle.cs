using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class CustomSettingHandle
    {
        [JsonPropertyName("configFileName")]
        public string ConfigFileName { get; set; }

        [JsonPropertyName("settingsSection")]
        public Dictionary<string, Dictionary<string, object>> SettingsSection { get; set; } =
            new Dictionary<string, Dictionary<string, object>>();

        [JsonPropertyName("appSettings")]
        public Dictionary<string, string> AppSettings { get; set; } = new Dictionary<string, string>();

  
    }
}
