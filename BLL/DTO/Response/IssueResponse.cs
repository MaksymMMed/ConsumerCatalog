using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Response
{
    public class IssueResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UnitId;
        public Unit? Unit;
        public bool Status;
    }
}
