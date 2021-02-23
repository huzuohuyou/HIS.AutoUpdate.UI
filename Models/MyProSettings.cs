using AntDesign.Pro.Layout;

namespace HIS.AutoUpdate.Blazor.Models
{
    public class MyProSettings: ProSettings
    {
        //public string WebApiUri { get; set; }
        //public string ClientUploadUri { get; set; }
        //public string ServerUploadUri { get; set; }

        public Server[] Servers { get; set; }
    }
}
