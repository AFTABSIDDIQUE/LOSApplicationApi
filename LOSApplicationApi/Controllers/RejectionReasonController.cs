using LOSApplicationApi.Data;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RejectionReasonController : ControllerBase
    {
        ApplicationDbContext db;
        IRejectionReason rejectionReason;
        public RejectionReasonController(ApplicationDbContext db, IRejectionReason rejectionReason)
        {
            this.db = db;
            this.rejectionReason = rejectionReason;
        }

        [HttpGet]
        [Route("FetchRejectionReason")]
        public IActionResult FetchRejectionReason()
        {
            var details = rejectionReason.FetchRejectionReasons();
            return Ok(details);
        }
        [HttpPost]
        [Route("AddRejectionReason")]
        public IActionResult AddRejectionReason([FromBody] DTO.AddRejectionReasonDTO rejectionReasonDTO)
        {
            rejectionReason.AddRejectionReason(rejectionReasonDTO);
            return Ok(new { message = "Rejection reason added successfully" });
        }
    }
}
