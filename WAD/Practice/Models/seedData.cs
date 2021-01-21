using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PracticeDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<PracticeDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        Name = "Vu Quang Huy",
                        Department = "Giam Doc",
                        Address = "Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Truong Thanh Tu",
                        Department = "Bao Ve",
                        Address = "Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Nguyen Dinh Hieu",
                        Department = "Trong xe",
                        Address = "Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Do Thi Chan Hoa",
                        Department = "Rua Bat",
                        Address = "Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Pham Tuan",
                        Department = "Lau Dia",
                        Address = "Ha Noi"
                    }


                    );
                context.SaveChanges();
            }
        }
    }
}
