using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IRejectionReason
    {
        void AddRejectionReason(AddRejectionReasonDTO rejectionReason);
        List<FetchRejectionReasonDTO> FetchRejectionReasons();
    }
}
