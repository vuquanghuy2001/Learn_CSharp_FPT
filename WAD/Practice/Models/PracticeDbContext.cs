using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class PracticeDbContext:DbContext
    {
        public PracticeDbContext(DbContextOptions<PracticeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
