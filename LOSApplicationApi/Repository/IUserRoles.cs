using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IUserRoles
    {
        void AddUserRole(AddUserRolesDTO userRole);
        List<FetchUserRolesDTO> FetchUserRoles();

    }
}
