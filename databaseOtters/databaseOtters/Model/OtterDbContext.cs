using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace databaseOtters.Model
{
    public class OtterDbContext : DbContext
    {
        public OtterDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
    public virtual DbSet<Otter> Otters { get; set; }
}
