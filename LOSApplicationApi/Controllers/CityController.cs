using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOSApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        ApplicationDbContext db;
        ICity cityService;

        public CityController(ApplicationDbContext db, ICity cityService)
        {
            this.db = db;
            this.cityService = cityService;
        }

        [HttpGet]
        [Route("AddCity")]
        public IActionResult AddCity(AddCityDTO city)
        {
            cityService.AddCity(city);
            return Ok(new { meassage = "City added successfully" });
        }

        [HttpGet]
        [Route("FetchCities")]
        public IActionResult FetchCities()
        {
            var mappedDetails = cityService.FetchCities();
            return Ok(mappedDetails);
        }
    }
}
