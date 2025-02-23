using Microsoft.EntityFrameworkCore;
using MVCmicrosoft.Models;

namespace MVCmicrosoft.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductModel> Products { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductModel>()
        //        .Property(p => p.Price)
        //        .HasColumnType("decimal(18,2)");
        //}

    }
}
