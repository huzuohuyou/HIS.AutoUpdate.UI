using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class Client
    {
        public Client(string name) {
            SettingsSectionName = name;
        }
        public string SettingsSectionName { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();
    }
}
