using DAL.Entities;
using DAL.Exceptions;
using DAL.Pagination;
using DAL.Parameters;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Realization
{
    public class EnergyConsumeRepository : GenericRepository<EnergyConsume>, IEnergyConsumeRepository
    {
        public EnergyConsumeRepository(UnitContext databaseContext, IMemoryCache memoryCache) : base(databaseContext, memoryCache)
        {
        }

        public async Task<PagedList<EnergyConsume>> GetAsync(EnergyConsumeParameters parameters)
        {
            IQueryable<EnergyConsume> source = table
                 .Include(x => x.Unit);

            SearchByUnitId(ref source, parameters.UnitId);

            return await PagedList<EnergyConsume>.ToPagedListAsync(
                source,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public async override Task<EnergyConsume> GetCompleteEntityAsync(int id)
        {
            var Item = await table
                .Include(x => x.Unit)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Item ?? throw new EntityNotFoundException(GetEntityNotFoundErrorMessage(id));
        }

        public static void SearchByUnitId(ref IQueryable<EnergyConsume> source, int? UnitId)
        {
            if (UnitId is null || UnitId <= 0)
            {
                return;
            }

            source = source.Where(item => item.UnitId==UnitId);
        }
    }
}
