using LOSApplicationApi.Data;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccupationTypeController : ControllerBase
    {
        ApplicationDbContext db;
        IOccupation occupationService;
        public OccupationTypeController(ApplicationDbContext db, IOccupation occupationService)
        {
            this.db = db;
            this.occupationService = occupationService;
        }

        [HttpGet]
        [Route("FetchOccupationTypes")]
        public IActionResult FetchOccupationTypes()
        {
            var details = occupationService.FetchOccupations();
            return Ok(details);
        }

        [HttpPost]
        [Route("AddOccupationType")]
        public IActionResult AddOccupationType([FromBody] DTO.AddOccupationDTO occupationDTO)
        {
            occupationService.AddOccupation(occupationDTO);
            return Ok(new { message = "Occupation type added successfully" });
        }
    }
}
