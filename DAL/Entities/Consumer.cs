using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Consumer
    {
        public Consumer()
        {
            OwnedUnit = new();
        }
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName{ get; set; }
        public virtual List<Unit>? OwnedUnit { get; set; }   
    }
}
