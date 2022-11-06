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
    public class EnergyConsumeService:IEnergyConsumeService
    {
        IUnitOfWork UnitOfWork;
        IMapper mapper;

        public EnergyConsumeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            await UnitOfWork.energyConsumeRepository.DeleteAsync(id);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<EnergyConsumeResponse>> GetAsync()
        {
            var items = await UnitOfWork.energyConsumeRepository.GetAsync();
            return items.Select(mapper.Map<EnergyConsume, EnergyConsumeResponse>);
        }

        public async Task<PagedList<EnergyConsumeResponse>> GetAsync(EnergyConsumeParameters parameters)
        {
            var items = await UnitOfWork.energyConsumeRepository.GetAsync(parameters);
            return items.Map(mapper.Map<EnergyConsume, EnergyConsumeResponse>);
        }

        public async Task<EnergyConsumeResponse> GetByIdAsync(int id)
        {
            var item = await UnitOfWork.energyConsumeRepository.GetByIdAsync(id);
            return mapper.Map<EnergyConsume, EnergyConsumeResponse>(item);
        }

        public async Task<EnergyConsumeResponse> GetCompleteEntityById(int id)
        {
            var item = await UnitOfWork.energyConsumeRepository.GetCompleteEntityAsync(id);
            return mapper.Map<EnergyConsume, EnergyConsumeResponse>(item);
        }

        public async Task InsertAsync(EnergyConsumeRequest request)
        {
            var item = mapper.Map<EnergyConsumeRequest, EnergyConsume>(request);
            await UnitOfWork.energyConsumeRepository.InsertAsync(item);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(EnergyConsumeRequest request)
        {
            var item = mapper.Map<EnergyConsumeRequest, EnergyConsume>(request);
            await UnitOfWork.energyConsumeRepository.UpdateAsync(item);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}
