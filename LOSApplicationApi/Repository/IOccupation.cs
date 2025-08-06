using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IOccupation
    {
        void AddOccupation(AddOccupationDTO occupation);
        List<FetchOccupationDTO> FetchOccupations();
    }
}
