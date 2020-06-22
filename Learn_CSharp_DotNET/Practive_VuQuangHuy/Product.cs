using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practive_VuQuangHuy
{
    abstract class Product
    {
        public int Id;
        public string Name;
        public int Price;
        public string Producer;
        
        public Product(int Id,string Name,int Price,string Producer)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Producer = Producer;
        }

        public abstract double computeTax();
    }
}
