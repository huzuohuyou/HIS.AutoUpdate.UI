#pragma checksum "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747a88341e6ec7e10503f6c4cb0e3418cba412b2"
// <auto-generated/>
#pragma warning disable 1591
namespace HIS.AutoUpdate.Blazor.Pages
{
    #line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using AntDesign.Pro.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using HIS.AutoUpdate.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
using HIS.AutoUpdate.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
using System.Runtime.Serialization.Formatters;

#line default
#line hidden
#nullable disable
    public partial class UploadFile2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.HIS.AutoUpdate.Blazor.Pages.UploadFile2.TypeInference.CreateInput_0(__builder, 0, 1, "Basic usage", 2, 
#nullable restore
#line 9 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
                                               configFileName

#line default
#line hidden
#nullable disable
            , 3, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => configFileName = __value, configFileName)), 4, () => configFileName);
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<AntDesign.Upload>(6);
            __builder.AddAttribute(7, "Action", "http://192.168.5.212:20002/api/ConfigurationManager/UploadFile");
            __builder.AddAttribute(8, "Name", "files");
            __builder.AddAttribute(9, "OnSingleCompleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.UploadInfo>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.UploadInfo>(this, 
#nullable restore
#line 12 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
                           OnSingleCompleted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 13 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
              dict

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Button>(13);
                __builder2.AddAttribute(14, "Icon", "upload");
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __builder3.AddMarkupContent(17, "<span>点击上传</span>\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\UploadFile2.razor"
       
    [Parameter]
    public string configFileName { get; set; } = @"E:\Deployment\HIS.AutoUpdate\AutoUpgradeServerDefine.config";
    Dictionary<string, object> dict = new Dictionary<string, object>()
{
        { "configFileName",@"E:\Deployment\HIS.AutoUpdate\AutoUpgradeServerDefine.config"}
    };


    async Task OnSingleCompleted(UploadInfo fileinfo)
    {
        try
        {
            if (fileinfo.File.State == UploadState.Success)
            {
                await _message.Success("文件上传成功！！！");
                //var result = fileinfo.File.GetResponse<ResponseModel>();
                //fileinfo.File.Url = result.url;
            }
        }
        catch (Exception ex)
        {

            await _message.Error(ex.Message);
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService _message { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.HIS.AutoUpdate.Blazor.Pages.UploadFile2
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInput_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591