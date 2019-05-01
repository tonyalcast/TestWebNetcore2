using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebNetcore2.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route("values")]
        public List<String> Get()
        {
            List<String> resultado = new List<String>
            {
                "API en .Net Core 2.1.",
                "Implementada por TonyAlcast."
            };
            return resultado;
        }
    }
}
