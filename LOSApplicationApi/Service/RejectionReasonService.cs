using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Model;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class RejectionReasonService: IRejectionReason
    {
        ApplicationDbContext db;
        IMapper mapper;
        public RejectionReasonService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddRejectionReason(AddRejectionReasonDTO rejectionReason)
        {
            var details = mapper.Map<RejectionReason>(rejectionReason);
            db.ReajectionReasons.Add(details);
            db.SaveChanges();
        }

        public List<FetchRejectionReasonDTO> FetchRejectionReasons()
        {
            var details = db.ReajectionReasons.ToList();
            var mappedDetails = mapper.Map<List<FetchRejectionReasonDTO>>(details);
            return mappedDetails;
        }
    }
}
