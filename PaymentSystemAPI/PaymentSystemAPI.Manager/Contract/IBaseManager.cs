using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAPI.Manager.Contract
{
    public interface IBaseManager<T> where T : class 
    {
        Task<T> GetById(int? id);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Remove(T entity);
    }
}
