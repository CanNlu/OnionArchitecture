using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionArchitecture.Persistence.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("1b389068-c308-4285-8868-ac5f879b038b"), "Product 1 Description", "Product 1", 1000, 10 },
                    { new Guid("323daefa-9d94-4326-ab01-2987e1cd2885"), "Product 4 Description", "Product 4", 4000, 40 },
                    { new Guid("95690b3e-09b6-4d2d-b1d4-a70a560622a6"), "Product 2 Description", "Product 2", 2000, 20 },
                    { new Guid("f87da6ed-1714-4703-bf9e-d46c138d4168"), "Product 3 Description", "Product 3", 3000, 30 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
