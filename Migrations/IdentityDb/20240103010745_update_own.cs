using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowsProject.Migrations.IdentityDb
{
    public partial class update_own : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0234d691-7cb6-4c0f-b925-a31b75630661");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6624b44f-ffc3-4ffb-a9d5-b0c0f7e472b4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67bc1d54-ce08-4124-8635-b63227b228ca", "1", "Owner", "Owner" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a05f6db5-9089-4c1d-9a73-55d0419c4e89", "2", "Performer", "Performer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67bc1d54-ce08-4124-8635-b63227b228ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a05f6db5-9089-4c1d-9a73-55d0419c4e89");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0234d691-7cb6-4c0f-b925-a31b75630661", "1", "Owner", "Owner" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6624b44f-ffc3-4ffb-a9d5-b0c0f7e472b4", "2", "Performer", "Performer" });
        }
    }
}
