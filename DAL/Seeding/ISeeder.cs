using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seeding
{
    public interface ISeeder<T> where T : class
    {
        void Seeding(EntityTypeBuilder<T> builder);
    }
}
