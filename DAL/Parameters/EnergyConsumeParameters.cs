using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Parameters
{
    public class EnergyConsumeParameters:QueryStringParameters
    {
       public int? UnitId { get; set; }
    }
}
