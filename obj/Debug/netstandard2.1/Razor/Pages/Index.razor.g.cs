#pragma checksum "C:\app\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c65808da4d1e976bc1d343a6920df156b3a4e290"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\app\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\app\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\app\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\app\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\app\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\app\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\app\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\app\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\app\BlazorApp\_Imports.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\app\BlazorApp\_Imports.razor"
using BlazorApp.Methods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\app\BlazorApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\app\BlazorApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\app\BlazorApp\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "style", "margin-top: 50px;");
            __builder.AddMarkupContent(3, "\r\n\r\n");
#nullable restore
#line 8 "C:\app\BlazorApp\Pages\Index.razor"
     if(!loaded)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, @"<div class=""container"" style=""margin-top: 20%;"">
            <div class=""row"">
                <div class=""col-5""></div>
                <div class=""col-6"">
                    <div class=""loader""></div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-3""></div>
                <div class=""col-6"">
                    <br>
                    <h3 style=""text-align: center; color: aliceblue;"">the page is loading..</h3>
                </div>
            </div>
        </div>
");
#nullable restore
#line 25 "C:\app\BlazorApp\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.AddAttribute(9, "style", "margin-bottom: 50px;");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 29 "C:\app\BlazorApp\Pages\Index.razor"
             if(chartM.TotalReport.Length > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.AddMarkupContent(12, "<h1 style=\"text-align: center; color: white; margin-bottom: 20px\">Covid-19 Statistic</h1>\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddAttribute(15, "style", "background-color: aliceblue;");
            __builder.AddMarkupContent(16, "\r\n                    <div class=\"col-3\"></div>\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-6");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(20);
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                            ");
                __Blazor.BlazorApp.Pages.Index.TypeInference.CreateRadzenPieSeries_0(__builder2, 23, 24, 
#nullable restore
#line 36 "C:\app\BlazorApp\Pages\Index.razor"
                                                    chartM.ChartDatas

#line default
#line hidden
#nullable disable
                , 25, "Cases", 26, "Title", 27, "Number");
                __builder2.AddMarkupContent(28, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "p");
            __builder.AddAttribute(31, "style", "text-align: end;");
            __builder.AddContent(32, "Last Update: ");
            __builder.AddContent(33, 
#nullable restore
#line 38 "C:\app\BlazorApp\Pages\Index.razor"
                                                                  chartM.TotalReport[0].LastUpdate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "  \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 41 "C:\app\BlazorApp\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.AddContent(39, "            ");
            __builder.AddMarkupContent(40, "<div class=\"container\">\r\n                <div id=\"svgMapGPD\"></div>\r\n            </div>\r\n");
            __builder.AddContent(41, "        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "container");
            __builder.AddAttribute(44, "style", "row-gap: 20px; display: grid; ");
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 75 "C:\app\BlazorApp\Pages\Index.razor"
             if(articleM.AllArticles.Count > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                ");
            __builder.AddMarkupContent(47, "<h1 style=\"text-align: center; color:white\">Covid-19 Articles</h1>\r\n");
#nullable restore
#line 78 "C:\app\BlazorApp\Pages\Index.razor"
                foreach (var ar in articleM.AllArticles)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "                    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row");
            __builder.AddAttribute(51, "style", " border: 1px solid rgba(0, 0, 0, 0.8); padding: 20px; background-color: aliceblue;");
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col");
            __builder.AddMarkupContent(55, "\r\n                            ");
            __builder.OpenElement(56, "a");
            __builder.AddAttribute(57, "href", 
#nullable restore
#line 82 "C:\app\BlazorApp\Pages\Index.razor"
                                      ar.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "target", "_blank");
            __builder.OpenElement(59, "b");
            __builder.AddContent(60, 
#nullable restore
#line 82 "C:\app\BlazorApp\Pages\Index.razor"
                                                                  ar.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 83 "C:\app\BlazorApp\Pages\Index.razor"
                             if(ar.Description != null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                                ");
            __builder.OpenElement(63, "p");
            __builder.AddContent(64, 
#nullable restore
#line 85 "C:\app\BlazorApp\Pages\Index.razor"
                                    ar.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 86 "C:\app\BlazorApp\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-4");
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "img");
            __builder.AddAttribute(72, "src", 
#nullable restore
#line 89 "C:\app\BlazorApp\Pages\Index.razor"
                                       ar.UrlToImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(73, "style", "width: inherit; height: inherit;");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 92 "C:\app\BlazorApp\Pages\Index.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 95 "C:\app\BlazorApp\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\app\BlazorApp\Pages\Index.razor"
      
    
    private ChartM chartM;
    private ArticleM articleM;
    private List<Task> tasks = new List<Task>();
    private Boolean loaded = false;
    protected async override Task OnInitializedAsync()
    {
        this.articleM = new ArticleM(Http);
        this.chartM = new ChartM(Http);
        tasks.Add(chartM.GetStatistics());
        //tasks.Add(chartM.GetCasesByDate());
        tasks.Add(articleM.GetArticles());
        await Task.WhenAll(tasks);
        loaded = true;
    }
    private string FormatAsUSD(object value)
    {
        return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenPieSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenPieSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Title", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
