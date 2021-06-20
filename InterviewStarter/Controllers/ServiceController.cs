using InterviewStarter.Data.Interfaces;
using InterviewStarter.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarterControllers
{
    public abstract class ServiceController<T, TFactory> : Controller 
        where T : IIdentifiable
        where TFactory : Repository<T>
    {
        private readonly TFactory factory;
        public ServiceController(TFactory factory)
        {
            this.factory = factory;      
        }

        [HttpGet]
        public async Task<IEnumerable<T>> Get()
        {
            return await factory.Get();
        }

        [HttpGet("{id}")]
        public async Task<T> Get(int id)
        {
            return await factory.Get(id);
        }

        [HttpPut("")]
        public async Task<bool> Put([FromBody] T obj)
        {
            return await factory.Put(obj);
        }
    }
}
