using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecobite.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "Category", "ExpirationDate", "FoodItemName", "MFDate", "Quantity" },
                values: new object[,]
                {
                    { 1, "Beans", new DateOnly(2026, 12, 1), "Black Beans", new DateOnly(2024, 11, 1), 10 },
                    { 2, "Grains", new DateOnly(2026, 12, 1), "Rice", new DateOnly(2024, 10, 1), 20 }
                });
        }
    }
}
