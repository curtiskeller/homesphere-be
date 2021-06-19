using System.Collections.Generic;
using System.Threading.Tasks;
using InterviewStarter.Data.Models;

namespace InterviewStarter.Interfaces
{
    public interface IContactManager
    {
        Contact GetContact(int id);
        Task<IEnumerable<Contact>> GetContacts();
        Task<bool> SaveContact(Contact contact);
    }
}