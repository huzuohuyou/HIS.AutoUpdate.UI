using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class Service
    {

        public Service(string name) {
            Name = name;
        }
        public string Name { get; set; }

        public List<Site> Columns { get; set; } = new List<Site>();
    }
}
