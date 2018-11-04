using ECommerce.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebEECommerce_Core_Vue_SPA.Data.Entities;

namespace ECommerce.Data
{
    public class EcommerceContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasIndex(b => b.Slug)
            .IsUnique();
        }
    }
}