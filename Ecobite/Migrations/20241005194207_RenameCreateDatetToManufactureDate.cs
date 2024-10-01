using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecobite.Migrations
{
    /// <inheritdoc />
    public partial class RenameCreateDatetToManufactureDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_FoodItems_FoodItemId",
                table: "Inventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "Inventories");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "FoodItems",
                newName: "ManufactureDate");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_FoodItemId",
                table: "Inventories",
                newName: "IX_Inventories_FoodItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "InventoryId");

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "Category", "ExpirationDate", "FoodItemName", "ManufactureDate", "Quantity" },
                values: new object[] { 1, "Beans", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Beans", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_FoodItems_FoodItemId",
                table: "Inventories",
                column: "FoodItemId",
                principalTable: "FoodItems",
                principalColumn: "FoodItemId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_FoodItems_FoodItemId",
                table: "Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Inventories",
                newName: "Inventory");

            migrationBuilder.RenameColumn(
                name: "ManufactureDate",
                table: "FoodItems",
                newName: "CreatedDate");

            migrationBuilder.RenameIndex(
                name: "IX_Inventories_FoodItemId",
                table: "Inventory",
                newName: "IX_Inventory_FoodItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_FoodItems_FoodItemId",
                table: "Inventory",
                column: "FoodItemId",
                principalTable: "FoodItems",
                principalColumn: "FoodItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
