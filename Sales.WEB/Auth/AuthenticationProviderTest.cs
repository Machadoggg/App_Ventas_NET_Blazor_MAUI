using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //await Task.Delay(3000);
            var anonimous = new ClaimsIdentity();
            var jorgeUser = new ClaimsIdentity(new List<Claim>
            {
                new Claim("FirstName", "Jorge"),
                new Claim("LastName", "Macha"),
                new Claim(ClaimTypes.Name, "machadoggg@yopmail.com"),
                new Claim(ClaimTypes.Role, "Admin")
            },
            authenticationType: "test");
            //return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonimous)));
         return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(jorgeUser)));

        }
    }
}
