using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialtion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
 
        
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11111111-1111-1111-1111-111111111111", "14280c58-765f-48a7-9757-5128d59324ad", "SuperAdmin", "SUPERADMIN" },
                    { "22222222-2222-2222-2222-222222222222", "e5227a28-8ccd-43e0-8a5e-523e6a0acda1", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "Description", "Status" },
                values: new object[,]
                {
                    { 1, "Apple", "Smart", true },
                    { 2, "Samsung", "Smart", true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Description", "Status" },
                values: new object[,]
                {
                    { 1, "Smartphones", "Mobile phones", true },
                    { 2, "Laptops", "Portable computers", true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "Discount", "MainImg", "Price", "ProductName", "Quantity", "Rate", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, null, 0m, "iphone15.png", 30000m, "iPhone 15", 5, 4.7999999999999998, true },
                    { 2, 2, 1, null, 0m, "galaxys23.png", 25000m, "Galaxy S23", 7, 4.5, true }
                });

        
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
