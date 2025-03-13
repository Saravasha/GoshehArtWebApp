using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newPageContentSystemaddedw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a70932c-510b-4c5f-8a17-88e3380473ae");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "459b6cc8-e1d5-4123-a63c-1322576cd87b", "f33d9252-cc61-4390-84d8-92cc6b873f50" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "459b6cc8-e1d5-4123-a63c-1322576cd87b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f33d9252-cc61-4390-84d8-92cc6b873f50");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b42f753-4ab0-4353-8c61-9ebbc1f2d975", null, "User", "USER" },
                    { "939fcd73-b193-4b71-8343-75bf8e449176", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "55ac5f7d-94d3-459c-b89e-692a4d0ef821", 0, "4e67753a-340b-414f-92b8-30885469622a", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENhiuzj5z1Kq5SGPq8M4sLIV7w6h4/UYiUVCtvCikq+r2N96WXR1J6hZm92XVfk/Gw==", null, false, "cc4f971e-4117-4f53-8eb6-badf6f913942", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Header", "Title" },
                values: new object[] { 5, "", "Privacy" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "939fcd73-b193-4b71-8343-75bf8e449176", "55ac5f7d-94d3-459c-b89e-692a4d0ef821" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b42f753-4ab0-4353-8c61-9ebbc1f2d975");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "939fcd73-b193-4b71-8343-75bf8e449176", "55ac5f7d-94d3-459c-b89e-692a4d0ef821" });

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "939fcd73-b193-4b71-8343-75bf8e449176");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55ac5f7d-94d3-459c-b89e-692a4d0ef821");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "459b6cc8-e1d5-4123-a63c-1322576cd87b", null, "Admin", "ADMIN" },
                    { "4a70932c-510b-4c5f-8a17-88e3380473ae", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f33d9252-cc61-4390-84d8-92cc6b873f50", 0, "a3c44743-a125-4830-b1d8-08d150ee5520", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEMzTqTWGRw+L19zrQYvp42gFWBbeXVjbMGyJ2v+cXFlvl3PD3DYDHvGfzfxiUs6BoA==", null, false, "79216c9e-1557-4c11-815d-f02eae8f4c9b", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "459b6cc8-e1d5-4123-a63c-1322576cd87b", "f33d9252-cc61-4390-84d8-92cc6b873f50" });
        }
    }
}
