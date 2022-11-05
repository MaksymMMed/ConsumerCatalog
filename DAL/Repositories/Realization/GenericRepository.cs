using DAL.Exceptions;
using DAL.Repositories.Interfces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Realization
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly UnitContext databaseContext;

        protected readonly DbSet<TEntity> table;

        public virtual async Task<IEnumerable<TEntity>> GetAsync() => await table.ToListAsync();
        
        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await table.FindAsync(id)
                ?? throw new EntityNotFoundException(
                    GetEntityNotFoundErrorMessage(id));
        }
        public abstract Task<TEntity> GetCompleteEntityAsync(int id);

        public virtual async Task InsertAsync(TEntity entity) => await table.AddAsync(entity);

        public virtual async Task UpdateAsync(TEntity entity) =>
            await Task.Run(() => table.Update(entity));
        public virtual async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            await Task.Run(() => table.Remove(entity));
        }

        protected static string GetEntityNotFoundErrorMessage(int id) =>
            $"{typeof(TEntity).Name} with id {id} not found.";

        public GenericRepository(UnitContext databaseContext)
        {
            this.databaseContext = databaseContext;
            table = this.databaseContext.Set<TEntity>();
        }
    }
}
