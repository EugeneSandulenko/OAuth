using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OAuth.Infrastructure
{
    public class InMemoryConfig
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new ApiResource[]
            {
                new ApiResource("AothDemo","DemoAuth")
            };
        }

        public static IEnumerable<Client> ApiClients()
        {
            return new Client[]
            {
                new Client
                {
                   ClientId = "AothDemo",
                   ClientSecrets = new [] { new Secret("demo".Sha256()) },
                   AllowedGrantTypes = GrantTypes .ResourceOwnerPasswordAndClientCredentials,
                   AllowedScopes = new [] { "AothDemo" }
                }
            };
        }

        public static IEnumerable<TestUser> Users()
        {
            return new []
            {
               new TestUser
               {
                   SubjectId = "123",
                   Username = "Demo",
                   Password = "demoPassword"
               }
            };
        }

    }
}
