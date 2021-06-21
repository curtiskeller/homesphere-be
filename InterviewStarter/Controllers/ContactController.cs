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
        public ContactController(ContactRepository repository) : base(repository)
        {
        }

        [HttpGet("validatedContacts")]
        public async Task<IEnumerable<Contact>> GetValidated()
        {
            return Repository.ValidateAddresses(await Repository.Get());
        }

        [HttpGet("validatedContact/{id}")]
        public async Task<Contact> GetSingleValidated(int id)
        {
            return Repository.ValidateAddress(await Repository.Get(id));
        }

    }
}
