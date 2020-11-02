using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace W02s2.Models
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
                    CategoryName="Cars"
                },
                new Category
                {
                    CategoryID=2,
                    CategoryName="Planes"
                },
                new Category
                {
                    CategoryID=3,
                    CategoryName="Trucks"
                },
                new Category
                {
                    CategoryID=4,
                    CategoryName="Boats"
                },
                new Category
                {
                    CategoryID=5,
                    CategoryName="Rokets"
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
                    productname="Covertible",
                    UnitPrice=22.5,
                    Description="abcddj",
                    ImagePath="carconvert.png",
                    CategoryID=1
                },
                new Product
                {
                    ProductID=2,
                    productname="Ace Plane",
                    UnitPrice=22.50,
                    Description="abcddj",
                    ImagePath="planeace.png",
                    CategoryID=2
                },
                new Product
                {
                    ProductID=3,
                    productname="Early Truck",
                    UnitPrice=22.50,
                    Description="abcddj",
                    ImagePath="planepaper.png",
                    CategoryID=3
                },
                new Product
                {
                    ProductID=4,
                    productname="Big Ship",
                    UnitPrice=22.50,
                    Description="abcddj",
                    ImagePath="boatbig.png",
                    CategoryID=4
                },
                new Product
                {
                    ProductID=5,
                    productname="Rocket",
                    UnitPrice=22.50,
                    Description="abcddj",
                    ImagePath="rocket.png",
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