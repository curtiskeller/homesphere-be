using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Data.Interfaces
{
    public interface IDataProvider
    {
        public Task<T> Get<T>(int id) where T: IIdentifiable;
        public Task<IEnumerable<T>> Get<T>() where T : IIdentifiable;
        public Task<bool> Put<T>(T obj) where T : IIdentifiable;
    }
}