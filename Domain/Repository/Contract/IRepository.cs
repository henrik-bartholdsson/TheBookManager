using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repository.Contract
{
    public interface IRepository<T1, T2> where T1: class
    {
        Task<IEnumerable<T1>> GetAll();
        Task<IEnumerable<T1>> GetById(T2 id);
        Task<IEnumerable<T1>> Insert(T1 entity);
        Task<IEnumerable<T1>> Delete(T2 id);
        Task<IEnumerable<T1>> Save();
    }
}
