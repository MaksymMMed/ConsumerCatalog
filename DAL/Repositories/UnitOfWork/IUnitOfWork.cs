using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        IConsumerRepository consumerRepository { get; }
        IUnitRepository unitRepository { get; }
        IEnergyConsumeRepository energyConsumeRepository { get; }
        Task SaveChangesAsync();
    }
}
