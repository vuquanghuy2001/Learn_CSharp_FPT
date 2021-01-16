using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class CoreProjectDbContext:DbContext
    {
        public CoreProjectDbContext(DbContextOptions<CoreProjectDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
