using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Data.Interfaces
{
    public interface IRepository<T> where T : IIdentifiable
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> Get();
        Task<bool> Put(T obj);
    }
}