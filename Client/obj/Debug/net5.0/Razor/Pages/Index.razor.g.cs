#pragma checksum "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb116cb955ee3a97c44b2654da0d28893fa86e8f"
// <auto-generated/>
#pragma warning disable 1591
namespace Facturations.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using Facturations.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\EPSI\Dev\C#\Facturations\Client\_Imports.razor"
using Facturations.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
using Facturations.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
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
            __builder.AddMarkupContent(0, "<h1>Chiffres d\'affaires</h1>\r\nRetrouvez ici vos chiffres d\'affaire par mois\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container wrap ");
#nullable restore
#line 10 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
     foreach (var date in CAR)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row wrap justify-content-around mt-3");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-11");
            __builder.OpenElement(7, "h5");
            __builder.AddAttribute(8, "class", "text-capitalize");
            __builder.AddContent(9, 
#nullable restore
#line 14 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
                                             date.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card border-warning mb-3 col-lg-5 col-md-5 col-sm-11 p-0");
            __builder.AddMarkupContent(13, "<div class=\"card-header\">Chiffre d\'affaire réél</div>\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body text-warning");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "card-title");
            __builder.AddContent(18, 
#nullable restore
#line 20 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
                                            date.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "€ ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card border-success mb-3 col-lg-5 col-md-5 col-sm-11 p-0");
            __builder.AddMarkupContent(23, "<div class=\"card-header\">Chiffre d\'affaire attendu</div>\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-body text-success");
            __builder.OpenElement(26, "h5");
            __builder.AddAttribute(27, "class", "card-title");
            __builder.AddContent(28, 
#nullable restore
#line 27 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
                                            CAD[date.Key]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "€");
            __builder.CloseElement();
#nullable restore
#line 28 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
                     if (CAD[date.Key] != date.Value)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, 
#nullable restore
#line 30 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
                             CAD[date.Key]-date.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "€ attendus");
            __builder.CloseElement();
#nullable restore
#line 31 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
        
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\EPSI\Dev\C#\Facturations\Client\Pages\Index.razor"
       

    public struct Montants
    {
        public int Du;
        public double Reel;
    }

    private WeatherForecast[] forecasts;
    private Dictionary<string, int> CAR = new Dictionary<string, int>();
    private Dictionary<string, int> CAD = new Dictionary<string, int>();




    protected override async Task OnInitializedAsync()
    {
        
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        foreach (var forecast in forecasts)
        {
            var annee = forecast.DateE.Year;
            var mois = forecast.DateE.Month;
            var moisAnnee =  forecast.DateE.ToString("MMMM yyyy", new CultureInfo("fr-FR", false)).ToString();
            var du = forecast.MontantD;
            var regle = forecast.MontantR;


            if (CAR.ContainsKey(moisAnnee))
            {
                int tmpR = CAR[moisAnnee];
                int tmpD = CAD[moisAnnee];

                CAR[moisAnnee] += regle;
                CAD[moisAnnee] += regle;
            }
            else
            {
                CAR.Add(moisAnnee, regle);
                CAD.Add(moisAnnee, du);
            }

        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591