﻿// <auto-generated />
using System;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment1.Migrations
{
    [DbContext(typeof(IncidentContext))]
    partial class IncidentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment1.Models.Country", b =>
                {
                    b.Property<int>("countryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("countryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("countryId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            countryId = 1,
                            countryName = "Canada"
                        },
                        new
                        {
                            countryId = 2,
                            countryName = "United States of America"
                        },
                        new
                        {
                            countryId = 3,
                            countryName = "United Kingdom"
                        },
                        new
                        {
                            countryId = 4,
                            countryName = "France"
                        },
                        new
                        {
                            countryId = 5,
                            countryName = "Mexico"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("customerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("customerCountryId")
                        .HasColumnType("int");

                    b.Property<string>("customerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customerId");

                    b.HasIndex("customerCountryId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            customerId = 1,
                            customerAddress = "100 Apple Street",
                            customerCity = "San Francisco",
                            customerCountryId = 1,
                            customerEmail = "kanthoni@pge.com",
                            customerFirstName = "Kaitlyn",
                            customerLastName = "Anthoni",
                            customerPhone = "555-555-1000",
                            customerPostalCode = "90001",
                            customerState = "California"
                        },
                        new
                        {
                            customerId = 2,
                            customerAddress = "200 Banana Street",
                            customerCity = "Washington",
                            customerCountryId = 2,
                            customerEmail = "kanthoni@pge.com",
                            customerFirstName = "Ana",
                            customerLastName = "Irvin",
                            customerPhone = "555-555-1001",
                            customerPostalCode = "90002",
                            customerState = "D.C."
                        },
                        new
                        {
                            customerId = 3,
                            customerAddress = "300 Corn Street",
                            customerCity = "Mission Viejo",
                            customerCountryId = 2,
                            customerEmail = " ",
                            customerFirstName = "Gonzalo",
                            customerLastName = "Keeton",
                            customerPhone = "555-555-1002",
                            customerPostalCode = "90003",
                            customerState = "California"
                        },
                        new
                        {
                            customerId = 4,
                            customerAddress = "400 Dingleberry Street",
                            customerCity = "Sacramento",
                            customerCountryId = 2,
                            customerEmail = "amauro@yahoo.org",
                            customerFirstName = "Anton",
                            customerLastName = "Mauro",
                            customerPhone = "555-555-1003",
                            customerPostalCode = "90004",
                            customerState = "Calfiornia"
                        },
                        new
                        {
                            customerId = 5,
                            customerAddress = "500 Eggfruit Street",
                            customerCity = "Fresno",
                            customerCountryId = 2,
                            customerEmail = "kmayte@fresno.ca.gov",
                            customerFirstName = "Kendall",
                            customerLastName = "Mayte",
                            customerPhone = "555-555-1004",
                            customerPostalCode = "90005",
                            customerState = "California"
                        },
                        new
                        {
                            customerId = 6,
                            customerAddress = "600 Finger Lime Street",
                            customerCity = "Los Angeles",
                            customerCountryId = 2,
                            customerEmail = "kenzie@mma.jobtrack.com",
                            customerFirstName = "Kenzie",
                            customerLastName = "Quinn",
                            customerPhone = "555-555-1005",
                            customerPostalCode = "90006",
                            customerState = "California"
                        },
                        new
                        {
                            customerId = 7,
                            customerAddress = "700 Grape Street",
                            customerCity = "Fresno",
                            customerCountryId = 2,
                            customerEmail = "marvin@expedata.com",
                            customerFirstName = "Marvin",
                            customerLastName = "Quintin",
                            customerPhone = "555-555-1006",
                            customerPostalCode = "90007",
                            customerState = "California"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Incident", b =>
                {
                    b.Property<int>("incidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("incidentCustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("incidentDateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("incidentDateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("incidentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("incidentProductId")
                        .HasColumnType("int");

                    b.Property<int?>("incidentTechnicianId")
                        .HasColumnType("int");

                    b.Property<string>("incidentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("incidentId");

                    b.HasIndex("incidentCustomerId");

                    b.HasIndex("incidentProductId");

                    b.HasIndex("incidentTechnicianId");

                    b.ToTable("Incident");

                    b.HasData(
                        new
                        {
                            incidentId = 1,
                            incidentCustomerId = 5,
                            incidentDateClosed = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            incidentDateOpened = new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            incidentDescription = "Program failed to install with error code 502",
                            incidentProductId = 4,
                            incidentTechnicianId = 1,
                            incidentTitle = "Could not install"
                        },
                        new
                        {
                            incidentId = 2,
                            incidentCustomerId = 3,
                            incidentDateClosed = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            incidentDateOpened = new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            incidentDescription = "Program failed to install with error code 502",
                            incidentProductId = 1,
                            incidentTechnicianId = 2,
                            incidentTitle = "Could not install"
                        },
                        new
                        {
                            incidentId = 3,
                            incidentCustomerId = 2,
                            incidentDateClosed = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            incidentDateOpened = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            incidentDescription = "Program fails with error code 511, unable to locate database",
                            incidentProductId = 3,
                            incidentTechnicianId = 3,
                            incidentTitle = "Error importing data"
                        },
                        new
                        {
                            incidentId = 4,
                            incidentCustomerId = 5,
                            incidentDateClosed = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            incidentDateOpened = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            incidentDescription = "Program fails with error code 510, unable to open database",
                            incidentProductId = 2,
                            incidentTechnicianId = 4,
                            incidentTitle = "Error launching program"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("productCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("productPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("productReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("productId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            productId = 1,
                            productCode = "TRNY10",
                            productName = "Tournament Master 1.0",
                            productPrice = 4.9900000000000002,
                            productReleaseDate = new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            productId = 2,
                            productCode = "LEAG10",
                            productName = "League Scheduler 1.0",
                            productPrice = 4.9900000000000002,
                            productReleaseDate = new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            productId = 3,
                            productCode = "LEAGD10",
                            productName = "League Scheduler Deluxe 1.0",
                            productPrice = 7.9900000000000002,
                            productReleaseDate = new DateTime(2016, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            productId = 4,
                            productCode = "DRAFT10",
                            productName = "Draft Manager 1.0",
                            productPrice = 4.9900000000000002,
                            productReleaseDate = new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            productId = 5,
                            productCode = "TEAM10",
                            productName = "Team Manager 1.0",
                            productPrice = 4.9900000000000002,
                            productReleaseDate = new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            productId = 6,
                            productCode = "TRNY20",
                            productName = "Tournament Master 2.0",
                            productPrice = 5.9900000000000002,
                            productReleaseDate = new DateTime(2018, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            productId = 7,
                            productCode = "DRAFT20",
                            productName = "Draft Manager 2.0",
                            productPrice = 5.9900000000000002,
                            productReleaseDate = new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Technician", b =>
                {
                    b.Property<int>("technicianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("technicianEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("technicianFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("technicianPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("technicianId");

                    b.ToTable("Technician");

                    b.HasData(
                        new
                        {
                            technicianId = 1,
                            technicianEmail = "alison@sportsprosoftware.com",
                            technicianFullName = "Alison Diaz",
                            technicianPhone = "800-555-0443"
                        },
                        new
                        {
                            technicianId = 2,
                            technicianEmail = "awilson@sportsprosoftware.com",
                            technicianFullName = "Andrew Wilson",
                            technicianPhone = "800-555-0449"
                        },
                        new
                        {
                            technicianId = 3,
                            technicianEmail = "gfiori@sportsprosoftware.com",
                            technicianFullName = "Gina Fiori",
                            technicianPhone = "800-555-0459"
                        },
                        new
                        {
                            technicianId = 4,
                            technicianEmail = "gunter@sportsprosoftware.com",
                            technicianFullName = "Gunter Wendt",
                            technicianPhone = "800-555-0400"
                        },
                        new
                        {
                            technicianId = 5,
                            technicianEmail = "jason@sportsprosoftware.com",
                            technicianFullName = "Jason Lee",
                            technicianPhone = "800-555-0444"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Customer", b =>
                {
                    b.HasOne("Assignment1.Models.Country", "customerCountry")
                        .WithMany()
                        .HasForeignKey("customerCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customerCountry");
                });

            modelBuilder.Entity("Assignment1.Models.Incident", b =>
                {
                    b.HasOne("Assignment1.Models.Customer", "incidentCustomer")
                        .WithMany()
                        .HasForeignKey("incidentCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment1.Models.Product", "incidentProduct")
                        .WithMany()
                        .HasForeignKey("incidentProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment1.Models.Technician", "incidentTechnician")
                        .WithMany()
                        .HasForeignKey("incidentTechnicianId");

                    b.Navigation("incidentCustomer");

                    b.Navigation("incidentProduct");

                    b.Navigation("incidentTechnician");
                });
#pragma warning restore 612, 618
        }
    }
}
