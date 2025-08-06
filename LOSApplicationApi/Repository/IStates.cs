using LOSApplicationApi.DTO;

namespace LOSApplicationApi.Repository
{
    public interface IStates
    {
        void AddState(AddStateDTO state);
        List<FetchStateDTO> FetchStates();
    }
}
