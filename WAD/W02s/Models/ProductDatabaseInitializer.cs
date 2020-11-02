using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace W02s.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID=1,
                    CategoryName="Huy"
                },
                new Category
                {
                    CategoryID=2,
                    CategoryName="Quang"
                },
                new Category
                {
                    CategoryID=3,
                    CategoryName="Vu"
                },
                new Category
                {
                    CategoryID=4,
                    CategoryName="Trinh"
                },
            };
            return categories;
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID=1,
                    productname="abcd",
                    UnitPrice=22.50,
                    Description="abcddj",
                    ImagePath="logo.png",
                    CategoryID=1
                },
                new Product
                {
                    ProductID=2,
                    productname="abcd",
                    UnitPrice=22.50,
                    Description="abcddj",
                    ImagePath="logo.png",
                    CategoryID=2
                },
                new Product
                {
                    ProductID=3,
                    productname="abcd",
                    UnitPrice=22.50,
                    Description="abcddj",
                    ImagePath="logo.png",
                    CategoryID=3
                },
                new Product
                {
                    ProductID=4,
                    productname="abcd",
                    UnitPrice=22.50,
                    Description="abcddj",
                    ImagePath="logo.png",
                    CategoryID=4
                },
            };
            return products;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void InitializeDatabase(ProductContext context)
        {
            base.InitializeDatabase(context);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}