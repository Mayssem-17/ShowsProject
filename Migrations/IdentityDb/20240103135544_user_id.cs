using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowsProject.Migrations.IdentityDb
{
    public partial class user_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "899524fa-0ecc-4a21-8ee9-6b9d845f4791");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb28f54c-bdca-47d8-8286-3286bfd94771");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ae93f7d-f5c4-49ff-a950-5be01367ba5d", "1", "Owner", "Owner" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9c10910-5d92-4dee-b145-067ab8ae3e33", "2", "Performer", "Performer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ae93f7d-f5c4-49ff-a950-5be01367ba5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9c10910-5d92-4dee-b145-067ab8ae3e33");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "899524fa-0ecc-4a21-8ee9-6b9d845f4791", "2", "Performer", "Performer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb28f54c-bdca-47d8-8286-3286bfd94771", "1", "Owner", "Owner" });
        }
    }
}
