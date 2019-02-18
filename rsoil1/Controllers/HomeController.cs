using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace rsoil1.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Meow";
        }

        [HttpGet("mult")]
        public ActionResult<int> Get(int? a, int? b)
        {
            if (a == null || b == null)
                return 0;
            else
                return a * b;
        }
    }
}