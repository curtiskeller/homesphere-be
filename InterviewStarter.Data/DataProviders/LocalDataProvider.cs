using InterviewStarter.Data.Interfaces;
using InterviewStarter.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewStarter.Data.DataProviders
{
    public class LocalDataProvider : AbstractDataProvider
    {       
        private IEnumerable<Contact> contactData;

        public LocalDataProvider()
        {
            var contacts = new List<Contact>
            {
                new Contact {Id = 1, Name = "Ada Lovelace", Address = "123 Babbage Court*, London, England%#"},
                new Contact {Id = 2, Name = "Bill Gates", Address = "498 Money Printing Pres$$s Lane, Seattle, WA, USA"},
                new Contact {Id = 3, Name = "Guido van Rossum", Address = "999 Py@(*thon Path, Amsterdam, Netherlands"}
            };

            contactData = contacts;
        }

        private Task<IEnumerable<T>> GetLocalData<T>(){
            // This function should be a data access function to SQL or DocDb etc... if it was a real data provider
            if(typeof(T) == typeof(Contact))
            {
                return Task.FromResult((IEnumerable<T>)contactData);
            }

            return Task.FromResult((IEnumerable<T>)new List<T>());
        }

        public async override Task<T> Get<T>(int id)
        {
            return (await GetLocalData<T>()).FirstOrDefault(c => c.Id == id);
        }

        public override Task<IEnumerable<T>> Get<T>()
        {
            return GetLocalData<T>();
        }

        public async override Task<bool> Put<T>(T obj)
        {
            var newData = (await GetLocalData<T>()).ToList();
            newData.Add(obj);
            contactData = newData.Cast<Contact>();
            return true;
        }
    }
}
