using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IPincode
    {
        void AddPincode(AddPincodeDTO pincode);
        List<FetchPincodeDTO> FetchPincodes();
    }
}
