#pragma checksum "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ed60839322f5c8d0753ec4d63975a29ebf7e34c"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages.Games
{
    #line hidden
    using System;
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
#line 7 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
using Microsoft.AspNetCore.Mvc.Formatters;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GameInformation/{GameName}")]
    public partial class GameInformation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-n41udt1sji>GameInformation</h3>");
#nullable restore
#line 14 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
 if (game != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "b-n41udt1sji");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row d-flex justify-content-center");
            __builder.AddAttribute(6, "b-n41udt1sji");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-10 mt-5 pt-5");
            __builder.AddAttribute(9, "id", "color");
            __builder.AddAttribute(10, "b-n41udt1sji");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row shadow p-3");
            __builder.AddAttribute(13, "b-n41udt1sji");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-lg-4 rounded-left");
            __builder.AddAttribute(16, "b-n41udt1sji");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card");
            __builder.AddAttribute(19, "style", "width: 19rem;");
            __builder.AddAttribute(20, "b-n41udt1sji");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "class", "card-img-top");
            __builder.AddAttribute(23, "src", 
#nullable restore
#line 22 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                                            GetImage(game)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "alt", "Image" + " of" + " " + (
#nullable restore
#line 22 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                                                                           game.GameName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "title", "Order" + " " + (
#nullable restore
#line 22 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                                                                                                        game.GameName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "b-n41udt1sji");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card-body");
            __builder.AddAttribute(30, "b-n41udt1sji");
            __builder.OpenElement(31, "h3");
            __builder.AddAttribute(32, "class", "card-title");
            __builder.AddAttribute(33, "b-n41udt1sji");
            __builder.AddContent(34, 
#nullable restore
#line 24 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                                        game.GameName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "ul");
            __builder.AddAttribute(37, "class", "list-group list-group-flush");
            __builder.AddAttribute(38, "b-n41udt1sji");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "list-group-item");
            __builder.AddAttribute(41, "b-n41udt1sji");
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "class", "font-weight-bold");
            __builder.AddAttribute(44, "b-n41udt1sji");
            __builder.AddMarkupContent(45, "\r\n                                            $");
            __builder.AddContent(46, 
#nullable restore
#line 28 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                              string.Format("{0:f}", Math.Round(game.Price, 2).ToString())

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-lg-4 bg-light");
            __builder.AddAttribute(50, "b-n41udt1sji");
            __builder.OpenElement(51, "h3");
            __builder.AddAttribute(52, "class", "mt-3 text-center");
            __builder.AddAttribute(53, "b-n41udt1sji");
            __builder.AddContent(54, 
#nullable restore
#line 36 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                                      game.GameName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        <hr class=\"badge-primary mt-0 w-25\" b-n41udt1sji>\r\n                        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row text-center");
            __builder.AddAttribute(58, "b-n41udt1sji");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-sm-6 float-right");
            __builder.AddAttribute(61, "b-n41udt1sji");
            __builder.OpenElement(62, "p");
            __builder.AddAttribute(63, "class", "font-weight-bold float-left");
            __builder.AddAttribute(64, "style", "color: yellow");
            __builder.AddAttribute(65, "b-n41udt1sji");
            __builder.AddContent(66, "IGN Rating: ");
            __builder.AddContent(67, 
#nullable restore
#line 40 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                                                                                          game.IGN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col-sm-6");
            __builder.AddAttribute(71, "b-n41udt1sji");
            __builder.OpenElement(72, "p");
            __builder.AddAttribute(73, "class", "font-weight-bold float-right");
            __builder.AddAttribute(74, "b-n41udt1sji");
            __builder.AddMarkupContent(75, "\r\n                                    ESRB Rating: ");
            __builder.AddContent(76, 
#nullable restore
#line 44 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                                  game.ESRB

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.AddMarkupContent(78, "<h3 class=\"mt-3 text-justify\" b-n41udt1sji>Description</h3>\r\n                        <hr class=\"badge-primary mt-0 w-25\" b-n41udt1sji>\r\n                        ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "row");
            __builder.AddAttribute(81, "b-n41udt1sji");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col-sm-12");
            __builder.AddAttribute(84, "b-n41udt1sji");
            __builder.OpenElement(85, "p");
            __builder.AddAttribute(86, "b-n41udt1sji");
            __builder.AddContent(87, 
#nullable restore
#line 52 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                    game.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.AddMarkupContent(89, "<h3 class=\"mt-3 text-justify\" b-n41udt1sji>Specifications</h3>\r\n                        <hr class=\"badge-primary mt-0 w-25\" b-n41udt1sji>\r\n                        ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "row");
            __builder.AddAttribute(92, "b-n41udt1sji");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-sm-12");
            __builder.AddAttribute(95, "b-n41udt1sji");
            __builder.OpenElement(96, "p");
            __builder.AddAttribute(97, "b-n41udt1sji");
            __builder.AddContent(98, 
#nullable restore
#line 59 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                    game.Specifications

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "col-lg-4 bg-light rounded-right");
            __builder.AddAttribute(102, "b-n41udt1sji");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "row");
            __builder.AddAttribute(105, "b-n41udt1sji");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "col-sm-12");
            __builder.AddAttribute(108, "b-n41udt1sji");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "class", "btn rounded");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                                                                      () => OrderNow(game.GameName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "b-n41udt1sji");
            __builder.AddContent(113, "Order now");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                                        ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "row");
            __builder.AddAttribute(117, "b-n41udt1sji");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "col-sm-12");
            __builder.AddAttribute(120, "b-n41udt1sji");
            __builder.OpenElement(121, "button");
            __builder.AddAttribute(122, "class", "btn disabled");
            __builder.AddAttribute(123, "style", "color: orange");
            __builder.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
                                                                                                            (() => AddToShoppingCart(game))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "b-n41udt1sji");
            __builder.AddContent(126, "Add to shopping cart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 94 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(127, "<h1 b-n41udt1sji>Game not found or API still works...</h1>");
#nullable restore
#line 98 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(128, 
#nullable restore
#line 100 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
 errorMessage

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
       

    [Parameter]
    public string GameName { get; set; }

    [Inject]
    IJSRuntime _jsRuntime { get; set; }

    private Game game;
    private string errorMessage;
    private Boolean orderNowPressed = false;

    protected override async Task OnInitializedAsync()
    {
        errorMessage = "";
        try
        {
            game = await GameService.getGameAsync(GameName);
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (game != null)
            {
                var value = Math.Round(game.Price, 2);
                await _jsRuntime.InvokeVoidAsync("LoadButtonPaypal", value, game.GameName);
            }
        }
    }

    public string GetImage(Game game)
    {
        return $"Images/Games/{game.GameName}.png";
    }

    public void OrderNow(string gameName)
    {
        NavigationManager.NavigateTo($"/Paypal/{gameName}");
    }

    public void AddToShoppingCart(Game game)
    {
    //TODO later has to be implemented
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService GameService { get; set; }
    }
}
#pragma warning restore 1591
