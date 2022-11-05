using DAL.Entities;
using DAL.Exceptions;
using DAL.Pagination;
using DAL.Parameters;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Realization
{
    public class ConsumerRepository : GenericRepository<Consumer>, IConsumerRepository
    {
        public ConsumerRepository(UnitContext databaseContext) : base(databaseContext)
        {
        }

        public async Task<PagedList<Unit>> GetUnitsAsync(int Id, UnitParameters parameters)
        {

            Consumer consumer = await table.
                Include(x=>x.OwnedUnit).
                Where(x => x.Id == Id).FirstAsync();
            IQueryable<Unit> source = (IQueryable<Unit>)consumer.OwnedUnit;

            return await PagedList<Unit>.ToPagedListAsync(
                source,
                parameters.PageNumber,
                parameters.PageSize);
        }
        public async Task<PagedList<Consumer>> GetAsync(ConsumerParameters parameters)
        {
            IQueryable<Consumer> source = table
                 .Include(x => x.OwnedUnit);

            SearchByFirstName(ref source, parameters.FirstName);
            SearchByFirstName(ref source, parameters.LastName);

            return await PagedList<Consumer>.ToPagedListAsync(
                source,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public override async Task<Consumer> GetCompleteEntityAsync(int id)
        {
            var Item = await table
                .Include(x => x.OwnedUnit)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Item ?? throw new EntityNotFoundException(GetEntityNotFoundErrorMessage(id));
        }

        public static void SearchByFirstName(ref IQueryable<Consumer> source, string? FirstName)
        {
            if (FirstName is null || FirstName == "")
            {
                return;
            }

            source = source.Where(item => item.FirstName.Contains(FirstName));
        }

        public static void SearchByLastName(ref IQueryable<Consumer> source, string? LastName)
        {
            if (LastName is null || LastName == "")
            {
                return;
            }

            source = source.Where(item => item.LastName.Contains(LastName));
        }

        
    }
}
