using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ILogin login;
        public LoginController(ILogin login)
        {
            this.login = login;
        }

        [HttpPost]
        [Route("FetchLogin")]
        public IActionResult FetchLogin(LoginDTO data)
        {

                var validate = login.Login(data);
                if(validate!= null)
                {
                    return Ok(new { message = "Login successful", datas=data, token = validate });
                }
                else
                {
                    return Unauthorized(new { message = "Invalid username or password" });
                }
            

        }
    }
}
