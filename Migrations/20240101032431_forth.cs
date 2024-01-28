using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowsProject.Migrations
{
    /// <inheritdoc />
    public partial class forth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateRead",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Applications");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 1, 4, 24, 31, 630, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 1, 4, 24, 31, 630, DateTimeKind.Local).AddTicks(8197));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateRead",
                table: "Applications",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 1, 3, 34, 33, 96, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 1, 3, 34, 33, 96, DateTimeKind.Local).AddTicks(4986));
        }
    }
}
