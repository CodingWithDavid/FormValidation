#pragma checksum "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c78dd398b32ca1aede4514a85f68793e36ff8d8d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WeatherDemoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using WeatherDemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\_Imports.razor"
using WeatherDemoApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\Pages\FetchData.razor"
using WeatherDemoApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\CodingWithDavid\Sandbox\FormValidation\FormValidation\WeatherDemoApp\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

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
