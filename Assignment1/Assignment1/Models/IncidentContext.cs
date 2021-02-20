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
        
        DbSet<Customer> Customer { get; set; }

        DbSet<Incident> Incident { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product { productId = 1, productCode = "M2MD6D", productName = "Software Package Vol. 1", productPrice = 4.99, releaseDate = DateTime.Now}
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    customerId = 1,
                    customerFullName = "Kaitlyn Anthoni",
                    customerEmail = "Kanthoni@pge.com",
                    customerCity = "San Francisco",
                },
                new Customer
                {
                    customerId = 2,
                    customerFullName = "Ana Irvin",
                    customerEmail = "ania@pmma.nidc.com",
                    customerCity = "Washington",
                },
                new Customer
                {
                    customerId = 3,
                    customerFullName = "Gonzalo Keeton",
                    customerEmail = " ",
                    customerCity = "Mission Viejo",
                },
                new Customer
                {
                    customerId = 4,
                    customerFullName = "Anton Mauro",
                    customerEmail = "amauro@yahoo.org",
                    customerCity = "Sacramento",
                },
                new Customer
                {
                    customerId = 5,
                    customerFullName = "Kendall Mayte",
                    customerEmail = "Kmayte@fresco.ca.gov",
                    customerCity = "Fresco",
                },
                new Customer
                {
                    customerId = 6,
                    customerFullName = "Kenzie Quinn",
                    customerEmail = "kenzie@mma.jobtrak.com",
                    customerCity = "Los Angeles",
                },
                new Customer
                {
                    customerId = 7,
                    customerFullName = "Marvin Quintin",
                    customerEmail = "marvin@expedata.com",
                    customerCity = "Fresno",
                }
                );
                
                // incidents
                modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    incidentId = 1,
                    incidentTitle = "Could not install",
                    incidentCustomer = "Kendall Mayte",
                    incidentProduct = "Draft Manager 1.0",
                    dateOpened = new DateTime(2020, 1, 8)
                },
                new Incident
                {
                    incidentId = 2,
                    incidentTitle = "Could not install",
                    incidentCustomer = "Gonzoalo Keeton",
                    incidentProduct = "Tournament Master 1.0",
                    dateOpened = new DateTime(2020, 1, 8)
                },
                new Incident
                {
                    incidentId = 3,
                    incidentTitle = "Error importing data",
                    incidentCustomer = "Ania Irvin",
                    incidentProduct = "League Scheduler Deluxe 1.0",
                    dateOpened = new DateTime(2020, 1, 9)
                },
                new Incident
                {
                    incidentId = 4,
                    incidentTitle = "Error launching data",
                    incidentCustomer = "Ania Irvin",
                    incidentProduct = "League Scheduler 1.0",
                    dateOpened = new DateTime(2020, 1, 10)
                }
                );
        }
    }
}
