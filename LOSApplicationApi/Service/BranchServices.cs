using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.Model;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class BranchServices : IBranch
    {
        ApplicationDbContext db;
        IMapper mapper;
        public BranchServices(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddBranch(DTO.AddBranchDTO branch)
        {
            var details = mapper.Map<Branch>(branch);
            db.Branches.Add(details);
            db.SaveChanges();
        }

        public List<DTO.FetchBranchDTO> FetchBranches()
        {
            var details = db.Branches.ToList();
            var mappedDetails = mapper.Map<List<DTO.FetchBranchDTO>>(details);
            return mappedDetails;

        }
    }
}
