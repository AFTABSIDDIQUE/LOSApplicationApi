using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IEmploymentType
    {
        void addEmploymentType(AddEmploymentTypeDTO employmentType);
        List<FetchEmploymentTypeDTO> FetchEmploymentTypes();
    }
}
