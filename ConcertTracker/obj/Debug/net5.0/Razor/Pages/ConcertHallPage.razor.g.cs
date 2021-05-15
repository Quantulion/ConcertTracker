#pragma checksum "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23fe783637fe9e4f0988da8661c21807567bb850"
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
using BusinessLayer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
using DataLayer.Entities;

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
            __builder.AddMarkupContent(2, "<a href class=\"mainText\">ConcertTracker</a>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "profileContainer");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "profileInfo");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "higherInfo");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", "/uploads/" + (
#nullable restore
#line 13 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                    foundConcertHall.Photo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "alt");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "profileLeftInfo");
            __builder.OpenElement(15, "p");
            __builder.AddMarkupContent(16, "<strong>Название:</strong> ");
            __builder.AddContent(17, 
#nullable restore
#line 15 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                   foundConcertHall.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "<strong>Адрес:</strong> ");
            __builder.AddContent(21, 
#nullable restore
#line 16 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                foundConcertHall.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "p");
            __builder.AddMarkupContent(24, "<strong>Описание:</strong> ");
            __builder.AddContent(25, 
#nullable restore
#line 17 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                   foundConcertHall.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "concertsList");
            __builder.AddMarkupContent(29, "<p><strong>Список концертов:</strong></p>");
#nullable restore
#line 22 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                     foreach (var concert in concertHallConcerts)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "/concert/" + (
#nullable restore
#line 24 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                           concert.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "Дата: ");
            __builder.AddContent(33, 
#nullable restore
#line 24 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                              concert.Date

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "    Описание: ");
            __builder.AddContent(35, 
#nullable restore
#line 24 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                                                                                         concert.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.AddMarkupContent(37, @"<div class=""profileComments""><p id=""1"" class=""hdr"">Последний комментарий:</p>
            <div class=""commentContent""><p class=""hdr"">Публикация:</p>
                <p>Пользователь Джон Леннон</p>
                <p class=""hdr"">Комментарий:</p>
                <p class=""commentText"">
                    Рост популярности группы легко проследить по гонорарам
                    музыкантов...
                </p></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHallPage.razor"
       

    [Parameter]
    public string Id { get; set; }

    protected ConcertHall foundConcertHall = new ConcertHall();
    protected List<Concert> concertHallConcerts = new List<Concert>();

    protected override async Task OnInitializedAsync()
    {
        foundConcertHall = await ConcertHallRepository.GetConcertHallById(Convert.ToInt32(Id));
        concertHallConcerts = await ConcertHallRepository.GetConcertsOfConcertHall(foundConcertHall);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConcertHallRepository ConcertHallRepository { get; set; }
    }
}
#pragma warning restore 1591