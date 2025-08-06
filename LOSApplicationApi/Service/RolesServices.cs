using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class RolesServices:IRoles
    {
        IMapper mapper;
        ApplicationDbContext db;
        public RolesServices(ApplicationDbContext db, IMapper mapper) 
        { 
            this.db = db;
            this.mapper = mapper;
        }

        public void AddRole(AddRoleDTO role)
        {
            var details = mapper.Map<Model.Roles>(role);
            db.Role.Add(details);
            db.SaveChanges();
        }

        public List<FetchRoleDTO> FetchRoles()
        {
            var details = db.Role.ToList();
            var mappedDetails = mapper.Map<List<FetchRoleDTO>>(details);
            return mappedDetails;
        }

    }
}
