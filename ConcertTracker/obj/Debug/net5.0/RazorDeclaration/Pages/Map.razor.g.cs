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
#line 134 "C:\ConcertTracker\ConcertTracker\Pages\Map.razor"
       
    int zoom = 15;
    string clickedPosition = "";

    private ICollection<ConcertHall> concertHalls;
    private ICollection<Concert> concerts;
    private IList<User> allArtists = new List<User>();
    private ICollection<ConcertHall> allConcertHalls;
    private bool isArtist;
    private bool isAdmin;
    private bool addArtistClicked = false;
    private bool addConcertHallClicked = false;
    private List<Artist> concertArtists = new List<Artist>();
    Artist artist;
    Admin admin = new Admin();
    Concert newConcert = new Concert
    {
        Date = DateTime.Now,
        Artists = new List<Artist>(),
        ConcertHall = new ConcertHall()
    };

    GoogleMapPosition pos = new GoogleMapPosition() { Lat = 55.7491, Lng = 37.6258 };

    protected override async Task OnInitializedAsync()
    {

        //await InsertData.InsertAllData();
        
        concertHalls = await ConcertHallRep.GetAllConcertHallsAsync();
        concerts = await ConcertRepository.GetAllConcertsAsync();
        allArtists = await userManager.GetUsersInRoleAsync("Artist");
        allConcertHalls = await ConcertHallRep.GetAllConcertHallsAsync();
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var auser = authState.User;
        var user = await userManager.GetUserAsync(auser);
        isArtist = auser.IsInRole("Artist");

        if (isArtist)
            artist = (Artist)user;

        isAdmin = auser.IsInRole("Admin");

        if (isAdmin)
            admin = (Admin)user;
    }

    void OnMapClick(GoogleMapClickEventArgs args)
    {
        clickedPosition = $"Map clicked LAT: {args.Position.Lat}, LNG: {args.Position.Lng}";
        pos.Lat = args.Position.Lat;
        pos.Lng = args.Position.Lng;
        newConcert = new Concert
        {
            Date = DateTime.Now,
            Artists = new List<Artist>(),
            ConcertHall = new ConcertHall()
        };
        concertArtists = new List<Artist>();
    }

    private async Task OnMarkerClick(RadzenGoogleMapMarker args)
    {
        clickedPosition = $"Map {args.Title} clicked LAT: {args.Position.Lat}, LNG: {args.Position.Lng}";
        var foundConcert = await ConcertRepository.GetConcertByIdAsync(Convert.ToInt32(args.Title));
        newConcert = foundConcert;
        concertArtists = await ConcertRepository.GetArtistsOfConcertAsync(foundConcert);
        newConcert.Artists = concertArtists;
        pos.Lat = foundConcert.Position.Lat;
        pos.Lng = foundConcert.Position.Lng;
    }

    private async Task InsertConcert()
    {
        var conc = await ConcertRepository.GetConcertByPositionAsync(pos);

        newConcert.Position = pos;

        Concert concert = new Concert
        {
            Description = newConcert.Description,
            Date = newConcert.Date,
            Position = newConcert.Position,
            ConcertHall = newConcert.ConcertHall,
            ConcertHallId = newConcert.ConcertHallId,
            Artists = newConcert.Artists
        };

        if (conc != null)
        {
            await ConcertRepository.UpdateConcertAsync(conc);
        }

        else
        {
            concert.Artists.Add(artist);

            await ConcertRepository.AddConcertAsync(concert);

            concerts.Add(concert);
        }

        pos = new GoogleMapPosition() { Lat = 55.7491, Lng = 37.6258 };
        newConcert = new Concert
        {
            Date = DateTime.Now,
            Artists = new List<Artist>(),
            ConcertHall = new ConcertHall()
        };
    }

    private async Task AddArtistToConcert(Artist chosenArtist)
    {
        if(newConcert.Id != 0)
            await ConcertRepository.AddArtistToConcertAsync(chosenArtist, newConcert);
        else
        {
            newConcert.Artists.Add(chosenArtist);
        }
    }
    
    private async Task AddConcertHallToConcert(ConcertHall chosenConcertHall)
    {
        if(newConcert.Id != 0)
            await ConcertRepository.SetConcertHallToConcertAsync(chosenConcertHall, newConcert);
        else
        {
            newConcert.ConcertHall = chosenConcertHall;
        }
    }

    private void clickAddArtist()
    {
        addArtistClicked = !addArtistClicked;
    }
    
    private void clickAddConcertHall()
    {
        addConcertHallClicked = !addConcertHallClicked;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository UserRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConcertHallRepository ConcertHallRep { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConcertRepository ConcertRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<User> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ApplicationDbContext> ContextFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataManager DataManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInsertData InsertData { get; set; }
    }
}
#pragma warning restore 1591
