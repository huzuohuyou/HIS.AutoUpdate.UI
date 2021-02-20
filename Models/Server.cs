using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class Server
    {
        public string WebApiUri { get; set; }
        public string ClientUploadUri { get; set; }
        public string ServerUploadUri { get; set; }

    }
}
