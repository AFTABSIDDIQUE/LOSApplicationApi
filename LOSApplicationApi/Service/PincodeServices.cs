using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Model;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class PincodeServices: IPincode
    {
        ApplicationDbContext db;
        IMapper mapper;
        public PincodeServices(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddPincode(AddPincodeDTO pincode)
        {
            var details = mapper.Map<Pincode>(pincode);
            db.Pincode.Add(details);
            db.SaveChanges();
        }
        public List<DTO.FetchPincodeDTO> FetchPincodes()
        {
            var details = db.Pincode.ToList();
            var mappedDetails = mapper.Map<List<FetchPincodeDTO>>(details);
            return mappedDetails;
        }
    }
}
