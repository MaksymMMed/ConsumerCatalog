using DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeding
{
    public class IssueSeeder : ISeeder<Issue>
    {
        private static readonly List<Issue> issue = new()

        {
            new Issue{
                Id = 1,
                Title = "Repair",
                UnitId = 1,
                Status = false
            },
            new Issue{
                Id = 2,
                Title = "Repair",
                UnitId = 2,
                Status = false
            },
            new Issue{
                Id = 3,
                Title = "Repair",
                UnitId = 3,
                Status = false
            }
        };
        public void Seeding(EntityTypeBuilder<Issue> builder) => builder.HasData(issue);
    }
}
