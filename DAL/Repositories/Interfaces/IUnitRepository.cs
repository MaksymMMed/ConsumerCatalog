using DAL.Entities;
using DAL.Pagination;
using DAL.Parameters;
using DAL.Repositories.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IUnitRepository:IRepository<Unit>
    {
        public Task<PagedList<Unit>> GetAsync(UnitParameters parameters);
        public Task<IEnumerable<Issue>> GetIssues(int id);
        public Task<IEnumerable<EnergyConsume>> GetEnergyConsumes(int id);
    }
}
