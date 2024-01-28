using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowsProject.Migrations
{
    public partial class name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 4, 1, 11, 0, 997, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 4, 1, 11, 0, 997, DateTimeKind.Local).AddTicks(7191));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 4, 0, 36, 58, 940, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 4, 0, 36, 58, 940, DateTimeKind.Local).AddTicks(2533));
        }
    }
}
