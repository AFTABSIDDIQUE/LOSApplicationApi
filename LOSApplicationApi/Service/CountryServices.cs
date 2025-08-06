using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class CountryServices: ICountry
    {
        ApplicationDbContext db;
        IMapper mapper;
        public CountryServices(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddCountry(AddCountryDTO country)
        {
            var details = mapper.Map<Model.Countries>(country);
            db.Country.Add(details);
            db.SaveChanges();
        }

        public List<FetchCountryDTO> FetchCountry()
        {
            var details = db.Country.ToList();
            var mappedDetails = mapper.Map<List<FetchCountryDTO>>(details);
            return mappedDetails;
        }
    }
}
