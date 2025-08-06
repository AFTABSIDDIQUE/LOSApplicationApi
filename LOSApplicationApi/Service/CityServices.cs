using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Model;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class CityServices: ICity
    {
        ApplicationDbContext db;
        IMapper mapper;
        public CityServices(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddCity(AddCityDTO city)
        {
            var details = mapper.Map<Cities>(city);
            db.City.Add(details);
            db.SaveChanges();
        }

        public List<DTO.FetchCityDTO> FetchCities()
        {
            var details = db.City.ToList();
            var mappedDetails = mapper.Map<List<FetchCityDTO>>(details);
            return mappedDetails;
        }


    }
}
