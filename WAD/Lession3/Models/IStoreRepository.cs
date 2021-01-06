using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lession3.Models
{
    public class IStoreRepository
    {
       IQueryable<Product> Products { get;}
    }
}

//design pattern
//provides a consistent way to access the
//features presented by the database context class

// command line
//dotnet ef migrations add Initial
//folder Migrations ... timestamp_Initial.cs is created