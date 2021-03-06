using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Interfaces.Context;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, RowNumber = 1, Description = "Category 1 Description" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1", Description = "Product 1 Description", Price = 1000, Stock = 10, CategoryId = 1 },
                new Product { Id = 2, Name = "Product 2", Description = "Product 2 Description", Price = 2000, Stock = 20, CategoryId = 1 },
                new Product { Id = 3, Name = "Product 3", Description = "Product 3 Description", Price = 3000, Stock = 30, CategoryId = 1 },
                new Product { Id = 4, Name = "Product 4", Description = "Product 4 Description", Price = 4000, Stock = 40, CategoryId = 1 }
                );
        }
    }
}
