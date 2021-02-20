using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class FaqsContext : DbContext
    {
        public FaqsContext(DbContextOptions<FaqsContext> options)
            : base(options)
        {

        }

        DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product { productCode = "M2MD6D", productName = "Software Package Vol. 1", productPrice = 4.99, releaseDate = DateTime.Now}
                );
        }
    }
}
