using LOSApplicationApi.Data;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        ApplicationDbContext db;
        IStates stateService;
        public StateController(ApplicationDbContext db, IStates stateService)
        {
            this.db = db;
            this.stateService = stateService;
        }

        [HttpGet]
        [Route("FetchStates")]
        public IActionResult FetchStates()
        {
            var details = stateService.FetchStates();
            return Ok(details);
        }

        [HttpPost]
        [Route("AddState")]
        public IActionResult AddState([FromBody] DTO.AddStateDTO stateDTO)
        {
            stateService.AddState(stateDTO);
            return Ok(new { message = "State added successfully" });
        }
    }
}
