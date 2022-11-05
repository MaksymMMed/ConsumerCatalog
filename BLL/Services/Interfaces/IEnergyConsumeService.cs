using BLL.DTO.Request;
using BLL.DTO.Response;
using DAL.Pagination;
using DAL.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IEnergyConsumeService
    {
        Task<IEnumerable<EnergyConsumeResponse>> GetAsync();
        Task<PagedList<EnergyConsumeResponse>> GetAsync(UnitParameters parameters);
        Task<EnergyConsumeResponse> GetCompleteEntityById(int id);
        Task<EnergyConsumeResponse> GetByIdAsync(int id);
        Task InsertAsync(UnitRequest request);
        Task UpdateAsync(UnitRequest request);
        Task DeleteAsync(int id);
    }
}
