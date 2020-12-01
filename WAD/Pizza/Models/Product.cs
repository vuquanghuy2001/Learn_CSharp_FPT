using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string PriceSizeS { get; set; }
        public string PriceSizeL { get; set; }
        public string PriceSizeXL { get; set; }
        public byte[] Image { get; set; }
        public string UrlImage { get; set; }
    }
}
