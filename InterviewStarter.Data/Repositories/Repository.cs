using InterviewStarter.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : IIdentifiable
    {
        public virtual IDataProvider<T> DataProvider { get; }
        public abstract Task<T> Get(int id);
        public abstract Task<IEnumerable<T>> Get();
        public abstract Task<bool> Put(T obj);
    }
}
