using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pizza.Data;
using Pizza.Models;

namespace Pizza.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Pizza.Data.PizzaContext _context;

        public IndexModel(Pizza.Data.PizzaContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
