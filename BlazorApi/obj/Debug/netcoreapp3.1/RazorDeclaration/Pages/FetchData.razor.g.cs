// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\_Imports.razor"
using BlazorApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\_Imports.razor"
using BlazorApi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\Pages\FetchData.razor"
using BlazorApi.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "E:\gitProjs\blazorApi\blazorapiService\blazorapiService\BlazorApi\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591