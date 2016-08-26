using System;
using System.IdentityModel.Tokens;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Microsoft.Owin.Security.Jwt;
using Owin;

[assembly: OwinStartup(typeof(Client.App_Start.Startup))]

namespace Client.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            var config = GlobalConfiguration.Configuration;

            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions()
            {
                Authority = "http://localhost:45204"
            });

            //var certificate = new X509Certificate2(Convert.FromBase64String("MIIEGzCCAwOgAwIBAgIJALZsYQ80GJftMA0GCSqGSIb3DQEBCwUAMIGjMQswCQYDVQQGEwJDQTEZMBcGA1UECAwQQnJpdGlzaCBDb2x1bWJpYTESMBAGA1UEBwwJVmFuY291dmVyMRAwDgYDVQQKDAdWYW5oYWNrMR0wGwYDVQQLDBRTb2Z0d2FyZSBEZXZlbG9wbWVudDEQMA4GA1UEAwwHVmFuaGFjazEiMCAGCSqGSIb3DQEJARYTcmFwaGFlbEB2YW5oYWNrLmNvbTAeFw0xNjA4MjQxOTQzMzNaFw0yNjA4MjIxOTQzMzNaMIGjMQswCQYDVQQGEwJDQTEZMBcGA1UECAwQQnJpdGlzaCBDb2x1bWJpYTESMBAGA1UEBwwJVmFuY291dmVyMRAwDgYDVQQKDAdWYW5oYWNrMR0wGwYDVQQLDBRTb2Z0d2FyZSBEZXZlbG9wbWVudDEQMA4GA1UEAwwHVmFuaGFjazEiMCAGCSqGSIb3DQEJARYTcmFwaGFlbEB2YW5oYWNrLmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBANODmtpKbJIpPd8qVQRHzrCt6klivvHpyRuU0Z5HEbSptLRtmJIK9h/GM3PWfrGMbIdJWGD8ibf/DpEhvS7YT89YHpEjPOIi+hMp7yeVVfoKM5UBkBaXxQXJdrAWh7HMjtBqcLToQ9+YB4Vrz+68bm/MIjksqXzwO9yUP4xtPa/NKenRTO33IYLKlsche26P42z+L+DIJJbABaske94jt/JMLaZv+Pm18R8vJdvGDap1kONWFaWI4sDGHjvMP4qkWnBQtHpzhV6HUJVLKlGajS4pZ4dHtkGvYPEBLjVUpU2p5biGyPmtb7EQ6KAxzxZOz3T0si+G8bXNwzAvDldl1mkCAwEAAaNQME4wHQYDVR0OBBYEFCxfkqwjgp5JsVfcYKw9YztfVW5tMB8GA1UdIwQYMBaAFCxfkqwjgp5JsVfcYKw9YztfVW5tMAwGA1UdEwQFMAMBAf8wDQYJKoZIhvcNAQELBQADggEBAG0syeSVV4DcShS83DLX2PxOP3emMLjXQQZNlgkfiTqIjoWGC/AXugadJMwmVu/v4jCE7+arIvdBqj9kIb5uQa1XTphjwYlc33Hsw2/rguqBL/rX2Yc9sVuuSMRD6I1bwG1t1A/xGJ05LRBUudC2LBRyJ6cM8zuisSA2owMxdNdy2aB9GyOdvLT8RYJjLvILehshM/bi4kdxU3Tcxd9/Oa59CWdjP5fx17QZPe9+TD2ndGN1pmQkw7HFQ8//vyquznJEI9rUADUXVTaArxmK6B4UQy2HaQ1kpFboePz+QVOT9nNf6X8dumvuDI7X6Oit7VcNgwx8nY6j4xZECk/8Oqs="));

            //string certificate = @"c:\users\phede\documents\visual studio 2013\Projects\OAuthTest\Client\vanhack-cert-public.pem";

            //app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
            //{
            //    AllowedAudiences = new[] { "http://localhost:45204/resources" },
            //    TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidAudience = "http://localhost:45204/resources",
            //        ValidIssuer = "http://localhost:45204/",
            //        IssuerSigningKey = new X509SecurityKey(new X509Certificate2(File.ReadAllBytes(certificate), "vanhackapp"))
            //    }
            //});

            app.UseWebApi(config);
        }
    }
}
