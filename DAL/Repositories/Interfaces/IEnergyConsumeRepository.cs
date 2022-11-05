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
    public interface IEnergyConsumeRepository:IRepository<EnergyConsume>
    {
        public Task<PagedList<EnergyConsume>> GetAsync(EnergyConsumeParameters parameters);
    }
}
