using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopCarVip.Models.DbContexts;

namespace ShopCarVip.Models
{
    public class EFTAzureRepository : ShopRepository
    {
        private TAzureDbContext context;

        public EFTAzureRepository(TAzureDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
