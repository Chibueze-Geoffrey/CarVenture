using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EzeCarVentures.Migrations
{
    public partial class InitialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brand_BrandId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "Brands");

            migrationBuilder.AddColumn<DateTime>(
                name: "Accessed",
                table: "Cars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "BrandId");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 332, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12,
                column: "Accessed",
                value: new DateTime(2025, 1, 31, 0, 20, 43, 333, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Accessed",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "Brand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brand_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
