﻿using InterviewStarter.Data.Interfaces;
using InterviewStarter.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewStarter.Data.DataProviders
{
    public class ContactDataProvider : ILocalDataProvider<Contact>
    {
        private IEnumerable<Contact> _data;
        public IEnumerable<Contact> data { get => _data; set => _data = value; }

        public ContactDataProvider()
        {
            var contacts = new List<Contact>
            {
                new Contact {Id = 1, Name = "Ada Lovelace", Address = "123 Babbage Court*, London, England%#"},
                new Contact {Id = 2, Name = "Bill Gates", Address = "498 Money Printing Pres$$s Lane, Seattle, WA, USA"},
                new Contact {Id = 3, Name = "Guido van Rossum", Address = "999 Py@(*thon Path, Amsterdam, Netherlands"}
            };

            data = contacts;
        }


        public Task<Contact> Get(int id) 
        {
            return Task.FromResult(data.FirstOrDefault(c => c.Id == id));
        }

        public Task<IEnumerable<Contact>> Get()
        {
            return Task.FromResult(data);

        }

        public Task<bool> Put(Contact obj)
        {
            var newData = data.ToList();
            newData.Add(obj);
            data = newData;
            return Task.FromResult(true);
        }
    }
}
