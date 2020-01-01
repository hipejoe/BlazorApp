#pragma checksum "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\Pages\Publishers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4c19d1e9a3e59258fc229829acf6076ee03af4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\Pages\Publishers.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/publishers")]
    public partial class Publishers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Data\CuriousDrive\BlazorApp\BlazorApp\BlazorApp\Pages\Publishers.razor"
       

    public Publisher publisher { get; set; }
    public List<Publisher> publisherList { get; set; }
    public string[] Cities { get; set; }
    ElementReference publisherNameTextBox;

    public bool IsVisible { get; set; }
    public string RecordName { get; set; }
    public bool Result { get; set; }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && Cities == null)
        {
            Cities = await JSRuntime.InvokeAsync<string[]>("getCities");

            StateHasChanged();
        }
    }

    protected override void OnInitialized()
    {
        publisher = new Publisher();
        publisherList = publisherService.GetPublishers();
    }

    private async Task SavePublisher()
    {
        Result = false;//publisherService.SavePublisher(publisher);
        IsVisible = true;
        RecordName = publisher.Publisher_Name;

        publisher = new Publisher();

        //await JSRuntime.InvokeVoidAsync("saveMessage",publisherName, "");
        await JSRuntime.InvokeVoidAsync("setFocusOnElement", publisherNameTextBox);
    }

    public async Task DeletePublisher(string publisherId)
    {
        var confirm = await JSRuntime.InvokeAsync<bool>("confirmDelete");

        if (confirm)
            publisherService.DeletePublisher(publisherId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPublisherService publisherService { get; set; }
    }
}
#pragma warning restore 1591
