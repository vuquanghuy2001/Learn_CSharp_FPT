using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Models
{
    public class Product
    {
        public long ProductID { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
