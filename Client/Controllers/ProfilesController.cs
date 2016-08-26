using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace Client.Controllers
{
    public class ProfilesController : ApiController
    {
        [HttpGet]
        [Authorize]
        public async Task<IHttpActionResult> GetAsync()
        {
            var claimsPrincipal = User as ClaimsPrincipal;

            
            var username = claimsPrincipal.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;


            return Ok(username);

        }
    }
}
