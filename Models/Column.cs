using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class Column
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
        public string ClientUploadUri
        {
            get
            {
                return $@"{WebApiUri}/api/ConfigurationManager/UploadFile";
            }
        }

        public string WebApiUri { get; set; } = "";
        public string ConfigFileName { get; set; }

        public string MoudleName { get; set; }
        public string SettingsSectionName { get; set; }
        public string CurrentVersionURL { get; set; }

    }
}
