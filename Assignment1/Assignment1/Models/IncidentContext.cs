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
        public DbSet<Country> Country { get; set; }

        

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
                    productName = "Draft Manager 1.0",
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
                    productReleaseDate = new DateTime(2018, 2, 15)
                }, new Product
                {
                    productId = 7,
                    productCode = "DRAFT20",
                    productName = "Draft Manager 2.0",
                    productPrice = 5.99,
                    productReleaseDate = new DateTime(2019, 7, 15),
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

            // incidents
            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    incidentId = 1,
                    incidentCustomer = "Kendall Mayte",
                    incidentProduct = "Draft Manager 1.0",
                    incidentTitle = "Could not install",
                    incidentDescription = " ",
                    incidentTechnician="Alison Diaz", // needed for editing incident page
                    incidentDateOpened = new DateTime(2020, 1, 8),
                    incidentDateClosed= new DateTime(),
                    
                    
                },
                new Incident
                {
                    incidentId = 2,
                    incidentTitle = "Could not install",
                    incidentCustomer = "Gonzoalo Keeton",
                    incidentProduct = "Tournament Master 1.0",
                    incidentDateOpened = new DateTime(2020, 1, 8),
                    incidentDateClosed = new DateTime(),
                    incidentDescription = " ",
                    incidentTechnician = "Andrew Wilson",
                },
                new Incident
                {
                    incidentId = 3,
                    incidentTitle = "Error importing data",
                    incidentCustomer = "Ania Irvin",
                    incidentProduct = "League Scheduler Deluxe 1.0",
                    incidentDateOpened = new DateTime(2020, 1, 9),
                    incidentDateClosed = new DateTime(),
                    incidentDescription = " ",
                    incidentTechnician = "Gina Fiori",
                },
                new Incident
                {
                    incidentId = 4,
                    incidentTitle = "Error launching program",
                    incidentCustomer = "Kendall Mayte",
                    incidentProduct = "League Scheduler 1.0",
                    incidentDateOpened = new DateTime(2020, 1, 10),
                    incidentDateClosed = new DateTime(),
                    incidentDescription = " ",
                    incidentTechnician = "Gunter Wendt",
                }
                );
            modelBuilder.Entity<Country>().HasData(
                    new Country
                    {
                        countryId = 1,
                        countryName = "Canada"
                    },
                    new Country
                    {
                        countryId = 2,
                        countryName = "United States of America"
                    },
                    new Country
                    {
                        countryId = 3,
                        countryName = "United Kingdom"
                    },
                    new Country
                    {
                        countryId = 4,
                        countryName = "France"
                    },
                    new Country
                    {
                        countryId = 5,
                        countryName = "Mexico"
                    }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    customerId = 1,
                    customerFirstName = "Kaitlyn",
                    customerLastName = "Anthoni",
                    customerAddress = "100 Apple Street",
                    customerCity = "San Francisco",
                    customerState = "California",
                    customerPostalCode = "90001",
                    customerCountryId = 1,
                    customerEmail = "kanthoni@pge.com",
                    customerPhone = "555-555-1000"

                },
                new Customer
                {
                    customerId = 2,
                    customerFirstName = "Ana",
                    customerLastName = "Irvin",
                    customerAddress = "200 Banana Street",
                    customerCity = "Washington",
                    customerState = "D.C.",
                    customerPostalCode = "90002",
                    customerCountryId = 2,
                    customerEmail = "kanthoni@pge.com",
                    customerPhone = "555-555-1001"
                },
                new Customer
                {
                    customerId = 3,
                    customerFirstName = "Gonzalo",
                    customerLastName = "Keeton",
                    customerAddress = "300 Corn Street",
                    customerCity = "Mission Viejo",
                    customerState = "California",
                    customerPostalCode = "90003",
                    customerCountryId = 2,
                    customerEmail = " ",// wireframe shows it to be blank
                    customerPhone = "555-555-1002"
                },
                new Customer
                {
                    customerId = 4,
                    customerFirstName = "Anton",
                    customerLastName = "Mauro",
                    customerAddress = "400 Dingleberry Street",
                    customerCity = "Sacramento",
                    customerState = "Calfiornia",
                    customerPostalCode = "90004",
                    customerCountryId = 2,
                    customerEmail = "amauro@yahoo.org",
                    customerPhone = "555-555-1003"
                },
                new Customer
                {
                    customerId = 5,
                    customerFirstName = "Kendall",
                    customerLastName = "Mayte",
                    customerAddress = "500 Eggfruit Street",
                    customerCity = "Fresno",
                    customerState = "California",
                    customerPostalCode = "90005",
                    customerCountryId = 2,
                    customerEmail = "kmayte@fresno.ca.gov",
                    customerPhone = "555-555-1004"
                },
                new Customer
                {
                    customerId = 6,
                    customerFirstName = "Kenzie",
                    customerLastName = "Quinn",
                    customerAddress = "600 Finger Lime Street",
                    customerCity = "Los Angeles",
                    customerState = "California",
                    customerPostalCode = "90006",
                    customerCountryId = 2,
                    customerEmail = "kenzie@mma.jobtrack.com",
                    customerPhone = "555-555-1005"
                },
                new Customer
                {
                    customerId = 7,
                    customerFirstName = "Marvin",
                    customerLastName = "Quintin",
                    customerAddress = "700 Grape Street",
                    customerCity = "Fresno",
                    customerState = "California",
                    customerPostalCode = "90007",
                    customerCountryId = 2, 
                    customerEmail = "marvin@expedata.com",
                    customerPhone = "555-555-1006"
                }
                );
        }
    }
}
