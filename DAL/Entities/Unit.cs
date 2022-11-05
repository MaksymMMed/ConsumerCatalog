using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Unit
    {
        public Unit()
        {
            ConsumeEnergy = new();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public int OwnerId { get; set; }
        public Consumer? Owner { get; set; }
        public List<EnergyConsume>? ConsumeEnergy { get; set; }
    }
}
