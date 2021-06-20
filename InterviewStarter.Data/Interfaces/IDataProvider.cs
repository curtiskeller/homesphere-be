using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Data.Interfaces
{
    public interface IDataProvider<T>
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> Get();
        Task<bool> Put(T obj);
    }
}