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
                    customerCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "customerId", "customerCity", "customerEmail", "customerFullName" },
                values: new object[,]
                {
                    { 1, "San Francisco", "Kanthoni@pge.com", "Kaitlyn Anthoni" },
                    { 2, "Washington", "ania@pmma.nidc.com", "Ana Irvin" },
                    { 3, "Mission Viejo", " ", "Gonzalo Keeton" },
                    { 4, "Sacramento", "amauro@yahoo.org", "Anton Mauro" },
                    { 5, "Fresco", "Kmayte@fresco.ca.gov", "Kendall Mayte" },
                    { 6, "Los Angeles", "kenzie@mma.jobtrak.com", "Kenzie Quinn" },
                    { 7, "Fresno", "marvin@expedata.com", "Marvin Quintin" }
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
                values: new object[] { 1, "M2MD6D", "Software Package Vol. 1", 4.9900000000000002, new DateTime(2021, 2, 20, 16, 57, 31, 364, DateTimeKind.Local).AddTicks(5949) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Incident");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
