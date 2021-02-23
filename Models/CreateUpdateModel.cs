using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class CreateUpdateModel
    {
        [Required]
        public string configFileName { get; set; }
        [Required]
        public Dictionary<string, CurrentVersionURL> settingsSection { get; set; }

    }

}
