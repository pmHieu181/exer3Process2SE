using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorAppCore.Models; // Đảm bảo đây là namespace đúng
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorAppCore.Pages.Orders // Đảm bảo đây là namespace đúng
{
    public class DetailsModel : PageModel
    {
        private readonly MyRazorAppCore.Data.ApplicationDbContext _context; // Thay thế bằng DbContext thực tế của bạn

        public DetailsModel(MyRazorAppCore.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) // Tham số 'id' khớp với asp-route-id
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Orders
                .Include(o => o.Agent)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                .AsNoTracking()
                // Sửa ở đây: Giả sử khóa chính của Order là "OrderId"
                .FirstOrDefaultAsync(m => m.OrderId == id);

            if (Order == null)
            {
                return NotFound(); // Nếu không tìm thấy đơn hàng, trả về 404
            }
            return Page();
        }
    }
}
