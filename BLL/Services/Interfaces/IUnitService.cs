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
    public interface IUnitService
    {
        Task<IEnumerable<UnitResponse>> GetAsync();
        Task<PagedList<UnitResponse>> GetAsync(UnitParameters parameters);
        Task<UnitResponse> GetCompleteEntityById(int id);
        Task<UnitResponse> GetByIdAsync(int id);
        Task<IEnumerable<IssueResponse>> GetIssues(int id);
        Task<IEnumerable<EnergyConsumeResponse>> GetEnergyConsumes(int id);
        Task InsertAsync(UnitRequest request);
        Task UpdateAsync(UnitRequest request);
        Task DeleteAsync(int id);
    }
}
