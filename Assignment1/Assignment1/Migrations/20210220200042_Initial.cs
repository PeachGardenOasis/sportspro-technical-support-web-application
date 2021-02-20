using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Product",
                columns: new[] { "productId", "productCode", "productName", "productPrice", "releaseDate" },
                values: new object[] { 1, "M2MD6D", "Software Package Vol. 1", 4.9900000000000002, new DateTime(2021, 2, 20, 15, 0, 42, 41, DateTimeKind.Local).AddTicks(5350) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
