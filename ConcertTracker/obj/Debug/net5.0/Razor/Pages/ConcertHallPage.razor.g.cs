#pragma checksum "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f18cf600ec70926d55d79524c2bce63b548257cf"
// <auto-generated/>
#pragma warning disable 1591
namespace ConcertTracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using ConcertTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using ConcertTracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ConcertTracker\ConcertTracker\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
using BusinessLayer;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/concerthall/{Id}")]
    public partial class ConcertHallPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "profilePage");
            __builder.AddMarkupContent(2, "<a href class=\"mainText\">ConcertTracker</a>\r\n    <img class=\"concertHallImage\" src=\"Images/antoine-julien-Ke6Pr-9A2ac-unsplash 1.png\" alt>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "profileContainer");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "profileInfo");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "higherInfo");
#nullable restore
#line 16 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                 if (foundConcertHall.Photo != null)
                {
                    if (foundConcertHall.Photo.Contains("http"))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 20 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                   foundConcertHall.Photo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", "/uploads/" + (
#nullable restore
#line 24 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                            foundConcertHall.Photo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "alt");
            __builder.CloseElement();
#nullable restore
#line 25 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "profileLeftInfo");
            __builder.OpenElement(17, "p");
            __builder.AddMarkupContent(18, "<strong>Name:</strong> ");
            __builder.AddContent(19, 
#nullable restore
#line 28 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                               foundConcertHall.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "p");
            __builder.AddMarkupContent(22, "<strong>Address:</strong> ");
            __builder.AddContent(23, 
#nullable restore
#line 29 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                  foundConcertHall.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "<strong>Description:</strong> ");
            __builder.AddContent(27, 
#nullable restore
#line 30 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                      foundConcertHall.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "concertsList");
            __builder.AddMarkupContent(31, "<p><strong>Last concerts:</strong></p>");
#nullable restore
#line 35 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                 foreach (var concert in concertHallConcerts)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "/concert/" + (
#nullable restore
#line 37 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                       concert.Id.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Date: ");
            __builder.AddContent(35, 
#nullable restore
#line 37 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                                     concert.Date.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, "    Description: ");
            __builder.AddContent(37, 
#nullable restore
#line 37 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                                                                              concert.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(39);
            __builder.AddAttribute(40, "Roles", "Admin");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                           DeleteConcertHall

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(44, "Delete");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
       

    [Parameter]
    public string Id { get; set; }

    private ConcertHall foundConcertHall = new ConcertHall();
    private List<Concert> concertHallConcerts = new List<Concert>();

    protected override async Task OnInitializedAsync()
    {
        foundConcertHall = await DataManager.ConcertHalls.GetConcertHallByIdAsync(Convert.ToInt32(Id));
        concertHallConcerts = await DataManager.ConcertHalls.GetConcertsOfConcertHallAsync(foundConcertHall);
    }

    private async Task DeleteConcertHall()
    {
        await DataManager.ConcertHalls.DeleteConcertHallAsync(foundConcertHall);
        NavigationManager.NavigateTo("map");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataManager DataManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
