using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace HIS.AutoUpdate.Blazor.Models
{
    public class CurrentVersionURL
    {
        [JsonPropertyName("CurrentVersionURL")]
        public string currentVersionURL { get; set; }
        [JsonPropertyName("1.0.0.0")]
        public string _1_0_0_0 { get; set; }
    }
}
