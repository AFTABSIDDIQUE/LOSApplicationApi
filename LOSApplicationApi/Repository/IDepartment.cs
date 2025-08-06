using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IDepartment
    {
        void AddDepartment(AddDepartmentDTO department);
        List<FetchDepartmentDTO> FetchDepartments();
    }
}
