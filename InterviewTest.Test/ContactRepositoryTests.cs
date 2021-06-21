using InterviewStarter.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewStarter.Data.DataProviders;
using System.Linq;
using InterviewStarter.Data.Models;
using System.Threading.Tasks;

namespace InterviewTest.Test
{
    [TestClass]
    public class ContactRepositoryTests
    {
        private ContactRepository repo;

        [TestInitialize]
        public void testInit()
        {
            repo = new ContactRepository(new LocalDataProvider());
        }

        [TestMethod]
        public async Task ContactRepository_ReturnsOneContact()
        {
            var contact = await repo.Get(1);

            Assert.AreEqual(1, contact.Id);
            Assert.AreEqual("Ada Lovelace", contact.Name);
            Assert.AreEqual("123 Babbage Court*, London, England%#", contact.Address);
        }

        [TestMethod]
        public async Task ContactRepository_ReturnsAllContacts()
        {
            var contacts = await repo.Get();

            Assert.AreEqual(3, contacts.ToList().Count);
        }

        [TestMethod]
        public async Task ContactRepository_AddsContact()
        {
            var contacts = await repo.Get();
            Assert.AreEqual(3, contacts.ToList().Count);

            await repo.Put(
                new Contact { Id = 1, Name = "Curtis Keller", Address = "1000 Wally Street" });

            var contactsAfterAdd = await repo.Get();

            Assert.AreEqual(4, contactsAfterAdd.ToList().Count);
        }
    }
}
