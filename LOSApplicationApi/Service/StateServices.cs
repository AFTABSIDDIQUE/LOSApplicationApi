using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class StateServices: IStates
    {
        ApplicationDbContext db;
        IMapper mapper;

        public StateServices(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddState(DTO.AddStateDTO state)
        {
            var details = mapper.Map<Model.States>(state);
            db.State.Add(details);
            db.SaveChanges();
        }

        public List<DTO.FetchStateDTO> FetchStates()
        {
            var details = db.State.ToList();
            var mappedDetails = mapper.Map<List<DTO.FetchStateDTO>>(details);
            return mappedDetails;
        }


    }
}
