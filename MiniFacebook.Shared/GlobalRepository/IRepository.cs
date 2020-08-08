using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MiniFacebook.Shared.GlobalRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, string includeProperties = null, bool GlobalFilterIgnore = false);

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, string includeProperties = "", bool GlobalFilterIgnore = false);

        Task<T> FindAsync(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        Task RemoveAsync(T entity);

        Task RemoveRangeAsync(IEnumerable<T> entities);

        Task UpdateAsync(T entity);

        Task UpdateRangeAsync(IEnumerable<T> entities);
    }
}
