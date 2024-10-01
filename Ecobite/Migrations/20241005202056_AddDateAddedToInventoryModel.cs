using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecobite.Migrations
{
    /// <inheritdoc />
    public partial class AddDateAddedToInventoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Inventories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2026, 10, 6, 2, 5, 55, 780, DateTimeKind.Local).AddTicks(2992), 10 });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "Category", "ExpirationDate", "FoodItemName", "Quantity" },
                values: new object[] { 2, "Grains", new DateTime(2026, 10, 6, 2, 5, 55, 780, DateTimeKind.Local).AddTicks(3013), "Rice", 20 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Inventories");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });
        }
    }
}
