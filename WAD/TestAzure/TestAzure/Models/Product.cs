﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestAzure.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(8,2)*")]
        public decimal Price { get; set; }
    }
}
