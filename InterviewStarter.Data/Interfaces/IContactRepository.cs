using System.Collections.Generic;
using System.Threading.Tasks;
using InterviewStarter.Data.Models;

namespace InterviewStarter.Data.Interfaces
{
    public interface IContactRepository
    {
        Task<bool> Update(Contact contact);
        Task<Contact> GetContact(int id);
        Task<IEnumerable<Contact>> GetContacts();
    }
}
