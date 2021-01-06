using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShopCar.Models.DBContexts
{
    public class TAzureDbContext:DbContext
    {
        public TAzureDbContext(DbContextOptions<TAzureDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
