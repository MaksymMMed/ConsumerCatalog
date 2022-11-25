using AutoMapper;
using BLL.DTO.Request;
using BLL.DTO.Response;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Pagination;
using DAL.Parameters;
using DAL.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Realization
{
    public class UnitService : IUnitService
    {
        IUnitOfWork UnitOfWork;
        IMapper mapper;

        public UnitService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            await UnitOfWork.unitRepository.DeleteAsync(id);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<UnitResponse>> GetAsync()
        {
            var items = await UnitOfWork.unitRepository.GetAsync();
            return items.Select(mapper.Map<Unit, UnitResponse>);
        }

        public async Task<PagedList<UnitResponse>> GetAsync(UnitParameters parameters)
        {
            var items = await UnitOfWork.unitRepository.GetAsync(parameters);
            return items.Map(mapper.Map<Unit, UnitResponse>);
        }

        public async Task<UnitResponse> GetByIdAsync(int id)
        {
            var item = await UnitOfWork.unitRepository.GetByIdAsync(id);
            return mapper.Map<Unit, UnitResponse>(item);
        }

        public async Task<UnitResponse> GetCompleteEntityById(int id)
        {
            var item = await UnitOfWork.unitRepository.GetCompleteEntityAsync(id);
            return mapper.Map<Unit, UnitResponse>(item);
        }

        public async Task<IEnumerable<EnergyConsumeResponse>> GetEnergyConsumes(int id)
        {
            var items = await UnitOfWork.unitRepository.GetEnergyConsumes(id);
            return items.Select(mapper.Map<EnergyConsume, EnergyConsumeResponse>);
        }

        public async Task<IEnumerable<IssueResponse>> GetIssues(int id)
        {
            var items = await UnitOfWork.unitRepository.GetIssues(id);
            return items.Select(mapper.Map<Issue, IssueResponse>);
        }

        public async Task InsertAsync(UnitRequest request)
        {
            var item = mapper.Map<UnitRequest, Unit>(request);
            await UnitOfWork.unitRepository.InsertAsync(item);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(UnitRequest request)
        {
            var item = mapper.Map<UnitRequest, Unit>(request);
            await UnitOfWork.unitRepository.UpdateAsync(item);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
