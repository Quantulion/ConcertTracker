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
#line 3 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHall.razor"
using BusinessLayer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHall.razor"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/concerthall/{Id}")]
    public partial class ConcertHall : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHall.razor"
       

    [Parameter]
    public string Id { get; set; }

    protected User foundUser = new User();
    protected List<Concert> artistConcerts = new List<Concert>();

    protected override async Task OnInitializedAsync()
    {
        foundUser = await UserRepositiory.GetUserById(Id);
        if (IsArtist())
        {
            artistConcerts = await ArtistRepository.GetConcertsOfArtist((Artist)foundUser);
        }
    }

    public bool IsArtist()
    {
        bool isArtist;
        if (ArtistRepository.GetArtistById(Id) != null)
            isArtist = true;
        else isArtist = false;
        return isArtist;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArtistRepository ArtistRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository UserRepositiory { get; set; }
    }
}
#pragma warning restore 1591
