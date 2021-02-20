using AntDesign.Pro.Layout;
using HIS.AutoUpdate.Blazor.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HIS.AutoUpdate.Blazor
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            var Uri = builder.Configuration.GetSection("ProSettings")["WebApiUri"];
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(Uri) });
            builder.Services.AddAntDesign();
            builder.Services.Configure<ProSettings>(builder.Configuration.GetSection("ProSettings"));

            builder.Services.Configure<MyProSettings>(builder.Configuration.GetSection("ProSettings"));
            await builder.Build().RunAsync();
        }
    }
}