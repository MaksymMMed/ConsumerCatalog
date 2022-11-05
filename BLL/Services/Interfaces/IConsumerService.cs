using AutoMapper.Internal;
using BLL.DTO.Request;
using BLL.DTO.Response;
using DAL.Entities;
using DAL.Pagination;
using DAL.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IConsumerService
    {
        Task<IEnumerable<ConsumerResponse>> GetAsync();
        Task<PagedList<ConsumerResponse>> GetAsync(ConsumerParameters parameters);
        Task<PagedList<UnitResponse>> GetUnitsAsync(int Id, UnitParameters parameters);
        Task<ConsumerResponse> GetCompleteEntityById(int id);
        Task<ConsumerResponse> GetByIdAsync(int id);
        Task InsertAsync(ConsumerRequest request);
        Task UpdateAsync(ConsumerRequest request);
        Task DeleteAsync(int id);
    }
}
