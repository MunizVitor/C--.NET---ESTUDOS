using Microsoft.AspNetCore.Mvc;
using WebApiCsharp.Services;

namespace WebApiCsharp.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if(username == "vitor " && password == "123") {
                var token = TokenService.GeneratedToken(new Model.User.User());
                return Ok(token);
            }

            return BadRequest("Username or password invalid");
        }
    }
}
