#pragma checksum "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9083d8e6e5f34ae8b9e3d4d48864357b6b6086"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\Pages\Login.razor"
using Client.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"wrapper\" b-zy7o9g18h1></div>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "b-zy7o9g18h1");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row no-gutters");
            __builder.AddAttribute(6, "b-zy7o9g18h1");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-box");
            __builder.AddAttribute(9, "id", "function");
            __builder.AddAttribute(10, "b-zy7o9g18h1");
            __builder.AddMarkupContent(11, "<h1 class=\"font-weight-bold py-3\" b-zy7o9g18h1>Login</h1>\r\n                ");
            __builder.AddMarkupContent(12, "<h4 b-zy7o9g18h1>Sign into your account</h4>\r\n                ");
            __builder.OpenElement(13, "form");
            __builder.AddAttribute(14, "class", "input-group");
            __builder.AddAttribute(15, "b-zy7o9g18h1");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "placeholder", "user name");
            __builder.AddAttribute(19, "class", "input-field");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\Pages\Login.razor"
                                                                            username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(22, "b-zy7o9g18h1");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "password");
            __builder.AddAttribute(26, "placeholder", "password");
            __builder.AddAttribute(27, "class", "input-field");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\Pages\Login.razor"
                                                                                   password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(30, "b-zy7o9g18h1");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "submit-btn");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\Pages\Login.razor"
                                                                           PerformLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "b-zy7o9g18h1");
            __builder.AddContent(37, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "color:red");
            __builder.AddAttribute(41, "b-zy7o9g18h1");
            __builder.AddContent(42, 
#nullable restore
#line 16 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\Pages\Login.razor"
                                             errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.AddMarkupContent(44, "<p b-zy7o9g18h1>Don\'t have an account? <a href=\"/Register\" b-zy7o9g18h1>Register here</a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\WebSiteSEP3\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";

        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
