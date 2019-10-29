using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using GDPRApp.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace GDPRApp.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        [EnableCors("CorsPolicy")]
        public void Get() { }



        [HttpPost]
        [EnableCors("CorsPolicy")]
        public string Post([FromBody] AppUser appuser)
        {
            if (!string.IsNullOrEmpty(appuser.UserEmail) && !string.IsNullOrEmpty(appuser.UserPassword))
            {
                if (appuser.UserPassword.Equals(appuser.UserPasswordRepeat))
                {
                    if (appuser.Consent)
                    {
                        return "Ok";
                    }
                    else
                    {
                        return "Will not register because you have not given consent";
                    }
                }
                else
                {
                    return "Passwords not match!!!";
                }
            }
            else
            {
                return "Email and password is required";
            }
        }

    }
}
