using System.ComponentModel.DataAnnotations;
using MyRazorAppCore.Models;

namespace MyRazorAppCore.Models
{
    public class Agent
    {
        public int AgentId { get; set; } // Khóa chính

        [Required(ErrorMessage = "Tên đại lý là bắt buộc.")]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(200)]
        public string? ContactInfo { get; set; }

        // Navigation property cho Orders (sẽ thêm sau)
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
