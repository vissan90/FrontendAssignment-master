using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FrontendAssignment.Data;
using FrontendAssignment.Model;

namespace FrontendAssignment
{
    public class DetailsModel : PageModel
    {
        private readonly FrontendAssignment.Data.FrontendAssignmentContext _context;

        public DetailsModel(FrontendAssignment.Data.FrontendAssignmentContext context)
        {
            _context = context;
        }

        public Products Products { get; set; }

        public IList<Products> PopularProducts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           

            Products = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            //Increment clicks

            Products.Clicks += 1;

            _context.SaveChanges();

            PopularProducts = await _context.Products.OrderByDescending(p => p.Clicks).Take(4).ToListAsync();

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
