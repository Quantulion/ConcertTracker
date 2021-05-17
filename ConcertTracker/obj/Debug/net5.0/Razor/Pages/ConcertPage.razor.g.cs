#pragma checksum "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c4859ff2fd78d512f6075eba3a8d4d9ff635bd"
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
#line 3 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
using BusinessLayer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
using DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/concert/{Id}")]
    public partial class ConcertPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "concertPage");
            __builder.AddMarkupContent(2, "<a href class=\"mainText\">ConcertTracker</a>\r\n    <img src=\"Images/manhattan-1674404_1920 1.png\" alt class=\"concertImage\">\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "concertContainer");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "concertItem");
            __builder.AddMarkupContent(7, "<p class=\"hdr\">Концертная площадка:</p>");
#nullable restore
#line 24 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
             if (foundConcert.ConcertHall != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "href", "/concerthall/" + (
#nullable restore
#line 26 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                                       foundConcert.ConcertHall.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, 
#nullable restore
#line 26 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                                                                     foundConcert.ConcertHall.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "concertItem");
            __builder.AddMarkupContent(14, "<p class=\"hdr\">Описание:</p>\r\n            ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, 
#nullable restore
#line 32 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                 foundConcert.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "concertItem");
            __builder.AddMarkupContent(20, "<p class=\"hdr\">Дата:</p>\r\n            ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, 
#nullable restore
#line 37 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                foundConcert.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "concertItem");
            __builder.AddMarkupContent(26, "<p class=\"hdr\">Артисты:</p>");
#nullable restore
#line 41 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
             foreach (var artist in concertArtists)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "/user/" + (
#nullable restore
#line 43 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                                artist.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, 
#nullable restore
#line 43 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                                            artist.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 44 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(31);
            __builder.AddAttribute(32, "Roles", "Admin");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(34, "button");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                                                       DeleteConcert

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(36, "Delete");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(38);
            __builder.AddAttribute(39, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 50 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                  newComment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 50 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                                              AddComment

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(41, "class", "commentSection");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(43, "<p class=\"hdr\">Comments:</p>\r\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "commentInput");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(46);
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                                     newComment.Content

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newComment.Content = __value, newComment.Content))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newComment.Content));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.AddMarkupContent(51, "<button type=\"submit\">Publish</button>");
                __builder2.CloseElement();
#nullable restore
#line 56 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
     foreach (var comment in concertComments)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "comment");
                __builder2.OpenElement(54, "img");
                __builder2.AddAttribute(55, "src", "/uploads/" + (
#nullable restore
#line 59 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                                comment.User.Photo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "alt");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenElement(58, "a");
                __builder2.AddAttribute(59, "href", "/user/" + (
#nullable restore
#line 60 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                            comment.UserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "class", "commentData");
                __builder2.OpenElement(61, "p");
                __builder2.AddContent(62, 
#nullable restore
#line 61 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                    comment.User.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.OpenElement(64, "p");
                __builder2.AddContent(65, 
#nullable restore
#line 62 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                    comment.Content

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.OpenElement(67, "p");
                __builder2.AddContent(68, 
#nullable restore
#line 63 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
                    comment.PublishTime

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 66 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\ConcertTracker\ConcertTracker\Pages\ConcertPage.razor"
       
    [Parameter]
    public string Id { get; set; }

    private Concert foundConcert = new Concert();
    private List<Artist> concertArtists = new List<Artist>();
    private List<Comment> concertComments = new List<Comment>();
    private User currentUser = new User();
    private Comment newComment = new Comment();

    protected override async Task OnInitializedAsync()
    {
        foundConcert = await ConcertRepository.GetConcertByIdAsync(Convert.ToInt32(Id));
        concertArtists = await ConcertRepository.GetArtistsOfConcertAsync(foundConcert);

        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        currentUser = await userManager.GetUserAsync(authState.User);

        await GetAllComments();
    }

    private async Task DeleteConcert()
    {
        await ConcertRepository.DeleteConcertAsync(foundConcert);
        NavigationManager.NavigateTo("map");
    }

    private async Task AddComment()
    {
        newComment.PublishTime = DateTime.Now;
        await CommentRepository.AddCommentAsync(newComment, currentUser, foundConcert);
    }

    private async Task<List<Comment>> GetAllComments()
    {
        concertComments = await ConcertRepository.GetCommentsOfConcertAsync(foundConcert);
        List<Comment> comments = new List<Comment>();
        foreach (var comment in concertComments)
        {
            var user = await UserRepository.GetUserByIdAsync(comment.UserId);
            comment.User = user;
        }
        return concertComments;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConcertRepository ConcertRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository UserRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<User> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommentRepository CommentRepository { get; set; }
    }
}
#pragma warning restore 1591
