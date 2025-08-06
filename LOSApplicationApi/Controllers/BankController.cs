using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        ApplicationDbContext db;
        IBank bankService;
        public BankController(ApplicationDbContext db, IBank bankService)
        {
            this.db = db;
            this.bankService = bankService;
        }

        [HttpGet]
        [Route("FetchBanks")]
        public IActionResult FetchBanks()
        {
            var details = bankService.FetchBanks();
            return Ok(details);
        }

        [HttpPost]
        [Route("AddBank")]
        public IActionResult AddBank(AddBankDTO bankDTO)
        {
            bankService.AddBank(bankDTO);
            return Ok(new { message = "Bank added successfully" });
        }
    }
}
