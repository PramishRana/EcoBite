using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecobite.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedInventoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2026, 10, 6, 12, 37, 15, 931, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2026, 10, 6, 12, 37, 15, 931, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 6, 12, 37, 15, 931, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryId", "DateAdded", "FoodItemId", "Quantity" },
                values: new object[] { 2, new DateTime(2024, 10, 6, 12, 37, 15, 931, DateTimeKind.Local).AddTicks(3504), 2, 20 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 2);

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
    }
}
