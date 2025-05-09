using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorAppCore.Models;
using MyRazorAppCore.Data;

namespace MyRazorAppCore.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly MyRazorAppCore.Data.ApplicationDbContext _context;

        public IndexModel(MyRazorAppCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
