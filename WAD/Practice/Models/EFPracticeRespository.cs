using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class EFPracticeRespository:IStoreRepository
    {
        private PracticeDbContext context;

        public EFPracticeRespository(PracticeDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
}
