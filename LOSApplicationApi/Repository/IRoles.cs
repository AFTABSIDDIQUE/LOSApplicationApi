using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IRoles
    {
        void AddRole(AddRoleDTO role);
        List<FetchRoleDTO> FetchRoles();
    }
}
