using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorAppCore.Data;
using MyRazorAppCore.Models;
using Microsoft.EntityFrameworkCore;

namespace MyRazorAppCore.Pages.Orders
{
    [Authorize]
    public class PrintModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public PrintModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Order OrderToPrint { get; set; }

        public async Task<IActionResult> OnGetAsync(int orderId) // Tên tham số phải khớp với route: {orderId:int}
        {
            OrderToPrint = await _context.Orders
                                .Include(o => o.Agent)
                                .Include(o => o.OrderDetails)
                                    .ThenInclude(od => od.Product)
                                .AsNoTracking() // Dùng AsNoTracking vì đây là trang chỉ đọc, giúp tăng hiệu suất
                                .FirstOrDefaultAsync(o => o.OrderId == orderId);

            if (OrderToPrint == null)
            {
                // Hoặc return NotFound(); hoặc set một thông báo lỗi và vẫn return Page();
                // Ở đây, view Print.cshtml đã có xử lý OrderToPrint == null
            }
            return Page();
        }
    }
}
