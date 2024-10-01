using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecobite.Migrations
{
    /// <inheritdoc />
    public partial class SeedInventoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2026, 10, 6, 3, 10, 7, 294, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2026, 10, 6, 3, 10, 7, 294, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 6, 3, 10, 7, 294, DateTimeKind.Local).AddTicks(8067));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 6, 2, 59, 30, 256, DateTimeKind.Local).AddTicks(8465));
        }
    }
}
