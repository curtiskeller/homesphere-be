using Microsoft.AspNetCore.Mvc;
using InterviewStarter.Data.Models;

namespace InterviewStarter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        public ContactController() { }

        [HttpGet("{id}")]
        public Contact GetContact(int id)
        {
            var contactManager = new ContactManager();
            return contactManager.GetContact(id);
        }

        //[HttpGet]
        //public async Contact GetContacts()
        //{
        //    var contactManager = new ContactManager();
        //    return contactManager.GetContacts();
        //}
    }
}
