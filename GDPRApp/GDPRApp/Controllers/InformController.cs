using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using GDPRApp.IService;
using GDPRApp.Model;
using GDPRApp.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GDPRApp.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class InformController : ControllerBase
    {
        IInformRepository informRepository = new InformRepository();

        [HttpGet]
        [EnableCors("CorsPolicy")]
        public void Get() { }



        [HttpPost]
        [EnableCors("CorsPolicy")]
        public IActionResult Post([FromBody] RegUser regUser)
        {
            var informUser = new RegUser();
            try
            {
                if (ModelState.IsValid)
                {
                    informUser = informRepository.Create(regUser);

                    return Ok(informUser);
                }
                else
                {
                    return BadRequest(regUser);
                }
            }
            catch
            {
                return BadRequest(regUser);

            }
        }
    }
}