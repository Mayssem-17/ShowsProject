using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShowsProject.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "owner1" });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Date", "Description", "Duration", "Location", "OwnerId", "Price", "Title", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 3, 34, 33, 96, DateTimeKind.Local).AddTicks(4971), "Description1", "2 hours", "aaaaa", 1, 100.0, "show1", "type1" },
                    { 2, new DateTime(2024, 1, 1, 3, 34, 33, 96, DateTimeKind.Local).AddTicks(4986), "Description2", "3 hours", "bbbbbbbb", 1, 3300.0, "show2", "type2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
