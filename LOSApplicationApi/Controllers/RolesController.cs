using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        IRoles role;
        public RolesController(IRoles role)
        {
            this.role = role;
        }

        [HttpGet]
        [Route("FetchRoles")]
        public IActionResult FetchRoles()
        {
            var data = role.FetchRoles();
            return Ok(data);
        }

        [HttpPost]
        [Route("AddRole")]
        public IActionResult AddRole(DTO.AddRoleDTO addRole)
        {
            role.AddRole(addRole);
            return Ok(new { message = "Role added successfully" });
        }
    }
}
