using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UnitId;
        public Unit? Unit;
        public bool Status;

    }
}
