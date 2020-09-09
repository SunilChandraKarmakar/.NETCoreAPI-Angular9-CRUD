using Microsoft.EntityFrameworkCore;
using PaymentSystemAPI.Database.Context;
using PaymentSystemAPI.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAPI.Repository.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly PaymentSystemAPIDbContext _paymentSystemAPIDbContext;

        public BaseRepository()
        {
            _paymentSystemAPIDbContext = new PaymentSystemAPIDbContext();
        }

        public virtual async Task<T> GetById(int? id)
        {
            return await _paymentSystemAPIDbContext.Set<T>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _paymentSystemAPIDbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<bool> Create(T entity)
        {
            _paymentSystemAPIDbContext.Set<T>().Add(entity);
            return await _paymentSystemAPIDbContext.SaveChangesAsync() > 0;
        }

        public virtual async Task<bool> Update(T entity)
        {
            _paymentSystemAPIDbContext.Entry(entity).State = EntityState.Modified;
            return await _paymentSystemAPIDbContext.SaveChangesAsync() > 0;
        }

        public virtual async Task<bool> Remove(T entity)
        {
            _paymentSystemAPIDbContext.Set<T>().Remove(entity);
            return await _paymentSystemAPIDbContext.SaveChangesAsync() > 0;
        }
    }
}
