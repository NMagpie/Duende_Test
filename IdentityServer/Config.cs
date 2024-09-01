using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            [
                new IdentityResources.OpenId()
            ];

        public static IEnumerable<ApiScope> ApiScopes =>
            [
                    new ApiScope(name: "test-api", displayName: "Test Api")
            ];

        public static IEnumerable<Client> Clients =>
            [
                    new Client
                    {
                        ClientId = "TestClient",
                        AllowedGrantTypes = GrantTypes.Code,
                        ClientSecrets =
                        {
                            new Secret("TestClient".Sha256())
                        },
                        AllowedScopes = 
                        { 
                            IdentityServerConstants.StandardScopes.OpenId,
                        },
                        RedirectUris = { "https://localhost:5002/signin-oidc" },
                        //PostLogoutRedirectUris = { "https://localhost:5002/signout-callback-iodc" },
                    }
            ];
    }
}