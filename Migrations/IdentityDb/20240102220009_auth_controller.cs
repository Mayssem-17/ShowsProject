using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowsProject.Migrations.IdentityDb
{
    public partial class auth_controller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d15b386a-ec2b-4ba9-aa36-cf13d3579077");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7d3a586-38e3-4b7a-945c-398755e461b3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "770205ef-df44-4d59-9d45-1ecb8dff0e85", "1", "Owner", "Owner" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2ddc899-d462-4761-bfad-7dbb3f6f4e9e", "2", "Performer", "Performer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770205ef-df44-4d59-9d45-1ecb8dff0e85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ddc899-d462-4761-bfad-7dbb3f6f4e9e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d15b386a-ec2b-4ba9-aa36-cf13d3579077", "1", "Owner", "Owner" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7d3a586-38e3-4b7a-945c-398755e461b3", "2", "Performer", "Performer" });
        }
    }
}
