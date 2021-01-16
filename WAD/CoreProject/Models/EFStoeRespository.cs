using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class EFStoeRespository:IStoreRepository
    {
        private CoreProjectDbContext context;

        public EFStoeRespository(CoreProjectDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
