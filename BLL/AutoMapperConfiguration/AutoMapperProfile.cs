using AutoMapper;
using BLL.DTO.Request;
using BLL.DTO.Response;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AutoMapperConfiguration
{
    public class AutoMapperProfile: Profile
    {
        private void CreateConsumerProfile()
        {
            CreateMap<ConsumerRequest, Consumer>();
            CreateMap<Consumer, ConsumerResponse>();
        }
        private void CreateEnergyConsumerProfile()
        {
            CreateMap<EnergyConsumeRequest, EnergyConsume>();
            CreateMap<EnergyConsume, EnergyConsumeResponse>();
        }
        private void CreateUnitProfile()
        {
            CreateMap<UnitRequest, Unit>();
            CreateMap<Unit, UnitResponse>();
        }

        private void CreateIssueProfile()
        {
            CreateMap<Issue,IssueResponse>();
        }
        public AutoMapperProfile()
        {
            CreateConsumerProfile();
            CreateUnitProfile();
            CreateEnergyConsumerProfile();
            CreateIssueProfile();
        }
    }
}
