using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using MyRazorAppCore.Data;
using MyRazorAppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorAppCore.Pages.Reports
{
    [Authorize] // Yêu cầu đăng nhập
    public class ProductPurchasersModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ProductPurchasersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Danh sách kết quả
        public List<ProductPurchaserViewModel> PurchasersList { get; set; } = new List<ProductPurchaserViewModel>();

        // Dùng để đổ danh sách Sản phẩm vào Dropdown
        public SelectList? ProductSL { get; set; }

        // Thuộc tính để binding với filter từ query string
        [BindProperty(SupportsGet = true)]
        public int? SelectedProductId { get; set; }

        public string? SelectedProductName { get; private set; }

        public async Task OnGetAsync()
        {
            // Tải danh sách sản phẩm cho dropdown
            var products = await _context.Products.OrderBy(p => p.Name).ToListAsync();
            ProductSL = new SelectList(products, nameof(Product.ProductId), nameof(Product.Name), SelectedProductId);

            if (SelectedProductId.HasValue)
            {
                var selectedProduct = products.FirstOrDefault(p => p.ProductId == SelectedProductId.Value);
                SelectedProductName = selectedProduct?.Name;

                PurchasersList = await _context.OrderDetails
                    .Where(od => od.ProductId == SelectedProductId.Value)
                    .Include(od => od.Order)
                        .ThenInclude(o => o!.Agent) // Agent trong Order có thể null nếu không được set đúng
                    .GroupBy(od => new { od.Order!.AgentId, od.Order.Agent!.Name, od.Order.Agent.ContactInfo })
                    .Select(g => new ProductPurchaserViewModel
                    {
                        AgentId = g.Key.AgentId,
                        AgentName = g.Key.Name ?? "N/A", // Xử lý nếu tên Agent là null
                        AgentContact = g.Key.ContactInfo ?? "N/A", // Xử lý nếu contact là null
                        TotalQuantityBought = g.Sum(od => od.Quantity),
                        LastPurchaseDate = g.Max(od => od.Order!.OrderDate)
                    })
                    .OrderByDescending(p => p.TotalQuantityBought)
                    .ThenBy(p => p.AgentName)
                    .ToListAsync();
            }
        }
    }

    // ViewModel để chứa dữ liệu hiển thị
    public class ProductPurchaserViewModel
    {
        public int? AgentId { get; set; } // Cho phép AgentId có thể null nếu Agent trong Order là null
        public string AgentName { get; set; } = string.Empty;
        public string AgentContact { get; set; } = string.Empty;
        public int TotalQuantityBought { get; set; }
        public DateTime LastPurchaseDate { get; set; }
    }
}