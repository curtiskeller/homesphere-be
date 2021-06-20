using InterviewStarter.Data.Models;
using InterviewStarter.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Repositories
{
    public class ContactRepository : Repository<Contact>
    {
        public override Task<Contact> Get(int id)
        {
            return DataProvider.Get(id);
        }

        public override Task<IEnumerable<Contact>> Get()
        {
            return DataProvider.Get();
        }

        public override Task<bool> Put(Contact obj)
        {
            return DataProvider.Put(obj);
        }
    }
}
