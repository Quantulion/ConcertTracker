#pragma checksum "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fdf1434f59fb71a126c85b9c80ee22c043872b1"
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
#line 3 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
using BusinessLayer;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/{Id}")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
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
#nullable restore
#line 14 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                 if (foundUser.Photo != null)
                {
                    if (foundUser.Photo.Contains("http"))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 18 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                   foundUser.Photo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", "/uploads/" + (
#nullable restore
#line 22 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                            foundUser.Photo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "alt");
            __builder.CloseElement();
#nullable restore
#line 23 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "profileLeftInfo");
            __builder.OpenElement(16, "p");
            __builder.AddMarkupContent(17, "<strong>Name:</strong> ");
            __builder.AddContent(18, 
#nullable restore
#line 26 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                               foundUser.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "p");
            __builder.AddMarkupContent(21, "<strong>Age:</strong> ");
            __builder.AddContent(22, 
#nullable restore
#line 27 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                              foundUser.Age.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "p");
            __builder.AddMarkupContent(25, "<strong>Description:</strong> ");
            __builder.AddContent(26, 
#nullable restore
#line 28 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                                      foundUser.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 29 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                     if (isArtist)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "p");
            __builder.AddMarkupContent(28, "<strong>Genres: </strong>");
#nullable restore
#line 33 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                              
                                int end = artistGenres.Count - 1;
                                foreach (var genre in artistGenres)
                                {
                                    if (artistGenres[end] != genre)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "span");
            __builder.AddContent(30, 
#nullable restore
#line 39 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                               genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, ", ");
            __builder.CloseElement();
#nullable restore
#line 40 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "span");
            __builder.AddContent(33, 
#nullable restore
#line 43 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                               genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 44 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 48 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
             if (isArtist)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "concertsList");
            __builder.AddMarkupContent(36, "<p><strong>Concerts:</strong></p>");
#nullable restore
#line 55 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
             foreach (var concert in artistConcerts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "/concert/" + (
#nullable restore
#line 57 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                   concert.Id.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Date: ");
            __builder.AddContent(40, 
#nullable restore
#line 57 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                                                 concert.Date.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, "    Description: ");
            __builder.AddContent(42, 
#nullable restore
#line 57 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                                                                                          concert.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 58 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 60 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(43);
            __builder.AddAttribute(44, "Roles", "Admin");
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                                   DeleteUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(48, "Delete");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "profileComments");
            __builder.AddMarkupContent(52, "<p id=\"1\" class=\"hdr\">Last commentary:</p>");
#nullable restore
#line 65 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
             if (lastComment.Content != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "href", "/concert/" + (
#nullable restore
#line 67 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                   lastComment.ConcertId.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "class", "commentContent");
            __builder.AddMarkupContent(56, "<p class=\"hdr\">Concert:</p>\r\n                    ");
            __builder.OpenElement(57, "p");
            __builder.AddContent(58, 
#nullable restore
#line 69 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                        lastComment.Concert.Date.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.AddMarkupContent(60, "<p class=\"hdr\">Commentary:</p>\r\n                    ");
            __builder.OpenElement(61, "p");
            __builder.AddAttribute(62, "class", "commentText");
            __builder.AddContent(63, 
#nullable restore
#line 72 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                         lastComment.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
       

    [Parameter]
    public string Id { get; set; }

    private User foundUser = new User();
    private List<Concert> artistConcerts = new List<Concert>();
    private List<Genre> artistGenres = new List<Genre>();
    private Comment lastComment = new Comment();
    private bool isArtist = false;

    protected override async Task OnInitializedAsync()
    {
        foundUser = await DataManager.Users.GetUserByIdAsync(Id);
        await GetLastComment();
        if (await IsArtist())
        {
            var artist = (Artist)foundUser;
            artistConcerts = await DataManager.Artists.GetConcertsOfArtistAsync(artist);
            artistGenres = await DataManager.Genres.GetGenresOfArtistAsync(artist) as List<Genre>;
        }
    }

    private async Task<bool> IsArtist()
    {
        try
        {
            isArtist = await DataManager.Artists.GetArtistByIdAsync(Id) != null;
        }
        catch
        {
        }

        return isArtist;
    }

    private async Task GetLastComment()
    {
        var comments = await DataManager.Comments.GetCommentsOfUserAsync(foundUser);
        int end = comments.Count - 1;
        if(end >= 0)
            lastComment = comments[end];
        if (lastComment.ConcertId != 0)
        {
            var concert = await DataManager.Concerts.GetConcertByIdAsync(lastComment.ConcertId);
            lastComment.Concert = concert;
        }
    }

    private async Task DeleteUser()
    {
        await DataManager.Users.DeleteUserAsync(foundUser);
        NavigationManager.NavigateTo("map");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataManager DataManager { get; set; }
    }
}
#pragma warning restore 1591
