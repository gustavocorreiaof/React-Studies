using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.AppDbContext;

public class AppDbContextClass : DbContext
{
    public AppDbContextClass(DbContextOptions<AppDbContextClass> options) : base(options){}
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

}
