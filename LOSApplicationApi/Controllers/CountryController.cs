using LOSApplicationApi.Data;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        ApplicationDbContext db;
        ICountry country;
        public CountryController(ApplicationDbContext db, ICountry country)
        {
            this.db = db;
            this.country = country;
        }

        [HttpGet]
        [Route("FetchCountry")]
        public IActionResult FetchCountry()
        {
            var details = country.FetchCountry();

                return Ok(details);
        }

        [HttpPost]
        [Route("AddCountry")]
        public IActionResult AddCountry([FromBody] DTO.AddCountryDTO countryDTO)
        {
                country.AddCountry(countryDTO);
                return Ok("Country added successfully");
        }
    }
}
