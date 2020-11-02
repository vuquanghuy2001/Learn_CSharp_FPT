using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab2.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(): base("Lab2") 
        { 
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cartltem> ShoppingCartItems { get; set; }
    }
}