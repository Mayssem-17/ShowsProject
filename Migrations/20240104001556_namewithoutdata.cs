using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowsProject.Migrations
{
    public partial class namewithoutdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "amr" });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Date", "Description", "Duration", "Location", "OwnerId", "Price", "Title", "Type" },
                values: new object[] { 1, new DateTime(2024, 1, 4, 1, 11, 0, 997, DateTimeKind.Local).AddTicks(7178), "Description1", "2 hours", "aaaaa", 1, 100.0, "show1", "type1" });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Date", "Description", "Duration", "Location", "OwnerId", "Price", "Title", "Type" },
                values: new object[] { 2, new DateTime(2024, 1, 4, 1, 11, 0, 997, DateTimeKind.Local).AddTicks(7191), "Description2", "3 hours", "bbbbbbbb", 1, 3300.0, "show2", "type2" });
        }
    }
}
