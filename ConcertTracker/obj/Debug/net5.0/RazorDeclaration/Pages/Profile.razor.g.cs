// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 5 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\ConcertTracker\ConcertTracker\Pages\Profile.razor"
       

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
        if(end >= 0)
            lastComment = comments[end];
        var concert = await DataManager.Concerts.GetConcertByIdAsync(lastComment.ConcertId);
        lastComment.Concert = concert;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommentRepository CommentRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository GenreRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArtistRepository ArtistRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository UserRepositiory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataManager DataManager { get; set; }
    }
}
#pragma warning restore 1591
