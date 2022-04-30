﻿using System.Collections;
using System.Collections.Generic;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;

namespace SfPUT.Identity
{
    public static class Configuration
    {
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>()
            {
                new("SfPUTApi", "SfPUT Api")
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>()
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new List<ApiResource>()
            {
                new ("SfPUTApi", "SfPUT Api", new []{JwtClaimTypes.Name})
                {
                    Scopes = { "SfPUTApi" }
                }
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>()
            {
                new Client
                {
                    ClientId = "sfput-web-api",
                    ClientName = "SfPUT Web",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequireClientSecret = false,
                    RequirePkce = true,
                    RedirectUris =
                    {
                        "http://.../signin-oidc"
                    },
                    AllowedCorsOrigins =
                    {
                        "http://..."
                    },
                    PostLogoutRedirectUris =
                    {
                        "http://.../signout-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "SfPUTApi"
                    },
                    AllowAccessTokensViaBrowser = true
                }
            };
    }
}
