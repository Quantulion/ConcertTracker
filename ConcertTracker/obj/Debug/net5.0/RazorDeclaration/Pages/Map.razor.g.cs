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
#line 3 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using BusinessLayer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/map")]
    public partial class Map : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
       
    int zoom = 6;
    string clickedPosition = "";

    private ICollection<ConcertHall> concertHalls;
    private ICollection<Concert> concerts;
    private bool isArtist;
    private List<Artist> concertArtists = new List<Artist>();
    Artist artist;
    Concert newConcert = new Concert();
    GoogleMapPosition pos = new GoogleMapPosition() { Lat = 55.7491, Lng = 37.6258 };

    protected override async Task OnInitializedAsync()
    {
        concertHalls = await ConcertHallRep.GetAllConcertHalls();
        concerts = await ConcertRepository.GetAllConcerts();
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var auser = authState.User;
        var user = await userManager.GetUserAsync(auser);
        artist = (Artist)user;
        isArtist = auser.IsInRole("Artist");
    }
    void OnMapClick(GoogleMapClickEventArgs args)
    {
        clickedPosition = $"Map clicked LAT: {args.Position.Lat}, LNG: {args.Position.Lng}";
        pos.Lat = args.Position.Lat;
        pos.Lng = args.Position.Lng;
        newConcert = new Concert();
    }
    private async Task OnMarkerClick(RadzenGoogleMapMarker args)
    {
        clickedPosition = $"Map {args.Title} clicked LAT: {args.Position.Lat}, LNG: {args.Position.Lng}";
        var foundConcert = await ConcertRepository.GetConcertById(Convert.ToInt32(args.Title));
        newConcert = foundConcert;
        concertArtists = await ConcertRepository.GetArtistsOfConcert(foundConcert);
    }
    private async Task InsertConcert()
    {
        var concertHall = await ConcertHallRep.GetConcertHallByAddress("Street Concert");
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = await userManager.GetUserAsync(authState.User);
        artist = (Artist)user;

        newConcert.Position = pos;
        Concert concert = new Concert
        {
            Description = newConcert.Description,
            Date = newConcert.Date,
            Position = newConcert.Position,
            ConcertHall = concertHall,
            ConcertHallId = concertHall.Id,
            Artists = new List<Artist>()
        };
        concert.Artists.Add(artist);

        await ConcertRepository.AddConcert(concert);

        concerts.Add(concert);

        pos = new GoogleMapPosition() { Lat = 55.7491, Lng = 37.6258 };
        newConcert = new Concert();


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository UserRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConcertHallRepository ConcertHallRep { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConcertRepository ConcertRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<User> userManager { get; set; }
    }
}
#pragma warning restore 1591
