using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IBranch
    {
        void AddBranch(AddBranchDTO branch);
        List<FetchBranchDTO> FetchBranches();
    }
}
