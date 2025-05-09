using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // For Column Type

namespace MyRazorAppCore.Models
{
    public class Product
    {
        public int ProductId { get; set; } // Khóa chính

        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên sản phẩm không được vượt quá 100 ký tự.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Mô tả không được vượt quá 500 ký tự.")]
        public string? Description { get; set; } // Dấu ? cho phép null

        [Required(ErrorMessage = "Giá sản phẩm là bắt buộc.")]
        [Range(0.01, 100000000, ErrorMessage = "Giá sản phẩm phải lớn hơn 0.")]
        [Column(TypeName = "decimal(18, 2)")] // Chỉ định kiểu dữ liệu trong CSDL
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Số lượng tồn kho không thể âm.")]
        public int StockQuantity { get; set; }

        // Navigation property cho OrderDetails (sẽ thêm sau)
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}