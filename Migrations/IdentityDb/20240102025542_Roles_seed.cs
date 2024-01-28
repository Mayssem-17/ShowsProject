using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowsProject.Migrations.IdentityDb
{
    public partial class Roles_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d15b386a-ec2b-4ba9-aa36-cf13d3579077", "1", "Owner", "Owner" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7d3a586-38e3-4b7a-945c-398755e461b3", "2", "Performer", "Performer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d15b386a-ec2b-4ba9-aa36-cf13d3579077");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7d3a586-38e3-4b7a-945c-398755e461b3");
        }
    }
}
