using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCarVip.Models
{
    public class ShopRepository
    {
        IQueryable<Product> Products { get; }
    }
}
