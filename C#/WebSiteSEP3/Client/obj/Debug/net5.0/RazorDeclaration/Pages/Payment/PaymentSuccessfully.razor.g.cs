// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages.Payment
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PaymentSuccessfully.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PaymentSuccessfully.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PaymentSuccessfully.razor"
using System.Security.Cryptography.X509Certificates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PaymentSuccessfully.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PaymentSuccessfully.razor"
using Microsoft.VisualBasic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PaymentSuccessfully/{GameName}/{TransactionId}")]
    public partial class PaymentSuccessfully : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PaymentSuccessfully.razor"
       

    [Parameter]
    public string GameName { get; set; }

    [Parameter]
    public string TransactionId { get; set; }

    private string _key = "";
    private Boolean buttonPressed;
    private ClaimsPrincipal _claimsPrincipal;

    //Variables for game and user to get receipt
    public Game game { get; set; }
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
        try
        {
            game = await _gameService.getGameAsync(GameName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public async Task GetReceipt()
    {
        try
        {
            _user = await _userService.GetUser(username);
            buttonPressed = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public async Task GetKey()
    {
        _key = "";
        try
        {
            if (_key.Length > 0)
            {
                _key += "\n You already got the key.";
            }
            else
            {
                GameKey gameKey = await _gameService.getProductKeyAsync(game.GameId);
                _key = gameKey.Key;
            }
        }
        catch (Exception e)
        {
            _key = e.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService _gameService { get; set; }
    }
}
#pragma warning restore 1591
