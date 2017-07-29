using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace yagamiraito.Dal
{
    public class YagamiDbContext : DbContext
    {
        public YagamiDbContext():base(GetDbContextOptions())
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        private static DbContextOptions GetDbContextOptions()
        {
            var conf = new DbContextOptions<YagamiDbContext>();
            return conf;
        }

        public DbSet<Product> Products { get; set; }
    }
}
