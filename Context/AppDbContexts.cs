using Microsoft.EntityFrameworkCore;
using ProductRabbify.Models;

namespace ProductRabbify.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
