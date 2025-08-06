using LOSApplicationApi.Data;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        ApplicationDbContext db;
        IBranch branchService;
        public BranchController(ApplicationDbContext db, IBranch branchService)
        {
            this.db = db;
            this.branchService = branchService;
        }

        [HttpGet]
        [Route("FetchBranches")]
        public IActionResult FetchBranches()
        {
            var details = branchService.FetchBranches();
            return Ok(details);
        }

        [HttpPost]
        [Route("AddBranch")]
        public IActionResult AddBranch([FromBody] DTO.AddBranchDTO branchDTO)
        {
            branchService.AddBranch(branchDTO);
            return Ok(new { message = "Branch added successfully" });
        }
    }
}   
