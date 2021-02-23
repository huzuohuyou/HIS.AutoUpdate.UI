using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class Site
    {

        private string _ip;
        public string IP
        {
            get
            {
                Match m1 = Regex.Match(WebApiUri ?? "", @"(?<=http://).*?(?=:)");
                return m1?.ToString();
            }
            set { _ip = value; }
        }
        public string WebApiUri { get; set; } = "";
        public string ServerUploadUri
        {
            get
            {
                return $@"{WebApiUri}/api/Sites/UploadFile";
            }
        }
        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonIgnore]
        private bool? _stateValue;

        [JsonIgnore]
        public bool StateValue
        {
            get
            {
                if (_stateValue == null)
                {
                    if (!string.IsNullOrWhiteSpace(State) && (State ?? "").Equals("Started"))
                    {
                        return true;
                    }
                    return false;
                }

                return _stateValue.Value;
            }
            set { _stateValue = value; }
        }
        [JsonPropertyName("physicalPath")]
        public string PhysicalPath { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("appPool")]
        public AppPool AppPool { get; set; }

        [JsonIgnore]
        private string _poolName;
        [JsonIgnore]
        public string PoolName
        {
            get
            {
                return AppPool?.Name;
            }
            set { _poolName = value; }
        }
        [JsonIgnore]
        public string PoolState
        {

            get
            {
                return AppPool?.State;
            }
        }
        [JsonIgnore]
        private bool? _poolStateValue;
        [JsonIgnore]
        public bool PoolStateValue
        {
            get
            {
                if (_poolStateValue == null)
                {
                    if (!string.IsNullOrWhiteSpace(PoolState) && (PoolState ?? "").Equals("Started"))
                    {
                        return true;
                    }
                    return false;
                }

                return _poolStateValue.Value;
            }
            set { _poolStateValue = value; }
        }

    }
}
