using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.Model;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class DepartmentService : IDepartment
    {
        ApplicationDbContext db;
        IMapper mapper;
        public DepartmentService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddDepartment(DTO.AddDepartmentDTO department)
        {
            var details = mapper.Map<Department>(department);
            db.Departments.Add(details);
            db.SaveChanges();
        }

        public List<DTO.FetchDepartmentDTO> FetchDepartments()
        {
            var details = db.Departments.ToList();
            var mappedDetails = mapper.Map<List<DTO.FetchDepartmentDTO>>(details);
            return mappedDetails;


        }
    }
}
