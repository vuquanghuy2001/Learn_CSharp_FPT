using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Models
{
    public interface TAzureRepository
    {
        IQueryable<Product> Products { get; }   
    }
}
