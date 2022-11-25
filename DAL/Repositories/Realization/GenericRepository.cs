using DAL.Exceptions;
using DAL.Repositories.Interfces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace DAL.Repositories.Realization
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly UnitContext databaseContext;

        protected readonly DbSet<TEntity> table;

        protected readonly IMemoryCache memoryCache;
        public virtual async Task<IEnumerable<TEntity>> GetAsync() => await table.ToListAsync();
        
        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            TEntity entity = null;
            if (!memoryCache.TryGetValue(id,out entity))
            {
                entity = await table.FindAsync(id);
                if (entity == null)
                {
                    throw new EntityNotFoundException(GetEntityNotFoundErrorMessage(id));
                }
                memoryCache.Set(id, entity, new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
                });
                return entity;

            }
            return entity;
            
        }
        //
        public abstract Task<TEntity> GetCompleteEntityAsync(int id);
        //
        public virtual async Task InsertAsync(TEntity entity) {
            await table.AddAsync(entity);
            var id = entity.GetType().GetProperties().First();
            memoryCache.Set(id,entity,new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            });
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => table.Update(entity));
            var id = entity.GetType().GetProperties().First();
            memoryCache.Set(id, entity, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            });
        }
        public virtual async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            table.Remove(entity);
            if (memoryCache.TryGetValue(id, out entity))
            {
                memoryCache.Remove(id);
            }
        }

        protected static string GetEntityNotFoundErrorMessage(int id) =>
            $"{typeof(TEntity).Name} with id {id} not found.";

        public GenericRepository(UnitContext databaseContext,IMemoryCache memoryCache)
        {
            this.databaseContext = databaseContext;
            table = this.databaseContext.Set<TEntity>();
            this.memoryCache = memoryCache;
        }
    }
}
