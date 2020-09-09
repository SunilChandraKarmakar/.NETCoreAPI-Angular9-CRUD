using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAPI.Repository.Contract
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetById(int? id);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Remove(T entity);
    }
}
