using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eccomerce.Models;

namespace Eccomerce.Data
{
    public class EccomerceContext : DbContext
    {
        public EccomerceContext (DbContextOptions<EccomerceContext> options)
            : base(options)
        {
        }

        public DbSet<Eccomerce.Models.Department> Department { get; set; }
        public DbSet<Eccomerce.Models.Seller> Seller { get; set; }
        public DbSet<Eccomerce.Models.SalesRecord> SalesRecords { get; set; }

    }
}
