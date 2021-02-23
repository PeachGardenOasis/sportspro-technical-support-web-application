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

        public DbSet<Product> Product { get; set; }
        public DbSet<Technician> Technician { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Incident> Incident { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product
                    {
                    productId = 1,
                    productCode = "TRNY10",
                    productName = "Tournament Master 1.0",
                    productPrice = 4.99,
                    productReleaseDate = new DateTime(2015, 12, 1) //YYYY/M/d
                    },
                new Product
                {
                    productId = 2,
                    productCode = "LEAG10",
                    productName = "League Scheduler 1.0",
                    productPrice = 4.99,
                    productReleaseDate = new DateTime(2016, 5, 1)
                }, new Product
                {
                    productId = 3,
                    productCode = "LEAGD10",
                    productName = "League Scheduler Deluxe 1.0",
                    productPrice = 7.99,
                    productReleaseDate = new DateTime(2016, 8, 1)
                }, new Product
                {
                    productId = 4,
                    productCode = "DRAFT10",
                    productName = "Draft Maanger 1.0",
                    productPrice = 4.99,
                    productReleaseDate = new DateTime(2017, 2, 1)
                }, new Product
                {
                    productId = 5,
                    productCode = "TEAM10",
                    productName = "Team Manager 1.0",
                    productPrice = 4.99,
                    productReleaseDate = new DateTime(2017, 5, 1)
                }, new Product
                {
                    productId = 6,
                    productCode = "TRNY20",
                    productName = "Tournament Master 2.0",
                    productPrice = 5.99,
                    productReleaseDate = new DateTime(2015, 2, 15)
                }, new Product
                {
                    productId = 7,
                    productCode = "DRAFT20",
                    productName = "Draft Manager 2.0",
                    productPrice = 5.99,
                    productReleaseDate = new DateTime(2015, 7, 15),
                }
                );
            modelBuilder.Entity<Technician>().HasData(
                new Technician
                {
                    technicianId = 1,
                    technicianFullName = "Alison Diaz",
                    technicianEmail = "alison@sportsprosoftware.com",
                    technicianPhone = "800-555-0443",
                },

                new Technician
                {
                    technicianId = 2,
                    technicianFullName = "Andrew Wilson",
                    technicianEmail = "awilson@sportsprosoftware.com",
                    technicianPhone = "800-555-0449",
                },
                new Technician
                {
                    technicianId = 3,
                    technicianFullName = "Gina Fiori",
                    technicianEmail = "gfiori@sportsprosoftware.com",
                    technicianPhone = "800-555-0459",
                },
                new Technician
                {
                    technicianId = 4,
                    technicianFullName = "Gunter Wendt",
                    technicianEmail = "gunter@sportsprosoftware.com",
                    technicianPhone = "800-555-0400",
                },
                new Technician
                {
                    technicianId = 5,
                    technicianFullName = "Jason Lee",
                    technicianEmail = "jason@sportsprosoftware.com",
                    technicianPhone = "800-555-0444",
                }
                );
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    customerId = 1,
                    customerFirstName = "Kaitlyn",
                    customerLastName = "Anthoni",

                    customerEmail = "Kanthoni@pge.com",
                    customerCity = "San Francisco",
                    customerState = " ",
                    customerPostalCode = " ",
                    customerPhone=" ",
                    customerCountry=" "
                },
                new Customer
                {
                    customerId = 2,
                    customerFirstName = "Ana",
                    customerLastName = "Irvin",
                    customerEmail = "ania@mma.nidc.com",
                    customerCity = "Washington",
                    customerState = " ",
                    customerPostalCode = " ",
                    customerPhone = " ",
                    customerCountry = " "
                },
                new Customer
                {
                    customerId = 3,
                    customerFirstName = "Gonzalo",
                    customerLastName = "Keeton",
                    customerEmail = "  ",
                    customerCity = "Mission Viejo",
                    customerState = " ",
                    customerPostalCode = " ",
                    customerPhone = " ",
                    customerCountry = " "
                },
                new Customer
                {
                    customerId = 4,
                    customerFirstName = "Anton",
                    customerLastName = "Mauro",
                    customerEmail = "amauro@yahoo.org",
                    customerCity = "Sacramento",
                    customerState = " ",
                    customerPostalCode = " ",
                    customerPhone = " ",
                    customerCountry = " "
                },
                new Customer
                {
                    customerId = 5,
                    customerFirstName = "Kendall",
                    customerLastName = "Mayte",
                    customerEmail = "kmayte@fresco.ca.gov",
                    customerCity = "Fresno",
                    customerState = " ",
                    customerPostalCode = " ",
                    customerPhone = " ",
                    customerCountry = " "
                },
                new Customer
                {
                    customerId = 6,
                    customerFirstName = "Kenzie",
                    customerLastName = "Quinn",
                    customerEmail = "kenzie@mma.jobtrak.com",
                    customerCity = "Los Angeles",
                    customerState = " ",
                    customerPostalCode = " ",
                    customerPhone = " ",
                    customerCountry = " "
                },
                new Customer
                {
                    customerId = 7,
                    customerFirstName = "Marvin",
                    customerLastName = "Quintin",
                    customerEmail = "marvin@expedata.com",
                    customerCity = "Fresno",
                    customerState = " ",
                    customerPostalCode = " ",
                    customerPhone = " ",
                    customerCountry = " "
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
                    incidentDateOpened = new DateTime(2020, 1, 8),
                    incidentDateClosed= new DateTime(),
                    incidentDescription =" "
                    
                },
                new Incident
                {
                    incidentId = 2,
                    incidentTitle = "Could not install",
                    incidentCustomer = "Gonzoalo Keeton",
                    incidentProduct = "Tournament Master 1.0",
                    incidentDateOpened = new DateTime(2020, 1, 8),
                    incidentDateClosed = new DateTime(),
                    incidentDescription = " "
                },
                new Incident
                {
                    incidentId = 3,
                    incidentTitle = "Error importing data",
                    incidentCustomer = "Ania Irvin",
                    incidentProduct = "League Scheduler Deluxe 1.0",
                    incidentDateOpened = new DateTime(2020, 1, 9),
                    incidentDateClosed = new DateTime(),
                    incidentDescription = " "
                },
                new Incident
                {
                    incidentId = 4,
                    incidentTitle = "Error launching data",
                    incidentCustomer = "Ania Irvin",
                    incidentProduct = "League Scheduler 1.0",
                    incidentDateOpened = new DateTime(2020, 1, 10),
                    incidentDateClosed = new DateTime(),
                    incidentDescription = " "
                }
                );
        }
    }
}
