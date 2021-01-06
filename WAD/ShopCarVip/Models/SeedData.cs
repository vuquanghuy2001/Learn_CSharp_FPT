using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopCarVip.Models.DbContexts;

namespace ShopCarVip.Models
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
                        Price = 276
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
