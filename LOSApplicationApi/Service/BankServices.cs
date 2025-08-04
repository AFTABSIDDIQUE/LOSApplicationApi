using LOSApplicationApi.Data;
using LOSApplicationApi.Model;
using LOSApplicationApi.Repository;

namespace LOSApplicationApi.Service
{
    public class BankServices:IBank
    {
        ApplicationDbContext db;
        public BankServices(ApplicationDbContext db) 
        {
            this.db = db;
        }

        public void AddBank(Bank b)
        {

        }
    }
}
