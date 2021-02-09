using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace HIS.AutoUpdate.Blazor.Models
{
    public class CMITSettingsSection
    {
        [JsonPropertyName("HIS.NW")]
        public CurrentVersionURL HIS_NW { get; set; }

        [JsonPropertyName("HIS.DWIO")]
        public CurrentVersionURL HIS_DWIO { get; set; }
        [JsonPropertyName("HIS.Outpatient.DW")]
        public CurrentVersionURL HIS_Outpatient_DW { get; set; }
        [JsonPropertyName("AutoUpgradeComponent")]
        public CurrentVersionURL AutoUpgradeComponent { get; set; }
        [JsonPropertyName("HIS.Inpatient.DW")]
        public CurrentVersionURL HIS_Inpatient_DW { get; set; }
    }
}
