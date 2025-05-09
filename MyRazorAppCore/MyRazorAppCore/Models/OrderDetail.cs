using MyRazorAppCore.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyRazorAppCore.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; } // Khóa chính

        [Required]
        public int OrderId { get; set; } // Khóa ngoại đến Order
        public virtual Order? Order { get; set; } // Navigation property

        [Required(ErrorMessage = "Vui lòng chọn Sản phẩm.")]
        public int ProductId { get; set; } // Khóa ngoại đến Product
        public virtual Product? Product { get; set; } // Navigation property

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0.")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; } // Giá tại thời điểm mua hàng
    }
}