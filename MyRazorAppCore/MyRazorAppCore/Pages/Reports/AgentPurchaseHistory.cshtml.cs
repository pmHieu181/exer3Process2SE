using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyRazorAppCore.Data;
using MyRazorAppCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorAppCore.Pages.Reports
{
    [Authorize] // Yêu cầu đăng nhập để xem báo cáo
    public class AgentPurchaseHistoryModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AgentPurchaseHistoryModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Danh sách đơn hàng kết quả
        public IList<Order> OrdersResult { get; set; } = new List<Order>();

        // Dùng để đổ danh sách Đại lý vào Dropdown
        public SelectList? AgentSL { get; set; }

        // Thuộc tính để binding với các filter từ query string
        [BindProperty(SupportsGet = true)]
        public int? SelectedAgentId { get; set; }

        [BindProperty(SupportsGet = true)]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        public string? SelectedAgentName { get; private set; }

        public async Task OnGetAsync()
        {
            // Tải danh sách đại lý cho dropdown
            var agents = await _context.Agents.OrderBy(a => a.Name).ToListAsync();
            AgentSL = new SelectList(agents, nameof(Agent.AgentId), nameof(Agent.Name), SelectedAgentId);

            if (SelectedAgentId.HasValue)
            {
                var selectedAgent = agents.FirstOrDefault(a => a.AgentId == SelectedAgentId.Value);
                SelectedAgentName = selectedAgent?.Name;

                var query = _context.Orders
                                    .Where(o => o.AgentId == SelectedAgentId.Value)
                                    .Include(o => o.Agent) // Mặc dù đã có AgentId, Include để lấy đối tượng Agent đầy đủ nếu cần
                                    .Include(o => o.OrderDetails)
                                        .ThenInclude(od => od.Product) // Để hiển thị tên sản phẩm
                                    .AsQueryable();

                if (StartDate.HasValue)
                {
                    query = query.Where(o => o.OrderDate.Date >= StartDate.Value.Date);
                }
                if (EndDate.HasValue)
                {
                    // Lấy đến cuối ngày của EndDate
                    var actualEndDate = EndDate.Value.Date.AddDays(1).AddTicks(-1);
                    query = query.Where(o => o.OrderDate <= actualEndDate);
                }

                OrdersResult = await query.OrderByDescending(o => o.OrderDate).ToListAsync();
            }
        }
    }
}