using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecobite.Migrations
{
    /// <inheritdoc />
    public partial class AddInventoryAndFoodItemRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2026, 10, 6, 2, 59, 30, 256, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2026, 10, 6, 2, 59, 30, 256, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryId", "DateAdded", "FoodItemId", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 10, 6, 2, 59, 30, 256, DateTimeKind.Local).AddTicks(8465), 1, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2026, 10, 6, 2, 5, 55, 780, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2026, 10, 6, 2, 5, 55, 780, DateTimeKind.Local).AddTicks(3013));
        }
    }
}
