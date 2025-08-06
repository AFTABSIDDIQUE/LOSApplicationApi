using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface ICity
    {
        void AddCity(AddCityDTO city);
        List<FetchCityDTO> FetchCities();
    }
}
