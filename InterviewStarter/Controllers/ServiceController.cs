using InterviewStarter.Data.Interfaces;
using InterviewStarter.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarterControllers
{
    public abstract class ServiceController<T, TRepository> : Controller 
        where T : IIdentifiable
        where TRepository : Repository<T>
    {
        protected readonly TRepository Repository;
        public ServiceController(TRepository repository)
        {
            this.Repository = repository;      
        }

        [HttpGet]
        public virtual async Task<IEnumerable<T>> Get()
        {
            return await Repository.Get();
        }

        [HttpGet("{id}")]
        public virtual async Task<T> Get(int id)
        {
            return await Repository.Get(id);
        }

        [HttpPut("")]
        public virtual async Task<bool> Put([FromBody] T obj)
        {
            return await Repository.Put(obj);
        }
    }
}
