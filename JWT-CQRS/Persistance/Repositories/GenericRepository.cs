using JWT_CQRS.Core.Application.Interfaces;
using JWT_CQRS.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JWT_CQRS.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly JWTContext _jWtContext;

        public GenericRepository(JWTContext jWtContext)
        {
            _jWtContext = jWtContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _jWtContext.Set<T>().AddAsync(entity);
            await _jWtContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _jWtContext.Set<T>().Remove(entity);
            await _jWtContext.SaveChangesAsync();

        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            return filter == null ? await _jWtContext.Set<T>().ToListAsync() :
                await _jWtContext.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>>? filter = null)
        {
            if (filter == null) { throw new ArgumentNullException(nameof(filter)); }
            return await _jWtContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _jWtContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _jWtContext.Set<T>().Update(entity);
            await _jWtContext.SaveChangesAsync();
        }
    }
}
