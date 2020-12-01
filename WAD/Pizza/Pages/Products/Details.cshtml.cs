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
    public class DetailsModel : PageModel
    {
        private readonly Pizza.Data.PizzaContext _context;

        public DetailsModel(Pizza.Data.PizzaContext context)
        {
            _context = context;
        }

        public Product Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FirstOrDefaultAsync(m => m.ProductID == id);

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
