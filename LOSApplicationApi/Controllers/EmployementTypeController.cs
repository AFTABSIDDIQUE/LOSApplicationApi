using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployementTypeController : ControllerBase
    {
        ApplicationDbContext db;
        IEmploymentType employmentTypeService;
        public EmployementTypeController(ApplicationDbContext db, IEmploymentType employmentTypeService)
        {
            this.db = db;
            this.employmentTypeService = employmentTypeService;
        }

        [HttpGet]
        [Route("FetchEmploymentTypes")]
        public IActionResult FetchEmploymentTypes()
        {
            var details = employmentTypeService.FetchEmploymentTypes();
            return Ok(details);
        }

        [HttpPost]
        [Route("AddEmploymentType")]
        public IActionResult AddEmploymentType(AddEmploymentTypeDTO employmentTypeDTO)
        {
            employmentTypeService.addEmploymentType(employmentTypeDTO);
            return Ok(new { message = "Employment Type added successfully" });

        }
    }
}
