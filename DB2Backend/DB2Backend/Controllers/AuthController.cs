using DB2Backend.Models;
using DB2Backend.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DB2Backend.Controllers
{





    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {


        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [DisableCors]
        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            var res = _authService.Login(loginModel.username, loginModel.password);
            return Ok(res);
        }


    }
}
