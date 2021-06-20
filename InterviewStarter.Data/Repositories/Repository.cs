using InterviewStarter.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : IIdentifiable
    {
        private IDataProvider<T> dataProvider;

        protected Repository(IDataProvider<T> dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        public Task<T> Get(int id)
        {
            return dataProvider.Get(id);
        }

        public Task<IEnumerable<T>> Get()
        {
            return dataProvider.Get();
        }

        public Task<bool> Put(T obj)
        {
            return dataProvider.Put(obj);
        }
    }
}
