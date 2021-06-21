using InterviewStarter.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : IIdentifiable
    {
        private IDataProvider dataProvider;

        protected Repository(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public Task<T> Get(int id)
        {
            return dataProvider.Get<T>(id);
        }

        public Task<IEnumerable<T>> Get()
        {
            return dataProvider.Get<T>();
        }

        public Task<bool> Put(T obj)
        {
            return dataProvider.Put(obj);
        }
    }
}
