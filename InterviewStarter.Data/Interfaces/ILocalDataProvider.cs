using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterviewStarter.Data.Interfaces
{

    public interface ILocalDataProvider<T>: IDataProvider<T> where T: IIdentifiable    
    {
        IEnumerable<T> data { get; set; }
    }
}
