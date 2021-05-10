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
#line 3 "C:\ConcertTracker\ConcertTracker\Pages\Search.razor"
using BusinessLayer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\Pages\Search.razor"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\ConcertTracker\ConcertTracker\Pages\Search.razor"
       

    public class SearchModel
    {
        public string SearchText { get; set; }

        public ICollection<ConcertHall> concertHalls;

        public ICollection<Genre> genres;

        public ICollection<Artist> artists;

        public List<object> list = new List<object>();

        public List<object> GetAllObjects()
        {
            List<object> x = new List<object>();
            if(concertHalls != null)
                x.AddRange(concertHalls);
            if (artists != null)
                x.AddRange(artists);
            list = x;
            return list;
        }
    }

    private SearchModel searchModel = new SearchModel();

    private Genre currentGenre;

    private int i = 0;

    public void search()
    {
        List<object> x = new List<object>();
        foreach (var item in searchModel.GetAllObjects())
        {
            if (item.ToString().Contains(searchModel.SearchText))
                x.Add(item);
        }
        searchModel.list = x;
    }

    public void incI()
    {
        if (i < searchModel.list.Count() - 6)
            i += 6;
        else i = 0;
    }

    public void decI()
    {
        if (i > 5)
            i -= 6;
        else i = searchModel.list.Count() - 6;
    }

    protected override async Task OnInitializedAsync()
    {
        searchModel.concertHalls = await ConcertHallRepository.GetAllConcertHalls();
        searchModel.genres = await GenreRepository.GetAllGenres();
        searchModel.artists = await ArtistRepository.GetAllArtists();
        searchModel.GetAllObjects();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository GenreRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArtistRepository ArtistRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConcertHallRepository ConcertHallRepository { get; set; }
    }
}
#pragma warning restore 1591
