using LOSApplicationApi.Data;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PincodeController : ControllerBase
    {
        ApplicationDbContext db;
        IPincode pincodeService;
        public PincodeController(ApplicationDbContext db, IPincode pincodeService)
        {
            this.db = db;
            this.pincodeService = pincodeService;
        }

        [HttpGet]
        [Route("FetchPincode")]
        public IActionResult FetchPincode()
        {
            var details = pincodeService.FetchPincodes();
            return Ok(details);
        }

        [HttpPost]
        [Route("AddPincode")]
        public IActionResult AddPincode([FromBody] DTO.AddPincodeDTO pincodeDTO)
        {
            pincodeService.AddPincode(pincodeDTO);
            return Ok(new { message = "Pincode added successfully" });
        }
    }
}
