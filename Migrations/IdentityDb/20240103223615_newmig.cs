using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowsProject.Migrations.IdentityDb
{
    public partial class newmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "03068fc5-91a2-4e75-9851-acf39516b0a4", "1", "Owner", "Owner" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ad6fbf6-121c-41da-8b5b-c24ebd26f92d", "2", "Performer", "Performer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03068fc5-91a2-4e75-9851-acf39516b0a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ad6fbf6-121c-41da-8b5b-c24ebd26f92d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ae93f7d-f5c4-49ff-a950-5be01367ba5d", "1", "Owner", "Owner" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9c10910-5d92-4dee-b145-067ab8ae3e33", "2", "Performer", "Performer" });
        }
    }
}
