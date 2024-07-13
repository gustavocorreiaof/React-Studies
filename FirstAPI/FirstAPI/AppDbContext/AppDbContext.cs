using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.AppDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    DbSet<Category> Categories { get; set; }
    DbSet<Product> Products { get; set; }

}
