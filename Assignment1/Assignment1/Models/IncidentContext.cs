using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class IncidentContext : DbContext
    {
        public IncidentContext(DbContextOptions<IncidentContext> options)
            : base(options)
        {

        }

        DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product { productId = 1, productCode = "M2MD6D", productName = "Software Package Vol. 1", productPrice = 4.99, releaseDate = DateTime.Now}
                );
        }
    }
}
