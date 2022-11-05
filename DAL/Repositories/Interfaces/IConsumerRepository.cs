using DAL.Entities;
using DAL.Pagination;
using DAL.Parameters;
using DAL.Repositories.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IConsumerRepository:IRepository<Consumer>
    {

        public Task<PagedList<Consumer>> GetAsync(ConsumerParameters parameters);
        public Task<PagedList<Unit>> GetUnitsAsync(int Id, UnitParameters parameters);
    }
}
