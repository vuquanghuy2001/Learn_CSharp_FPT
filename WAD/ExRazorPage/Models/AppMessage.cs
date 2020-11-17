using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExRazorPage.Models
{
    public class AppMessage
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ImgURL { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
    }
}
