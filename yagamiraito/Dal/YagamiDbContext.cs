﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace yagamiraito.Dal
{
    public class YagamiDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql("Server=45.76.54.192;database=yagami;uid=root;pwd=maria@fzp;");

        public DbSet<Product> Products { get; set; }
    }
}
