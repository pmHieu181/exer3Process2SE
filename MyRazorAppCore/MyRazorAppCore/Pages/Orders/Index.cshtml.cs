using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorAppCore.Data;
using MyRazorAppCore.Models;

namespace MyRazorAppCore.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly MyRazorAppCore.Data.ApplicationDbContext _context;

        public IndexModel(MyRazorAppCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Orders
                .Include(o => o.Agent) // Thêm dòng này
                .OrderByDescending(o => o.OrderDate) // Sắp xếp đơn hàng mới nhất lên đầu
                .ToListAsync();
        }
    }
}
