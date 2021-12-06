#pragma checksum "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40cf4444ba77b174fd6dbd4e3b50343df4b51477"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
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
#line 2 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GameLibrary")]
    public partial class GameLibary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "panel panel-info");
                __builder2.AddMarkupContent(4, "<div class=\"panel-heading\"><h3 class=\"panel-title\">Purchased Games Library</h3></div>\r\n            ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "panel-body");
                __builder2.AddMarkupContent(7, "<div id=\"update-message\"></div>\r\n                ");
                __builder2.OpenElement(8, "table");
                __builder2.AddAttribute(9, "class", "table table-striped table-hover ");
                __builder2.AddMarkupContent(10, "<thead><tr><th>\r\n                            Game Name\r\n                        </th>\r\n                        <th>\r\n                            Game Key\r\n                        </th>\r\n                        <th></th></tr></thead>");
#nullable restore
#line 28 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                     if (_gameCluster != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                         foreach (var game in _gameCluster.GamesStack)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(11, "tr");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 34 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                                     game.GameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                                ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 37 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                                     game.GameKey.Key

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 40 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                     if (_gameCluster == null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(17, "<div class=\"custom-bg\"><p>You have not purchased a game yet. Go buy one!</p></div>");
#nullable restore
#line 47 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
       
    GameCluster _gameCluster;

    string errorMessage ="";

    private ClaimsPrincipal _claimsPrincipal;

    private User _user = new User();

    public string username { get; set; }

    [CascadingParameter]
    protected Task<AuthenticationState> AuthState { get; set; }

    protected override async void OnParametersSet()
    {
        if (AuthState != null)
        {
            _claimsPrincipal = (await AuthState).User;
            username = _claimsPrincipal.Identity.Name;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        errorMessage = "";
        try
        {
            OnParametersSet();
            _gameCluster = await GameService.getLibraryAsync(username);
        }
        catch (Exception e)
        {
            Console.WriteLine(errorMessage = e.Message);
            Console.WriteLine("Error while getting game library");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService GameService { get; set; }
    }
}
#pragma warning restore 1591
