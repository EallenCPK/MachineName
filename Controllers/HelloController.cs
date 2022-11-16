using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpOverrides;

namespace MachineName.Controllers
{
    [Route("/Hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET: api/<HelloController>
        [HttpGet]
        public string Get()
        {
            string result = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            return result;
        }
    }
}
