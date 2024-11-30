using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecobite.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeeding : Migration
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
                    { 1, "Beans", new DateOnly(2026, 11, 30), "Black Beans", new DateOnly(2024, 10, 30), 10 },
                    { 2, "Grains", new DateOnly(2026, 11, 30), "Rice", new DateOnly(2024, 9, 30), 20 }
                });
        }
    }
}
