using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorAppCore.Data;
using MyRazorAppCore.Models;

namespace MyRazorAppCore.Pages.Agents
{
    public class IndexModel : PageModel
    {
        private readonly MyRazorAppCore.Data.ApplicationDbContext _context;

        public IndexModel(MyRazorAppCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Agent> Agent { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Agent = await _context.Agents.ToListAsync();
        }
    }
}
