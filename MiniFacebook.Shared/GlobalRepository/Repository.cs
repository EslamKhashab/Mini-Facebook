using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MiniFacebook.Shared.GlobalRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        internal DbSet<T> dbSet;


        public Repository(DbContext context)
        {
            Context = context;
            dbSet = Context.Set<T>();

        }
        public async Task AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
        }
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Context.Set<T>().AddRangeAsync(entities);
        }
        public async Task UpdateAsync(T entity)
        {

            Context.Set<T>().Update(entity);
        }
        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            Context.Set<T>().UpdateRange(entities);
        }
        public Task<T> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public async Task RemoveAsync(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
        }


        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null, string includeProperties = null, bool GlobalFilterIgnore = false)
        {
            var query = Context.Set<T>().Where(filter);
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            if (GlobalFilterIgnore)
            {
                query = query.IgnoreQueryFilters();
            }
            return await query.SingleOrDefaultAsync();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, string includeProperties = "", bool GlobalFilterIgnore = false)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            if (GlobalFilterIgnore)
            {
                query = query.IgnoreQueryFilters();
            }
            return query.ToList();
        }

    }
}
