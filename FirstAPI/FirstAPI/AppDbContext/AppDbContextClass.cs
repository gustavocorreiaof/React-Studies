using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.AppDbContext;

public class AppDbContextClass : DbContext
{
    public AppDbContextClass(DbContextOptions<AppDbContextClass> options) : base(options){}
    DbSet<Category> Categories { get; set; }
    DbSet<Product> Products { get; set; }

}
