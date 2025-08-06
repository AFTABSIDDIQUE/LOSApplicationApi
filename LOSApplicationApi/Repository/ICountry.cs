using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface ICountry
    {
        public void AddCountry(AddCountryDTO country);
        List<FetchCountryDTO> FetchCountry();
    }
}
