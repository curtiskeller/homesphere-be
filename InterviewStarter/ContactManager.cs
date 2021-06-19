using InterviewStarter.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Data.Models
{
    public class ContactManager : IContactManager
    {
        private ContactDataSource _ds;
        public ContactManager(ContactDataSource testDS)
        {
            _ds = testDS;
        }
        public ContactManager()
        {
            _ds = new ContactDataSource();
        }

        public Contact GetContact(int id)
        {
            return _ds.GetSingleContact(id);
        }

        public Task<IEnumerable<Contact>> GetContacts()
        {
            return null;
        }

        public async Task<bool> SaveContact(Contact contact)
        {
            try
            {               
                var result = _ds.AddContact(contact);
                return true;
            }
            catch (Exception ex)
            {
                return false; 
            }
        }
    }
}
