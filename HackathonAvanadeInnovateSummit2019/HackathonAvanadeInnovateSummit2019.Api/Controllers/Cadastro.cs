using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonAvanadeInnovateSummit2019.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cadastro
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Projetos", "Mapfre" };
        }
    }
}
