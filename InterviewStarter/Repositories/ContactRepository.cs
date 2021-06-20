using InterviewStarter.Data.DataProviders;
using InterviewStarter.Data.Interfaces;
using InterviewStarter.Data.Models;
using InterviewStarter.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Repositories
{
    public class ContactRepository : Repository<Contact>
    {
        public ContactRepository(ContactDataProvider dataProvider): base(dataProvider)
        {

        } 
    }
}
