using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            var ips = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList;
            string result = string.Empty;

            foreach (var ip in ips)
            {
                result += ip.ToString();
                result += "\n";
            }
            return result;
        }
    }
}
