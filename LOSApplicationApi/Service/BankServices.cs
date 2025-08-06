using AutoMapper;
using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Model;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class BankServices : IBank
    {
        ApplicationDbContext db;
        IMapper mapper;
        public BankServices(ApplicationDbContext db)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddBank(AddBankDTO b)
        {
            var details = mapper.Map<Bank>(b);
            db.Banks.Add(details);
            db.SaveChanges();

        }

        public List<FetchBankDTO> FetchBanks()
        {
            var data = db.Banks.ToList();
            var details = mapper.Map<List<FetchBankDTO>>(data);
            return details;
        }
    }
}
