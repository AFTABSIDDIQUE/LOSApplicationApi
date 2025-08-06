using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class EmploymentTypeServices : IEmploymentType
    {
        ApplicationDbContext db;
        IMapper mapper;
        public EmploymentTypeServices(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void addEmploymentType(DTO.AddEmploymentTypeDTO employmentType)
        {
            var details = mapper.Map<Model.EmploymentType>(employmentType);
            db.EmploymentTypes.Add(details);
            db.SaveChanges();
        }

        public List<DTO.FetchEmploymentTypeDTO> FetchEmploymentTypes()
        {
            var details = db.EmploymentTypes.ToList();
            var mappedDetails = mapper.Map<List<DTO.FetchEmploymentTypeDTO>>(details);
            return mappedDetails;
        }
    }
}
