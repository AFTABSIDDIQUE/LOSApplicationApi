using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Model;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class OccupationServices:IOccupation
    {
        ApplicationDbContext db;
        IMapper mapper;
        public OccupationServices(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }


        public void AddOccupation(AddOccupationDTO occupation)
        {
            var details = mapper.Map<OccupationType>(occupation);
            db.OccupationTypes.Add(details);
            db.SaveChanges();
        }

        public List<FetchOccupationDTO> FetchOccupations()
        {
            var details = db.OccupationTypes.ToList();
            var mappedDetails = mapper.Map<List<FetchOccupationDTO>>(details);
            return mappedDetails;
        }
    }
}
