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
#line 3 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHalls.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHalls.razor"
using BusinessLayer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHalls.razor"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHalls.razor"
using DataLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHalls.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHalls.razor"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHalls.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHalls.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/concerthalls")]
    public partial class ConcertHalls : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\ConcertTracker\ConcertTracker\Pages\ConcertHalls.razor"
       

    private ICollection<ConcertHall> concertHalls;
    ConcertHall newConcertHall = new ConcertHall();
    protected override async Task OnInitializedAsync()
    {
        concertHalls = await ConcertHallRep.GetAllConcertHalls();
    }
    private async Task InsertConcertHall()
    {

        await GetFileAndSetPhoto();

        ConcertHall p = new ConcertHall
        {
            Name = newConcertHall.Name,
            Address = newConcertHall.Address,
            Description = newConcertHall.Description,
            Photo = newConcertHall.Photo
        };

        await ConcertHallRep.AddConcertHall(p);

        concertHalls.Add(p);

        newConcertHall = new ConcertHall();
    }

    IReadOnlyList<IBrowserFile> selectedFiles;

    async Task LoadFile(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
    }

    private async Task GetFileAndSetPhoto()
    {
        foreach (var file in selectedFiles)
        {
            Stream stream = file.OpenReadStream();
            var path = $"{env.WebRootPath}\\uploads\\{file.Name}";
            newConcertHall.Photo = file.Name;
            FileStream fs = File.Create(path);
            await stream.CopyToAsync(fs);
            stream.Close();
            fs.Close();
        }
        this.StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConcertHallRepository ConcertHallRep { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ApplicationDbContext> ContextFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPhotoManager PhotoManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
    }
}
#pragma warning restore 1591
