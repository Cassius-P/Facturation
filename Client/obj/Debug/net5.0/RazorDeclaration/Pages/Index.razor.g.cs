// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
