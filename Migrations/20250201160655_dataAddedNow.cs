using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EzeCarVentures.Migrations
{
    public partial class dataAddedNow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Accessed",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "Accessed",
                value: new DateTime(2025, 2, 1, 17, 6, 54, 897, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "Accessed",
                value: new DateTime(2025, 2, 1, 17, 6, 54, 897, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "Accessed",
                value: new DateTime(2025, 2, 1, 17, 6, 54, 897, DateTimeKind.Local).AddTicks(8550));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accessed",
                table: "Brands");
        }
    }
}
