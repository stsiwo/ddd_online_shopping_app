using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StsOnlineShopApp.Infrastructure.DataEntity;

namespace StsOnlineShopApp.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<SubImage> SubImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Product ===1:M=== Review
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Reviews)
                .WithOne(r => r.Product);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // Product ===1:M=== SubImage
            modelBuilder.Entity<Product>()
                .HasMany(p => p.SubImages)
                .WithOne(s => s.Product);

            modelBuilder.Entity<SubImage>()
                .HasOne(s => s.Product)
                .WithMany(p => p.SubImages)
                .HasForeignKey(s => s.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // Product ===N:1==== SubCategory 
            modelBuilder.Entity<Product>()
                .HasOne(p => p.SubCategory)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SubCategoryId);

            modelBuilder.Entity<SubCategory>()
                .HasMany(s => s.Products)
                .WithOne(p => p.SubCategory);

            // Category ===1:M=== SubCategory
            modelBuilder.Entity<Category>()
                .HasMany(c => c.SubCategories)
                .WithOne(s => s.Category);

            modelBuilder.Entity<SubCategory>()
                .HasOne(s => s.Category)
                .WithMany(c => c.SubCategories);
        }
    }
}
