using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorAppCore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MyRazorAppCore.Pages.Reports
{
    [Authorize]
    public class BestSellingProductsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public BestSellingProductsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<BestSellingProductViewModel> ProductsList { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? EndDate { get; set; }

        [BindProperty(SupportsGet = true)]
        [Range(1, 100, ErrorMessage = "Số lượng Top phải từ 1 đến 100")]
        public int TopN { get; set; } = 10; // Mặc định top 10

        public async Task OnGetAsync()
        {
            // Đảm bảo EndDate bao gồm cả ngày được chọn
            var actualEndDate = EndDate.HasValue ? EndDate.Value.AddDays(1) : (DateTime?)null;

            var query = _context.OrderDetails
                            .Include(od => od.Product) // Để lấy tên sản phẩm
                            .Include(od => od.Order)   // Để lọc theo ngày OrderDate
                            .AsQueryable();

            if (StartDate.HasValue)
            {
                query = query.Where(od => od.Order.OrderDate >= StartDate.Value);
            }
            if (actualEndDate.HasValue)
            {
                query = query.Where(od => od.Order.OrderDate < actualEndDate.Value);
            }

            ProductsList = await query
                .GroupBy(od => new { od.ProductId, od.Product.Name }) // Nhóm theo ID và Tên Sản phẩm
                .Select(g => new BestSellingProductViewModel
                {
                    ProductId = g.Key.ProductId,
                    ProductName = g.Key.Name,
                    TotalQuantitySold = g.Sum(od => od.Quantity),
                    TotalRevenue = g.Sum(od => od.Quantity * od.UnitPrice)
                })
                .OrderByDescending(p => p.TotalQuantitySold) // Sắp xếp theo số lượng bán
                .Take(TopN)
                .ToListAsync();
        }
    }

    public class BestSellingProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int TotalQuantitySold { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
