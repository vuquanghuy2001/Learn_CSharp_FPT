using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopCar.Models.DBContexts;

namespace ShopCar.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            TAzureDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<TAzureDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Lamboghini",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Ferari",
                        Price = 270
                    },
                    new Product
                    {
                        Name = "camry",
                        Price = 175
                    },
                    new Product
                    {
                        Name = "morning",
                        Price = 75
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
