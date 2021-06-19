using System.Collections.Generic;
using System.Linq;
using InterviewStarter.Data.Models;

namespace InterviewStarter.Data
{
    public class ContactDataSource
    {
        private readonly List<Contact> _contacts;

        public ContactDataSource()
        {
            var contacts = new List<Contact>
            {
                new Contact {Id = 1, Name = "Ada Lovelace", Address = "123 Babbage Court*, London, England%#"},
                new Contact {Id = 2, Name = "Bill Gates", Address = "498 Money Printing Pres$$s Lane, Seattle, WA, USA"},
                new Contact {Id = 3, Name = "Guido van Rossum", Address = "999 Py@(*thon Path, Amsterdam, Netherlands"}
            };

            _contacts = contacts;

        }

        public Contact GetSingleContact(int id)
        {
            return _contacts.FirstOrDefault(c => c.Id == id);
        }

        public List<Contact> GetAllContacts()
        {
            return _contacts;
        }

        public Contact AddContact(Contact contact)
        {
            _contacts.Add(contact);
            return contact;
        }
    }
}
