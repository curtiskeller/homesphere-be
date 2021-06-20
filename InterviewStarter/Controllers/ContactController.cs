using Microsoft.AspNetCore.Mvc;
using InterviewStarter.Data.Models;
using InterviewStarter.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;
using InterviewStarterControllers;

namespace InterviewStarter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ServiceController<Contact, ContactRepository>
    {

        public ContactController() { }

        [HttpGet("{id}")]
        public async Task<Contact> GetContact(int id)
        {            
            return await factory.Get(id);
        }


        [HttpGet]
        public async Task<IEnumerable<Contact>> GetContacts()
        {            
            return await factory.Get();
        }

        [HttpPut]
        public async Task<bool> PutContact([FromBody] Contact payload)
        {
            return await factory.Put(payload); 
        }
    }
}
