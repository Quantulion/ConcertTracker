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
using DataLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using DataLayer.Entities;

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
#nullable restore
#line 9 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using BusinessLayer.Implementations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
using BusinessLayer;

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
#line 129 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
       
    int zoom = 15;

    ICollection<Concert> allConcerts;
    IList<User> allArtists = new List<User>();
    ICollection<ConcertHall> allConcertHalls;
    
    bool isArtist;
    bool isAdmin;
    
    bool addArtistClicked = false;
    bool addConcertHallClicked = false;
    
    List<Artist> concertArtists = new List<Artist>();
    Artist currentArtist;
    Admin currentAdmin = new Admin();
    Concert currentConcert = new Concert
    {
        Date = DateTime.Now,
        Artists = new List<Artist>(),
        ConcertHall = new ConcertHall()
    };

    GoogleMapPosition currentPosition = new GoogleMapPosition() { Lat = 55.7491, Lng = 37.6258 };

    protected override async Task OnInitializedAsync()
    {
        await InitializeData();
        await GetUserState();
    }

    private async Task InitializeData()
    {
        allConcerts = await DataManager.Concerts.GetAllConcertsAsync();
        allArtists = await UserManager.GetUsersInRoleAsync("Artist");
        allConcertHalls = await DataManager.ConcertHalls.GetAllConcertHallsAsync();
    }

    private async Task GetUserState()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var auser = authState.User;
        var user = await UserManager.GetUserAsync(auser);
        isArtist = auser.IsInRole("Artist");

        if (isArtist)
            currentArtist = (Artist)user;

        isAdmin = auser.IsInRole("Admin");

        if (isAdmin)
            currentAdmin = (Admin)user;
    }
    
    private void OnMapClick(GoogleMapClickEventArgs args)
    {
        currentPosition.Lat = args.Position.Lat;
        currentPosition.Lng = args.Position.Lng;
        currentConcert = new Concert
        {
            Date = DateTime.Now,
            Artists = new List<Artist>(),
            ConcertHall = new ConcertHall()
        };
        concertArtists = new List<Artist>();
    }

    private async Task OnMarkerClick(RadzenGoogleMapMarker args)
    {
        var foundConcert = await DataManager.Concerts.GetConcertByIdAsync(Convert.ToInt32(args.Title));
        currentConcert = foundConcert;
        concertArtists = await DataManager.Concerts.GetArtistsOfConcertAsync(foundConcert);
        currentConcert.Artists = concertArtists;
        currentPosition.Lat = foundConcert.Position.Lat;
        currentPosition.Lng = foundConcert.Position.Lng;
    }

    private async Task AddOrUpdateConcert()
    {
        var foundConcert = await DataManager.Concerts.GetConcertByPositionAsync(currentPosition);

        if (foundConcert != null)
        {
            await UpdateConcert(foundConcert);
        }

        else
        {
            await AddNewConcert();
        }

        currentPosition = new GoogleMapPosition() { Lat = 55.7491, Lng = 37.6258 };
        currentConcert = new Concert
        {
            Date = DateTime.Now,
            Artists = new List<Artist>(),
            ConcertHall = new ConcertHall()
        };
    }

    private async Task AddNewConcert()
    {
        currentConcert.Position = currentPosition;

        Concert concert = new Concert
        {
            Description = currentConcert.Description,
            Date = currentConcert.Date,
            Position = currentConcert.Position,
            ConcertHall = currentConcert.ConcertHall,
            ConcertHallId = currentConcert.ConcertHallId,
            Artists = currentConcert.Artists
        };
        concert.Artists.Add(currentArtist);
        await DataManager.Concerts.AddConcertAsync(concert);
        allConcerts.Add(concert);
    }

    private async Task UpdateConcert(Concert concert)
    {
        await DataManager.Concerts.UpdateConcertAsync(concert);
    }
    
    private async Task AddArtistToConcert(Artist chosenArtist)
    {
        if(currentConcert.Id != 0)
            await DataManager.Concerts.AddArtistToConcertAsync(chosenArtist, currentConcert);
        else
        {
            currentConcert.Artists.Add(chosenArtist);
        }
    }
    
    private async Task AddConcertHallToConcert(ConcertHall chosenConcertHall)
    {
        if(currentConcert.Id != 0)
            await DataManager.Concerts.SetConcertHallToConcertAsync(chosenConcertHall, currentConcert);
        else
        {
            currentConcert.ConcertHall = chosenConcertHall;
        }
    }

    private void AddArtistClick()
    {
        addArtistClicked = !addArtistClicked;
    }
    
    private void AddConcertHallClick()
    {
        addConcertHallClicked = !addConcertHallClicked;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<User> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataManager DataManager { get; set; }
    }
}
#pragma warning restore 1591
