#pragma checksum "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9d881eb995c61599df583bca9f21c15135e9a7d"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
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
#line 47 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
using PaypalComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
using System.Net.Mime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
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
                __builder2.AddAttribute(3, "class", "text-info");
                __builder2.OpenElement(4, "h1");
                __builder2.AddContent(5, "Hi, ");
                __builder2.AddContent(6, 
#nullable restore
#line 60 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                     context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, "!");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "container row align-top float-right");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-lg-4");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "alt", "search for game");
                __builder2.AddAttribute(16, "style", "width: 150px");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                                      searchedGameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchedGameName = __value, searchedGameName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "button");
                __builder2.AddAttribute(21, "class", "btn-outline-primary");
                __builder2.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                                () => FilterByGameName(searchedGameName)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(23, "<i class=\"oi oi-eye\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 70 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
         if (errorMessage.Equals(""))
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "text-info");
#nullable restore
#line 73 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                 if (searchedGameName == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(26, "<h1>Here are some games that might interest you</h1>");
#nullable restore
#line 76 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "h1");
                __builder2.AddContent(28, "Results for ");
                __builder2.AddContent(29, 
#nullable restore
#line 79 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                     searchedGameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 80 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "container-fluid row");
#nullable restore
#line 83 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                 foreach (var game in games.GamesStack)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "card col-sm-3");
                __builder2.OpenElement(35, "a");
                __builder2.AddAttribute(36, "asp-page", "/order");
                __builder2.AddAttribute(37, "asp-route-id", 
#nullable restore
#line 86 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                                game.GameId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(38, "title", "Order" + " " + (
#nullable restore
#line 86 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                                                           game.GameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "productInfo");
                __builder2.OpenElement(41, "h3");
                __builder2.AddContent(42, 
#nullable restore
#line 88 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                         game.GameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                    ");
                __builder2.OpenElement(44, "img");
                __builder2.AddAttribute(45, "class", "product-image img-fluid img-thumbnail");
                __builder2.AddAttribute(46, "src", 
#nullable restore
#line 89 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                                                             GetImage(game)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(47, "alt", "Image" + " of" + " " + (
#nullable restore
#line 89 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                                                                                            game.GameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenElement(49, "div");
                __builder2.OpenElement(50, "p");
                __builder2.AddAttribute(51, "class", "price float-left ");
                __builder2.AddContent(52, "$");
                __builder2.AddContent(53, 
#nullable restore
#line 93 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                               string.Format("{0:f}", Math.Round(game.Price, 2).ToString())

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                ");
                __builder2.AddMarkupContent(55, "<button class=\"btn btn-sm btn-dark order-button float-right\">Order Now (Test)</button>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                            <br>");
                __builder2.CloseElement();
#nullable restore
#line 101 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 103 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "text-info");
                __builder2.OpenElement(59, "h1");
                __builder2.AddContent(60, 
#nullable restore
#line 107 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                     errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 109 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(61, "nav");
                __builder2.AddAttribute(62, "class", "pagenavigation");
                __builder2.AddAttribute(63, "aria-label", "page navigation");
                __builder2.OpenElement(64, "ul");
                __builder2.AddAttribute(65, "class", "pagination");
#nullable restore
#line 116 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                 if (pageNr != 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(66, "li");
                __builder2.AddAttribute(67, "class", "page-item");
                __builder2.OpenElement(68, "a");
                __builder2.AddAttribute(69, "class", "page-link");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 119 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                       PreviousPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(71, "Previous");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 121 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                }
                else if(pageNr == 0 || errorMessage.Equals(""))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(72, "li");
                __builder2.AddAttribute(73, "class", "page-item disabled");
                __builder2.OpenElement(74, "a");
                __builder2.AddAttribute(75, "class", "page-link");
                __builder2.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 125 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                       PreviousPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(77, "Previous");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 127 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                 if (errorMessage.Equals(""))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(78, "li");
                __builder2.AddAttribute(79, "class", "page-item");
                __builder2.OpenElement(80, "a");
                __builder2.AddAttribute(81, "class", "page-link");
                __builder2.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 130 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                     NextPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(83, "Next");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 132 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                    
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(84, "li");
                __builder2.AddAttribute(85, "class", "page-item disabled");
                __builder2.OpenElement(86, "a");
                __builder2.AddAttribute(87, "class", "page-link");
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 137 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                                                       NextPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(89, "Next");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 139 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(90, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<LoginComponent.Login>(91);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 151 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Index.razor"
 
    private GameCluster games;
    private int pageNr = 0;
    private string errorMessage;

    private string? searchedGameName;

    protected override async Task OnInitializedAsync()
    {
        errorMessage = "";
        try
        {
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
            pageNr++;
            games = await _gameService.getGameClusterAsync(pageNr);
            SaveImageIntoClient(games);
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService _gameService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
