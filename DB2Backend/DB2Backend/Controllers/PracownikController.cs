using DB2Backend.Models;
using DB2Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DB2Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracownikController : ControllerBase
    {


        private readonly IPracownikService _pracownikService;

        public PracownikController(IPracownikService pracownikService)
        {
            _pracownikService = pracownikService;
        }

        [Route("wstawNowegoObywatelaZAdresem")]
        [HttpPost]
        public IActionResult wstawNowegoObywatelaZAdresem([FromBody] wstawNowegoObywatelaZAdresemModel input)
        {
            var res = _pracownikService.postNowyObywatelZAdresem(input);
            return Ok(res);
        }

        [Route("getInfoOObywateluPoPeselu/{pesel}")]
        [HttpGet]
        public IActionResult getInfoOObywateluPoPeselu([FromRoute] string pesel)
        {
            var res = _pracownikService.getInfoOObywateluPoPeselu(pesel);
            if(res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

    }
}
