#pragma checksum "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e145f4babfe0fca15e544473abb2f6fc837f30ff"
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
using BusinessLayer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
using DataLayer.Entities;

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
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", "/uploads/" + (
#nullable restore
#line 17 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                    foundUser.Photo

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
            __builder.AddMarkupContent(16, "<strong>Name:</strong> ");
            __builder.AddContent(17, 
#nullable restore
#line 19 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                               foundUser.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "<strong>Age:</strong> ");
            __builder.AddContent(21, 
#nullable restore
#line 20 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                              foundUser.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "p");
            __builder.AddMarkupContent(24, "<strong>Description:</strong> ");
            __builder.AddContent(25, 
#nullable restore
#line 21 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                                      foundUser.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                     if (isArtist)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "p");
            __builder.AddMarkupContent(27, "<strong>Genres: </strong>");
#nullable restore
#line 26 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                              
                                int end = artistGenres.Count - 1;
                                foreach (var genre in artistGenres)
                                {
                                    if (artistGenres[end] != genre)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "span");
            __builder.AddContent(29, 
#nullable restore
#line 32 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                               genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, ", ");
            __builder.CloseElement();
#nullable restore
#line 33 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "span");
            __builder.AddContent(32, 
#nullable restore
#line 36 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                               genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 37 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 41 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
             if (isArtist)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "concertsList");
            __builder.AddMarkupContent(35, "<p><strong>Concerts:</strong></p>");
#nullable restore
#line 48 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
             foreach (var concert in artistConcerts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "href", "/concert/" + (
#nullable restore
#line 50 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                   concert.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Date: ");
            __builder.AddContent(39, 
#nullable restore
#line 50 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                                      concert.Date

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, "    Description: ");
            __builder.AddContent(41, 
#nullable restore
#line 50 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                                                                    concert.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 51 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 53 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(42);
            __builder.AddAttribute(43, "Roles", "Admin");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(45, "button");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                                   DeleteUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(47, "Delete");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "profileComments");
            __builder.AddMarkupContent(51, "<p id=\"1\" class=\"hdr\">Last commentary:</p>");
#nullable restore
#line 58 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
             if (lastComment.Content != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "href", "/concert/" + (
#nullable restore
#line 60 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                                   lastComment.ConcertId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "class", "commentContent");
            __builder.AddMarkupContent(55, "<p class=\"hdr\">Concert:</p>\r\n                    ");
            __builder.OpenElement(56, "p");
            __builder.AddContent(57, 
#nullable restore
#line 62 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                        lastComment.Concert.Date.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.AddMarkupContent(59, "<p class=\"hdr\">Commentary:</p>\r\n                    ");
            __builder.OpenElement(60, "p");
            __builder.AddAttribute(61, "class", "commentText");
            __builder.AddContent(62, 
#nullable restore
#line 65 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
                         lastComment.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
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
#line 74 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
       

    [Parameter]
    public string Id { get; set; }

    protected User foundUser = new User();
    protected List<Concert> artistConcerts = new List<Concert>();
    protected List<Genre> artistGenres = new List<Genre>();
    protected Comment lastComment = new Comment();
    public bool isArtist = false;

    protected override async Task OnInitializedAsync()
    {
        foundUser = await UserRepositiory.GetUserByIdAsync(Id);
        await GetLastComment();
        if (await IsArtist())
        {
            var artist = (Artist)foundUser;
            artistConcerts = await ArtistRepository.GetConcertsOfArtistAsync(artist);
            artistGenres = await GenreRepository.GetGenresOfArtistAsync(artist) as List<Genre>;
        }
    }

    public async Task<bool> IsArtist()
    {
        if (await ArtistRepository.GetArtistByIdAsync(Id) != null)
            isArtist = true;
        else isArtist = false;
        return isArtist;
    }

    private async Task DeleteUser()
    {
        await UserRepositiory.DeleteUserAsync(foundUser);
        NavigationManager.NavigateTo("map");
    }

    private async Task GetLastComment()
    {
        var comments = await CommentRepository.GetCommentsOfUser(foundUser);
        int end = comments.Count - 1;
        lastComment = comments[end];
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommentRepository CommentRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository GenreRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArtistRepository ArtistRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository UserRepositiory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
