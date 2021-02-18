using AntDesign;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class AutoUploadFile
    {
        public List<UploadFileItem> files { get; set; }
        public string configFileName { get; set; }
    }
}
