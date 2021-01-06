using ShopCar.Models.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Models
{
    public class EFTAzureRepository : TAzureRepository
    {
        private TAzureDbContext context;

        public EFTAzureRepository(TAzureDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
