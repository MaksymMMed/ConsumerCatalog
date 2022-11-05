﻿using AutoMapper;
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
    public class ConsumerService : IConsumerService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper mapper;

        public async Task DeleteAsync(int id)
        {
            await UnitOfWork.consumerRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ConsumerResponse>> GetAsync()
        {
            var items = await UnitOfWork.consumerRepository.GetAsync();
            return items.Select(mapper.Map< Consumer, ConsumerResponse>);
        }

        public async Task<PagedList<ConsumerResponse>> GetAsync(ConsumerParameters parameters)
        {
            var items = await UnitOfWork.consumerRepository.GetAsync(parameters);
            return items.Map(mapper.Map<Consumer, ConsumerResponse>);
        }

        public async Task<ConsumerResponse> GetByIdAsync(int id)
        {
            var item = await UnitOfWork.consumerRepository.GetByIdAsync(id);
            return mapper.Map<Consumer, ConsumerResponse>(item);
        }

        public async Task<ConsumerResponse> GetCompleteEntityById(int id)
        {
            var item = await UnitOfWork.consumerRepository.GetCompleteEntityAsync(id);
            return mapper.Map<Consumer, ConsumerResponse>(item);
        }

        public async Task<PagedList<UnitResponse>> GetUnitsAsync(int Id, UnitParameters parameters)
        {
            var items = await UnitOfWork.consumerRepository.GetUnitsAsync(Id, parameters);
            return items.Map(mapper.Map<Unit, UnitResponse>);
        }

        public async Task InsertAsync(ConsumerRequest request)
        {
            var Consumer =  mapper.Map<ConsumerRequest, Consumer>(request);
            await UnitOfWork.consumerRepository.InsertAsync(Consumer);
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(ConsumerRequest request)
        {
            var Consumer = mapper.Map<ConsumerRequest, Consumer>(request);
            await UnitOfWork.consumerRepository.UpdateAsync(Consumer);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}