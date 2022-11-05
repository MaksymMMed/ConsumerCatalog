using DAL.Entities;
using DAL.Exceptions;
using DAL.Pagination;
using DAL.Parameters;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Realization
{
    public class UnitRepository : GenericRepository<Unit>, IUnitRepository
    {
        public UnitRepository(UnitContext databaseContext) : base(databaseContext)
        {
        }

        public async Task<PagedList<Unit>> GetAsync(UnitParameters parameters)
        {
            IQueryable<Unit> source = table
                 .Include(x => x.Owner)
                 .Include(x=>x.ConsumeEnergy);

            SearchByName(ref source, parameters.UnitName);
            SearchByOwner(ref source, parameters.OwnerId);

            return await PagedList<Unit>.ToPagedListAsync(
                source,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public async override Task<Unit> GetCompleteEntityAsync(int id)
        {
            var Item = await table
                .Include(x => x.Owner)
                .Include(x => x.ConsumeEnergy)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Item ?? throw new EntityNotFoundException(GetEntityNotFoundErrorMessage(id));
        }

        public static void SearchByName(ref IQueryable<Unit> source, string? Name)
        {
            if (Name is null || Name == "")
            {
                return;
            }

            source = source.Where(item => item.Name.Contains(Name));
        }
        public static void SearchByOwner(ref IQueryable<Unit> source, int? OwnerId)
        {
            if (OwnerId is null || OwnerId <= 0 )
            {
                return;
            }

            source = source.Where(item => item.OwnerId == OwnerId);
        }
    }
}
