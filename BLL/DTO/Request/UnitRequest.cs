using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Request
{
    public class UnitRequest
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public int OwnerId { get; set; }
    }
}
