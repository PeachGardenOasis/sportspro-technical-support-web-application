using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customerId);
                });

            migrationBuilder.CreateTable(
                name: "Incident",
                columns: table => new
                {
                    incidentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    incidentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    incidentCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    incidentProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateOpened = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incident", x => x.incidentId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productPrice = table.Column<double>(type: "float", nullable: false),
                    releaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productId);
                });

            migrationBuilder.CreateTable(
                name: "Technician",
                columns: table => new
                {
                    technicianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    technicianFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    technicianEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    technicianPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technician", x => x.technicianId);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "customerId", "customerAddress", "customerEmail", "customerFullName", "customerPhone" },
                values: new object[,]
                {
                    { 1, "San Francisco", "Kanthoni@pge.com", "Kaitlyn Anthoni", null },
                    { 2, "Washington", "ania@mma.nidc.com", "Ana Irvin", null },
                    { 3, "Mission Viejo", "  ", "Gonzalo Keeton", null },
                    { 4, "Sacramento", "amauro@yahoo.org", "Anton Mauro", null },
                    { 5, "Fresno", "kmayte@fresco.ca.gov", "Kendall Mayte", null },
                    { 6, "Los Angeles", "kenzie@mma.jobtrak.com", "Kenzie Quinn", null },
                    { 7, "Fresno", "marvin@expedata.com", "Marvin Quintin", null }
                });

            migrationBuilder.InsertData(
                table: "Incident",
                columns: new[] { "incidentId", "dateOpened", "incidentCustomer", "incidentProduct", "incidentTitle" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kendall Mayte", "Draft Manager 1.0", "Could not install" },
                    { 2, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gonzoalo Keeton", "Tournament Master 1.0", "Could not install" },
                    { 3, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ania Irvin", "League Scheduler Deluxe 1.0", "Error importing data" },
                    { 4, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ania Irvin", "League Scheduler 1.0", "Error launching data" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "productId", "productCode", "productName", "productPrice", "releaseDate" },
                values: new object[,]
                {
                    { 7, "DRAFT20", "Draft Manager 2.0", 5.9900000000000002, new DateTime(2015, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "TRNY20", "Tournament Master 2.0", 5.9900000000000002, new DateTime(2015, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "TEAM10", "Team Manager 1.0", 4.9900000000000002, new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "TRNY10", "Tournament Master 1.0", 4.9900000000000002, new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "LEAGD10", "League Scheduler Deluxe 1.0", 7.9900000000000002, new DateTime(2016, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "LEAG10", "League Scheduler 1.0", 4.9900000000000002, new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "DRAFT10", "Draft Maanger 1.0", 4.9900000000000002, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Technician",
                columns: new[] { "technicianId", "technicianEmail", "technicianFullName", "technicianPhone" },
                values: new object[,]
                {
                    { 4, "gunter@sportsprosoftware.com", "Gunter Wendt", "800-555-0400" },
                    { 1, "alison@sportsprosoftware.com", "Alison Diaz", "800-555-0443" },
                    { 2, "awilson@sportsprosoftware.com", "Andrew Wilson", "800-555-0449" },
                    { 3, "gfiori@sportsprosoftware.com", "Gina Fiori", "800-555-0459" },
                    { 5, "jason@sportsprosoftware.com", "Jason Lee", "800-555-0444" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Incident");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Technician");
        }
    }
}
