using DB2Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DB2Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObywatelController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var context = new Db2Context();
            var res = context.procentPlci.FromSql($"procentPlci");
            Console.Write(res);
            return Ok(res);
        }




    }
}
