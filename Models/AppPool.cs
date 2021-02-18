using System.Text.Json.Serialization;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class AppPool
    {
        [JsonPropertyName("state")]
        public string State { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
