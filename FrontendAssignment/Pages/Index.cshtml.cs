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
    public class IndexModel : PageModel
    {
        private readonly FrontendAssignment.Data.FrontendAssignmentContext _context;

        public IndexModel(FrontendAssignment.Data.FrontendAssignmentContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }
        public IList<Products> PopularProducts { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.OrderByDescending(p => p.Clicks).ToListAsync();
            PopularProducts = await _context.Products.OrderByDescending(p => p.Clicks).Take(2).ToListAsync();
        }

    }
}
