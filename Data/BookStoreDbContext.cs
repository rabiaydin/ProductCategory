using Microsoft.EntityFrameworkCore;
using ProductCategory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Data
{
    public class BookStoreDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>()
                        .HasMany(x => x.Products)
                        .WithOne(y => y.Category)
                        .HasForeignKey(z => z.CategoryId);


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\Mssqllocaldb;Database=BookStoreDb;Integrated Security=yes");
            }
        }
    }
}
