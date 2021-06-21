using InterviewStarter.Data.DataProviders;
using InterviewStarter.Data.Models;
using InterviewStarter.Data.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace InterviewStarter.Repositories
{
    public class ContactRepository : Repository<Contact>
    {
        public ContactRepository(LocalDataProvider dataProvider): base(dataProvider)
        {

        }

        public IEnumerable<Contact> ValidateAddresses(IEnumerable<Contact> contacts)
        {
            return contacts.Select(contact => ValidateAddress(contact));
        }
        public Contact ValidateAddress(Contact contact)
        {
            if (contact is null)
                return null;

            return new Contact()
            {
                Id = contact.Id,
                Name = contact.Name,
                Address = Regex.Replace(contact.Address, @"[^a-zA-Z0-9_.\s]+", "", RegexOptions.Compiled)
            };
        }
    }
}
