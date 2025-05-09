using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyRazorAppCore.Data;
using MyRazorAppCore.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyRazorAppCore.Pages.Orders
{
    [Authorize] // Chỉ người dùng đã đăng nhập mới tạo được đơn hàng
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; } = new Order();

        // Dùng để bind danh sách các chi tiết đơn hàng từ form
        [BindProperty]
        public List<OrderDetailInput> OrderDetailInputs { get; set; } = new List<OrderDetailInput>();

        // Dùng để đổ dữ liệu vào các dropdown list
        public SelectList AgentSL { get; set; }
        public SelectList ProductSL { get; set; }

        // Lớp nhỏ để giúp bind dữ liệu cho từng dòng chi tiết đơn hàng
        public class OrderDetailInput
        {
            [Required(ErrorMessage = "Vui lòng chọn sản phẩm.")]
            public int ProductId { get; set; }
            [Required(ErrorMessage = "Số lượng là bắt buộc.")]
            [Range(1, 1000, ErrorMessage = "Số lượng phải từ 1 đến 1000.")]
            public int Quantity { get; set; }
        }

        public async Task OnGetAsync()
        {
            AgentSL = new SelectList(await _context.Agents.OrderBy(a => a.Name).ToListAsync(), nameof(Agent.AgentId), nameof(Agent.Name));
            ProductSL = new SelectList(await _context.Products.Where(p => p.StockQuantity > 0).OrderBy(p => p.Name).ToListAsync(), nameof(Product.ProductId), nameof(Product.Name));

            // Thêm một dòng chi tiết rỗng ban đầu để người dùng nhập
            OrderDetailInputs.Add(new OrderDetailInput());
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Load lại SelectLists phòng trường hợp ModelState không hợp lệ và cần hiển thị lại form
            AgentSL = new SelectList(await _context.Agents.OrderBy(a => a.Name).ToListAsync(), nameof(Agent.AgentId), nameof(Agent.Name), Order.AgentId);
            ProductSL = new SelectList(await _context.Products.Where(p => p.StockQuantity > 0).OrderBy(p => p.Name).ToListAsync(), nameof(Product.ProductId), nameof(Product.Name));

            // Loại bỏ các dòng chi tiết rỗng (nếu người dùng không chọn sản phẩm)
            OrderDetailInputs.RemoveAll(i => i.ProductId == 0 || i.Quantity == 0);

            if (OrderDetailInputs.Count == 0)
            {
                ModelState.AddModelError("OrderDetailInputs", "Đơn hàng phải có ít nhất một sản phẩm.");
            }

            if (!ModelState.IsValid)
            {
                // Nếu có lỗi, đảm bảo có ít nhất một dòng input để hiển thị lại form
                if (!OrderDetailInputs.Any()) OrderDetailInputs.Add(new OrderDetailInput());
                return Page();
            }

            // Xử lý lưu Order và OrderDetails
            Order.OrderDetails = new List<OrderDetail>();
            decimal totalAmount = 0;

            foreach (var inputDetail in OrderDetailInputs)
            {
                var product = await _context.Products.FindAsync(inputDetail.ProductId);
                if (product == null)
                {
                    ModelState.AddModelError("", $"Không tìm thấy sản phẩm ID {inputDetail.ProductId}.");
                    if (!OrderDetailInputs.Any()) OrderDetailInputs.Add(new OrderDetailInput());
                    return Page();
                }
                if (product.StockQuantity < inputDetail.Quantity)
                {
                    ModelState.AddModelError("", $"Sản phẩm '{product.Name}' không đủ số lượng tồn kho (còn {product.StockQuantity}).");
                    if (!OrderDetailInputs.Any()) OrderDetailInputs.Add(new OrderDetailInput());
                    return Page();
                }

                var orderDetail = new OrderDetail
                {
                    ProductId = product.ProductId,
                    Quantity = inputDetail.Quantity,
                    UnitPrice = product.Price // Lấy giá hiện tại của sản phẩm
                };
                Order.OrderDetails.Add(orderDetail);
                totalAmount += (orderDetail.Quantity * orderDetail.UnitPrice);

                // Giảm số lượng tồn kho
                product.StockQuantity -= inputDetail.Quantity;
                _context.Products.Update(product);
            }

            Order.TotalAmount = totalAmount;
            Order.OrderDate = DateTime.UtcNow; // Ghi nhận thời gian hiện tại

            _context.Orders.Add(Order); // EF Core sẽ tự động thêm các OrderDetails liên quan
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index"); // Chuyển đến trang danh sách đơn hàng
        }
    }
}
