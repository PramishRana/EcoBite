using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecobite.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFoodItemsDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateAdded",
                table: "Inventories",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "MFDate",
                table: "FoodItems",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ExpirationDate",
                table: "FoodItems",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "MFDate" },
                values: new object[] { new DateOnly(2026, 11, 30), new DateOnly(2024, 10, 30) });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "MFDate" },
                values: new object[] { new DateOnly(2026, 11, 30), new DateOnly(2024, 9, 30) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Inventories",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MFDate",
                table: "FoodItems",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "FoodItems",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

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
    }
}
