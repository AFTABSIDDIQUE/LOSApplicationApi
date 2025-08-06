using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class UserRolesService: IUserRoles
    {
        ApplicationDbContext db;
        IMapper mapper;
        public UserRolesService(ApplicationDbContext db, IMapper mapper) 
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddUserRole(AddUserRolesDTO userRole)
        {
            var details = mapper.Map<Model.UserRoles>(userRole);
            db.UserRole.Add(details);
            db.SaveChanges();
        }

        public List<FetchUserRolesDTO> FetchUserRoles()
        {
            var details = db.UserRole.ToList();
            var mappedDetails = mapper.Map<List<FetchUserRolesDTO>>(details);
            return mappedDetails;
        }
    }
}
