using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecobite.Migrations
{
    /// <inheritdoc />
    public partial class AddMFDateAndRemoveInventorySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 2);

            migrationBuilder.AddColumn<DateTime>(
                name: "MFDate",
                table: "FoodItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "MFDate" },
                values: new object[] { new DateTime(2026, 11, 30, 1, 44, 58, 420, DateTimeKind.Local).AddTicks(5651), new DateTime(2024, 10, 30, 1, 44, 58, 420, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "MFDate" },
                values: new object[] { new DateTime(2026, 11, 30, 1, 44, 58, 420, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 9, 30, 1, 44, 58, 420, DateTimeKind.Local).AddTicks(5654) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MFDate",
                table: "FoodItems");

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

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryId", "DateAdded", "FoodItemId", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 6, 12, 37, 15, 931, DateTimeKind.Local).AddTicks(3502), 1, 10 },
                    { 2, new DateTime(2024, 10, 6, 12, 37, 15, 931, DateTimeKind.Local).AddTicks(3504), 2, 20 }
                });
        }
    }
}
