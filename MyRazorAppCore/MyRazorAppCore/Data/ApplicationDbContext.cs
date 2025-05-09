using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyRazorAppCore.Models;
using MyRazorAppCore.Models;

namespace MyRazorAppCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; } // Thêm DbSet cho Product
        public DbSet<Agent> Agents { get; set; }     // Thêm DbSet cho Agent
                                                     // ... (các DbSet khác)
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        // ...
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
