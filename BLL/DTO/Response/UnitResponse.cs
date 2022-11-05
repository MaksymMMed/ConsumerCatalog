using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Response
{
    public class UnitResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public int OwnerId { get; set; }
        public Consumer? Owner { get; set; }
        public List<EnergyConsume>? ConsumeEnergy { get; set; }
    }
}
