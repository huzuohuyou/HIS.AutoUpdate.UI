#pragma checksum "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59f6164da3a9eb6e9f18e5f7a2da9768f463169"
// <auto-generated/>
#pragma warning disable 1591
namespace HIS.AutoUpdate.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using AntDesign.Pro.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\_Imports.razor"
using HIS.AutoUpdate.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
using AntDesign.TableModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AutoUpdateClient")]
    public partial class AutoUpdateClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Pro.Layout.PageContainer>(0);
            __builder.AddAttribute(1, "Title", "更新HIS客户端");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Card>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Button>(7);
                    __builder3.AddAttribute(8, "Type", "primary");
                    __builder3.AddAttribute(9, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
                                         ConfigurationManager

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(11, "/api/ConfigurationManager");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Collapse>(13);
                    __builder3.AddAttribute(14, "DefaultActiveKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 10 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
                                      new[] { "1" }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String[]>(this, 
#nullable restore
#line 11 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
                            Callback

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(16, "ExpandIconPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
                                       expandIconPosition

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "ExpandIcon", "caret-right");
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(19, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.Panel>(20);
                        __builder4.AddAttribute(21, "Header", "HISModal.settingsSection.DWIO_HIS_DWIO_exe");
                        __builder4.AddAttribute(22, "Key", "1");
                        __builder4.AddAttribute(23, "ExtraTemplate", new Microsoft.AspNetCore.Components.RenderFragment(
#nullable restore
#line 14 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
                                                                                               extra

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(25, "\r\n                ");
                            __builder5.OpenElement(26, "div");
                            __builder5.AddMarkupContent(27, "\r\n                    ");
                            __Blazor.HIS.AutoUpdate.Blazor.Pages.AutoUpdateClient.TypeInference.CreateInput_0(__builder5, 28, 29, 
#nullable restore
#line 16 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
                                         SYSTEM_HIS_Foundations_exe

#line default
#line hidden
#nullable disable
                            , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SYSTEM_HIS_Foundations_exe = __value, SYSTEM_HIS_Foundations_exe)), 31, () => SYSTEM_HIS_Foundations_exe);
                            __builder5.AddMarkupContent(32, "\r\n                    ");
                            __builder5.OpenComponent<AntDesign.Button>(33);
                            __builder5.AddAttribute(34, "Type", "primary");
                            __builder5.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(36, "编辑");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(37, "\r\n                    ");
                            __builder5.OpenComponent<AntDesign.Upload>(38);
                            __builder5.AddAttribute(39, "Action", "https://www.mocky.io/v2/5cc8019d300000980a055e76");
                            __builder5.AddAttribute(40, "Name", "files");
                            __builder5.AddAttribute(41, "OnSingleCompleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.UploadInfo>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.UploadInfo>(this, 
#nullable restore
#line 20 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
                                               OnSingleCompleted

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(43, "\r\n                        ");
                                __builder6.OpenComponent<AntDesign.Button>(44);
                                __builder6.AddAttribute(45, "Icon", "upload");
                                __builder6.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(47, "\r\n                            ");
                                    __builder7.AddMarkupContent(48, "<span>点击上传</span>\r\n                        ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(49, "\r\n                    ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(50, "\r\n                ");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(51, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(52, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
 
    public class ResponseModel
    {
        public string name { get; set; }

        public string status { get; set; }

        public string url { get; set; }

        public string thumbUrl { get; set; }
    }

    void OnSingleCompleted(UploadInfo fileinfo)
    {
        if (fileinfo.File.State == UploadState.Success)
        {
            var result = fileinfo.File.GetResponse<ResponseModel>();
            fileinfo.File.Url = result.url;
        }
    }

    class CurrentVersionURL
    {
        [JsonPropertyName("CurrentVersionURL")]
        public string currentVersionURL { get; set; }
        [JsonPropertyName("1.0.0.0")]
        public string _1_0_0_0 { get; set; }
    }
    class HISSettingsSection
    {
        #region HIS

        [JsonPropertyName("DWIO_HIS.DWIO.exe")]
        public CurrentVersionURL DWIO_HIS_DWIO_exe { get; set; } = new CurrentVersionURL { currentVersionURL = "123123" };
        [JsonPropertyName("IP_HIS.Inpatient.Pharmacy.exe")]
        public CurrentVersionURL IP_HIS_Inpatient_Pharmacy_exe { get; set; }
        [JsonPropertyName("OP_HIS.Outpatient.Pharmacy.exe")]
        public CurrentVersionURL OP_HIS_Outpatient_Pharmacy_exe { get; set; }
        [JsonPropertyName("MT_HIS.MT.exe")]
        public CurrentVersionURL MT_HIS_MT_exe { get; set; }
        [JsonPropertyName("HIS.Client.Launcher.exe")]
        public CurrentVersionURL HIS_Client_Launcher_exe { get; set; }
        [JsonPropertyName("OPD_HIS.Outpatient.RC.exe")]
        public CurrentVersionURL OPD_HIS_Outpatient_RC_exe { get; set; }
        [JsonPropertyName("IPDTest_HIS.Inpatient.Admission.QueryTest.exe")]
        public CurrentVersionURL IPDTest_HIS_Inpatient_Admission_QueryTest_exe { get; set; }
        [JsonPropertyName("ComplexQuery_HIS.ComplexQuery.exe")]
        public CurrentVersionURL ComplexQuery_HIS_ComplexQuery_exe { get; set; }
        [JsonPropertyName("PatientTest_HIS.Patient.Test.exe")]
        public CurrentVersionURL PatientTest_HIS_Patient_Test_exe { get; set; }
        [JsonPropertyName("DW_HIS.DW.exe")]
        public CurrentVersionURL DW_HIS_DW_exe { get; set; }
        [JsonPropertyName("NW_HIS.NW.exe")]
        public CurrentVersionURL NW_HIS_NW_exe { get; set; }
        [JsonPropertyName("OPDFree_HIS.Outpatient.RC.Free.exe")]
        public CurrentVersionURL OPDFree_HIS_Outpatient_RC_Free_exe { get; set; }
        [JsonPropertyName("SYSTEM_HIS.Foundations.exe")]
        public CurrentVersionURL SYSTEM_HIS_Foundations_exe { get; set; }
        [JsonPropertyName("IPD.SC_HIS.Inpatient.SC.exe")]
        public CurrentVersionURL IPD_SC_HIS_Inpatient_SC_exe { get; set; }
        [JsonPropertyName("Patient_HIS.Patient.exe")]
        public CurrentVersionURL Patient_HIS_Patient_exe { get; set; }
        [JsonPropertyName("AutoUpgradeComponent")]
        public CurrentVersionURL AutoUpgradeComponent { get; set; }
        [JsonPropertyName("OPDHs_HIS.Outpatient.RC.Hs.exe")]
        public CurrentVersionURL OPDHs_HIS_Outpatient_RC_Hs_exe { get; set; }
        [JsonPropertyName("DWIOInternet_HIS.DWIONET.exe")]
        public CurrentVersionURL DWIOInternet_HIS_DWIONET_exe { get; set; }
        [JsonPropertyName("IPD_HIS.Inpatient.Admission.Query.exe")]
        public CurrentVersionURL IPD_HIS_Inpatient_Admission_Query_exe { get; set; }
        [JsonPropertyName("IPD_HIS.Inpatient.Admission.Reception.exe")]
        public CurrentVersionURL IPD_HIS_Inpatient_Admission_Reception_exe { get; set; }
        [JsonPropertyName("OPDTest_HIS.Outpatient.RC.Test.exe")]
        public CurrentVersionURL OPDTest_HIS_Outpatient_RC_Test_exe { get; set; }
        [JsonPropertyName("IPDTest_HIS.Inpatient.Admission.ReceptionTest.exe")]
        public CurrentVersionURL IPDTest_HIS_Inpatient_Admission_ReceptionTest_exe { get; set; }
        #endregion

        #region CMIT

        [JsonPropertyName("HIS.NW")]
        public CurrentVersionURL HIS_NW { get; set; }
        [JsonPropertyName("HIS.DWIO")]
        public CurrentVersionURL HIS_DWIO { get; set; }
        [JsonPropertyName("HIS.Outpatient.DW")]
        public CurrentVersionURL HIS_Outpatient_DW { get; set; }
        //[JsonPropertyName("AutoUpgradeComponent")]
        //public CurrentVersionURL AutoUpgradeComponent { get; set; }
        [JsonPropertyName("HIS.Inpatient.DW")]
        public CurrentVersionURL HIS_Inpatient_DW { get; set; }

        #endregion
    }
    class AppSettings
    {
        public string UpgradePath { get; set; }
        public string UpgradeExecProgURL { get; set; }
    }

    class HISClientConfigModel
    {
        public string configFileName { get; set; }
        public HISSettingsSection settingsSection { get; set; }
        public AppSettings appSettings { get; set; }
    }

    class CMITSettingsSection
    {
        [JsonPropertyName("HIS.NW")]
        public CurrentVersionURL HIS_NW { get; set; }

        [JsonPropertyName("HIS.DWIO")]
        public CurrentVersionURL HIS_DWIO { get; set; }
        [JsonPropertyName("HIS.Outpatient.DW")]
        public CurrentVersionURL HIS_Outpatient_DW { get; set; }
        [JsonPropertyName("AutoUpgradeComponent")]
        public CurrentVersionURL AutoUpgradeComponent { get; set; }
        [JsonPropertyName("HIS.Inpatient.DW")]
        public CurrentVersionURL HIS_Inpatient_DW { get; set; }
    }
    class CMITClientConfigModel
    {
        public string configFileName { get; set; }
        public CMITSettingsSection settingsSection { get; set; }
        public AppSettings appSettings { get; set; }
    }

    HISClientConfigModel HISModal = new HISClientConfigModel() { settingsSection = new HISSettingsSection() };
    HISClientConfigModel CMITModal { get; set; }
    public async Task ConfigurationManager()
    {
        var random = new Random();
        var result = await Http.GetAsync($@"/api/ConfigurationManager");

        string resultContent = result.Content.ReadAsStringAsync().Result;
        var r = JsonSerializer.Deserialize<HISClientConfigModel[]>(resultContent);
        if (r[0].configFileName.Contains("HIS.AutoUpdate"))
        {
            HISModal = r[0];
            CMITModal = r[1];
            SYSTEM_HIS_Foundations_exe = HISModal.settingsSection.SYSTEM_HIS_Foundations_exe.currentVersionURL;
        }
        else
        {
            HISModal = r[1];
            CMITModal = r[0];
        }
    }
    protected override async Task OnInitializedAsync()
    {
        await ConfigurationManager();

    }

    string SYSTEM_HIS_Foundations_exe { get; set; }

    RenderFragment extra =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(55, "div");
            __builder2.AddEventStopPropagationAttribute(56, "onclick", true);
            __builder2.OpenComponent<AntDesign.Icon>(57);
            __builder2.AddAttribute(58, "Type", "setting");
            __builder2.CloseComponent();
            __builder2.CloseElement();
        }
#nullable restore
#line 189 "D:\GitHub\HIS.AutoUpdate.UI\HIS.AutoUpdate.Blazor\Pages\AutoUpdateClient.razor"
                                                                                           ;

string expandIconPosition = "left";

void Callback(string[] keys)
{
Console.WriteLine(string.Join(',', keys));
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.HIS.AutoUpdate.Blazor.Pages.AutoUpdateClient
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInput_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591