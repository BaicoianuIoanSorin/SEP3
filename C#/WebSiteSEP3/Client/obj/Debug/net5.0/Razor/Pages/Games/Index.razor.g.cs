#pragma checksum "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ef3dcb0ba7515031eb3a9015a143c366e7e289"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages.Games
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using PaypalComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.Net.Mime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using Microsoft.AspNetCore.Mvc.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "container");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "text-info");
                __builder2.OpenElement(10, "h1");
                __builder2.AddContent(11, "Hi, ");
                __builder2.AddContent(12, 
#nullable restore
#line 21 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                 context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(13, "!");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-md-auto");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "type", "text");
                __builder2.AddAttribute(19, "alt", "search for game");
                __builder2.AddAttribute(20, "style", "width: 150px");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                          searchedGameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchedGameName = __value, searchedGameName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "class", "btn-outline-primary");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                    () => FilterByGameName(searchedGameName)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(27, "<i class=\"oi oi-eye\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "button");
                __builder2.AddAttribute(30, "class", "btn-outline-primary");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                  ClearSearch

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(32, "Clear");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col col-lg-3");
                __builder2.OpenElement(36, "button");
                __builder2.AddAttribute(37, "class", "btn-outline-primary");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                    () => getNewRelease()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(39, "<i class=\"oi oi-grid-three-up\"></i> New Releases\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.OpenElement(41, "button");
                __builder2.AddAttribute(42, "class", "btn-outline-primary");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                  ClearNewReleases

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(44, "Clear");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 39 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
         if (errorMessage.Equals(""))
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "container row text-info");
#nullable restore
#line 42 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                 if (searchedGameName == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(47, "<h1>Here are some games that might interest you</h1>");
#nullable restore
#line 45 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(48, "h1");
                __builder2.AddContent(49, "Results for ");
                __builder2.AddContent(50, 
#nullable restore
#line 48 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                     searchedGameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 49 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "container-fluid row");
#nullable restore
#line 52 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                 if (games != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                     foreach (var game in games.GamesStack)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-lg-4");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "card");
                __builder2.AddAttribute(58, "style", "width: 19rem");
                __builder2.OpenElement(59, "img");
                __builder2.AddAttribute(60, "class", "card-img-top");
                __builder2.AddAttribute(61, "src", 
#nullable restore
#line 58 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                GetImage(game)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(62, "alt", "Image" + " of" + " " + (
#nullable restore
#line 58 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                                               game.GameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "title", "Order" + " " + (
#nullable restore
#line 58 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                                                                            game.GameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "card-body");
                __builder2.OpenElement(67, "h3");
                __builder2.AddAttribute(68, "class", "card-title");
                __builder2.AddContent(69, 
#nullable restore
#line 60 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                            game.GameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                                    ");
                __builder2.OpenElement(71, "ul");
                __builder2.AddAttribute(72, "class", "list-group list-group-flush");
                __builder2.OpenElement(73, "li");
                __builder2.AddAttribute(74, "class", "list-group-item");
                __builder2.AddMarkupContent(75, "\r\n                                            $");
                __builder2.AddContent(76, 
#nullable restore
#line 63 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                              string.Format("{0:f}", Math.Round(game.Price, 2).ToString())

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                                    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "card-body row");
                __builder2.OpenElement(80, "button");
                __builder2.AddAttribute(81, "class", "btn btn-sm btn-dark order-button float-lg-right");
                __builder2.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                                                                  (() => MoreInformations(game.GameName))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(83, "INFO");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 72 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                     
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 75 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "text-info");
                __builder2.OpenElement(86, "h1");
                __builder2.AddContent(87, 
#nullable restore
#line 79 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                     errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 81 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(88, "nav");
                __builder2.AddAttribute(89, "class", "pagenavigation");
                __builder2.AddAttribute(90, "aria-label", "page navigation");
                __builder2.OpenElement(91, "ul");
                __builder2.AddAttribute(92, "class", "pagination");
#nullable restore
#line 88 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                 if (pageNr != 0 || newReleases.Equals(false))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(93, "li");
                __builder2.AddAttribute(94, "class", "page-item");
                __builder2.OpenElement(95, "a");
                __builder2.AddAttribute(96, "class", "page-link");
                __builder2.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                       PreviousPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(98, "Previous");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 93 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }
                else if (pageNr == 0 || errorMessage.Equals("") || searchedGameName != null || newReleases)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(99, "li");
                __builder2.AddAttribute(100, "class", "page-item disabled");
                __builder2.OpenElement(101, "a");
                __builder2.AddAttribute(102, "class", "page-link");
                __builder2.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                       PreviousPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(104, "Previous");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 99 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                 if (errorMessage.Equals("") || newReleases.Equals(false))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(105, "li");
                __builder2.AddAttribute(106, "class", "page-item");
                __builder2.OpenElement(107, "a");
                __builder2.AddAttribute(108, "class", "page-link");
                __builder2.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                       NextPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(110, "Next");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 105 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }
                else if (!errorMessage.Equals("") || searchedGameName != null || newReleases)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(111, "li");
                __builder2.AddAttribute(112, "class", "page-item disabled");
                __builder2.OpenElement(113, "a");
                __builder2.AddAttribute(114, "class", "page-link");
                __builder2.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                       NextPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(116, "Next");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 111 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(117, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<LoginComponent.Login>(118);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
 
    private GameCluster games;
    private int pageNr = 0;
    private string errorMessage;
    private bool newReleases;


    private string? searchedGameName;

    protected override async Task OnInitializedAsync()
    {
        errorMessage = "";
        try
        {
            newReleases = false;
            games = await _gameService.getGameClusterAsync(pageNr);
            SaveImageIntoClient(games);
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }


    // TODO private void CheckOutNow(string gameName)
    // {
    //     NavigationManager.NavigateTo($"/Paypal/{gameName}");
    //
    // }

    private async Task PreviousPage()
    {
        errorMessage = "";
        try
        {
            pageNr--;
            games = await _gameService.getGameClusterAsync(pageNr);
            SaveImageIntoClient(games);
        }
        catch (Exception e)
        {
            errorMessage = "There are no games on this page..";
        }
    }

    private async Task NextPage()
    {
        errorMessage = "";
        try
        {
            if (newReleases == false)
            {
                pageNr++;
                games = await _gameService.getGameClusterAsync(pageNr);
                SaveImageIntoClient(games);
            }
            else
            {
                errorMessage = "There are no more new released games";
            }
        }
        catch (Exception e)
        {
            await PreviousPage();
            pageNr++;
            errorMessage = "There are no games on this page..";
        }
    }

    public void SaveImageIntoClient(GameCluster gameCluster)
    {
        {
            foreach (var game in gameCluster.GamesStack)
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] dataArr = webClient.DownloadData(game.Photo);
                    File.WriteAllBytes($@"wwwroot/Images/Games/{game.GameName}.png", dataArr);
                }
            }
        }
    }

    public string GetImage(Game game)
    {
        return $"Images/Games/{game.GameName}.png";
    }

    private async Task FilterByGameName(string searchedGames)
    {
        errorMessage = "";
        try
        {
            if (searchedGames != null)
            {
                games = await _gameService.getSearchAsync(searchedGames);
                SaveImageIntoClient(games);
                if (games.GamesStack.Count == 0)
                {
                    errorMessage = $"There are no games for {searchedGames}";
                }
            }
            else
            {
                games = await _gameService.getGameClusterAsync(pageNr);
                SaveImageIntoClient(games);
            }
        }
        catch (Exception e)
        {
            errorMessage = $"There are no games for {searchedGames}";
        }
    }

    private async Task ClearSearch()
    {
        errorMessage = "";
        try
        {
            pageNr = 0;
            games = await _gameService.getGameClusterAsync(pageNr);
            SaveImageIntoClient(games);
        }
        catch (Exception e)
        {
            errorMessage = "There are no games on this page..";
        }
    }

    private void MoreInformations(string gameName)
    {
        NavigationManager.NavigateTo($"/GameInformation/{gameName}");
    }

    private async Task getNewRelease()
    {
        newReleases = true;
        errorMessage = "";
        games = await _gameService.getNewlyReleased();
    }

    private async Task ClearNewReleases()
    {
        newReleases = false;
        errorMessage = "";
        try
        {
            pageNr = 0;
            games = await _gameService.getGameClusterAsync(pageNr);
            SaveImageIntoClient(games);
        }
        catch (Exception e)
        {
            errorMessage = "There are no games on this page..";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService _gameService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
