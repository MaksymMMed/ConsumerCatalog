using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Response
{
    public class EnergyConsumeResponse
    {
        public int Id { get; set; }
        public int SizeDay { get; set; }
        public int SizeNight { get; set; }
        public DateTime Date { get; set; }
        public int UnitId { get; set; }
        public Unit? Unit { get; set; }
    }
}
