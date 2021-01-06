using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lession3.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        [Column(TypeName="decimal(8,2")]
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}

//Adding Data to the Application

// -Using Entity Frameword Core: ORM framework Object to Relational Mapping (mapping doi tuong quan he trong co so du lieu

//dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.1
//dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.1

//Installing the Entity Framework Core Tool Package
//dotnet tool uninstall --global dotnet-ef
//dotnet tool install --global dotnet-ef --version 3.1.1
