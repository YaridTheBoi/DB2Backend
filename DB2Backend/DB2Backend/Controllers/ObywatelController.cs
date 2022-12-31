using DB2Backend.Models;
using DB2Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DB2Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObywatelController : ControllerBase
    {



        private readonly IObywatelService _obywatelService;

        public ObywatelController(IObywatelService obywatelService)
        {
            _obywatelService = obywatelService;
        }


        [Route("getProcentPlci")]
        [HttpGet]
        public IActionResult GetProcentPlci()
        {
            var res = _obywatelService.getProcentPlci();
            return Ok(res);
        }


        [Route("getProcentKobietZWyzszym")]
        [HttpGet]
        public IActionResult GetProcentKobietZWyzszym()
        {
            var res = _obywatelService.getProcentKobietZWyzszym();
            return Ok(res);
        }

        [Route("getProcentMezczyznZWyzszym")]
        [HttpGet]
        public IActionResult GetProcentMezczyznZWyzszym()
        {
            var res = _obywatelService.getProcentMezczyznZWyzszym();
            return Ok(res);
        }


        [Route("getProcentMieszkajacychWKraju/{kraj}")]
        [HttpGet]
        public IActionResult GetProcentMieszkajacychWKraju([FromRoute] string kraj)
        {
            var res = _obywatelService.getProcentMieszkajacyWkraju(kraj);
            return Ok(res);
        }

        [Route("getProcentObywateliMowiacychPoPolskuNieOjczyscie")]
        [HttpGet]
        public IActionResult GetProcentObywateliMowiacychPoPolskuNieOjczyscie()
        {
            var res = _obywatelService.getProcentObywateliMowiacychPoPolskuNieOjczyscie();
            return Ok(res);
        }




        [Route("getProcentObywateliONazwisku/{nazwisko}")]
        [HttpGet]
        public IActionResult GetProcentObywateliONazwisku([FromRoute] string nazwisko)
        {
            var res = _obywatelService.getProcentObywateliONazwisku(nazwisko);
            return Ok(res);
        }


        [Route("getProcentObywateliZOjczystym/{ojczysty}")]
        [HttpGet]
        public IActionResult getProcentObywateliZOjczystym([FromRoute] string ojczysty)
        {
            var res = _obywatelService.getProcentObywateliZOjczystym(ojczysty);
            return Ok(res);
        }

        [Route("getObywateleWojewodztwoProcent/{wojewodztwo}")]
        [HttpGet]
        public IActionResult getObywateleWojewodztwoProcent([FromRoute] string wojewodztwo)
        {
            var res = _obywatelService.getObywateleWojewodztwoProcent(wojewodztwo);
            return Ok(res);
        }

    }
}
