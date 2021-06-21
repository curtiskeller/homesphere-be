using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Data.Interfaces
{
    public abstract class AbstractDataProvider: IDataProvider
    {
        public abstract Task<T> Get<T>(int id) where T : IIdentifiable;

        public abstract Task<IEnumerable<T>> Get<T>() where T : IIdentifiable;

        public abstract Task<bool> Put<T>(T obj) where T : IIdentifiable;
    }
}
