using MyRazorAppCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyRazorAppCore.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn Đại lý.")]
        public int AgentId { get; set; } // Khóa ngoại đến Agent
        public virtual Agent? Agent { get; set; } // Navigation property

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        // Navigation property: một Order có nhiều OrderDetail
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>(); // Khởi tạo để tránh lỗi null
            OrderDate = DateTime.UtcNow; // Mặc định ngày đặt hàng
        }
    }
}