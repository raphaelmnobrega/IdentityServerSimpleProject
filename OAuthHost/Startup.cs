using System.IO;
using System.Security.Cryptography.X509Certificates;
using IdentityServer3.Core.Configuration;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OAuthHost.Startup))]

namespace OAuthHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var inMemoryManager = new InMemoryManager();
            var factory = new IdentityServerServiceFactory()
                .UseInMemoryUsers(inMemoryManager.GetUsers())
                .UseInMemoryScopes(inMemoryManager.GetScopes())
                .UseInMemoryClients(inMemoryManager.GetClients());

            string certificate = @"c:\users\phede\documents\visual studio 2013\Projects\OAuthTest\OAuthHost\phederal-cert.pfx";

            var options = new IdentityServerOptions
            {
                SigningCertificate = new X509Certificate2(File.ReadAllBytes(certificate), "phederalapp"),
                RequireSsl = false, // DO NOT DO THIS IN PRODUCTION
                Factory = factory
            };

            app.UseIdentityServer(options);
        }
    }
}
