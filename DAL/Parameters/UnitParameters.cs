using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Parameters
{
    public class UnitParameters:QueryStringParameters
    {
        public int? OwnerId { get; set; }
        public string? UnitName { get; set; }
    }
}
