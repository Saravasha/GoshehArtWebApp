using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "642f0823-61ff-4342-949a-a69d2a319f51");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ee290fb-105e-46cf-b177-41e9e82693f4", "e5d5656e-b35d-4cc1-a22c-736a6aad41d8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ee290fb-105e-46cf-b177-41e9e82693f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5d5656e-b35d-4cc1-a22c-736a6aad41d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00c71183-4886-4600-9617-acd9a49f9239", null, "Admin", "ADMIN" },
                    { "92bc38b2-4fef-421c-a81f-a02f1168ba9d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "52838962-89d2-43e4-b0ed-654c9b1a65f1", 0, "7d1f7ee5-7df9-4eec-8418-1a4705ad50fb", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHLStDC4axjS6q+dfvdZqZt0Vgf0aG+awnqxEHtcIrE7QzAD+6BeF+J/wDXMLJ1Qdw==", null, false, "04dd9da0-bae3-4443-a24c-5a6637b271de", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "00c71183-4886-4600-9617-acd9a49f9239", "52838962-89d2-43e4-b0ed-654c9b1a65f1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92bc38b2-4fef-421c-a81f-a02f1168ba9d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00c71183-4886-4600-9617-acd9a49f9239", "52838962-89d2-43e4-b0ed-654c9b1a65f1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00c71183-4886-4600-9617-acd9a49f9239");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52838962-89d2-43e4-b0ed-654c9b1a65f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "642f0823-61ff-4342-949a-a69d2a319f51", null, "User", "USER" },
                    { "7ee290fb-105e-46cf-b177-41e9e82693f4", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e5d5656e-b35d-4cc1-a22c-736a6aad41d8", 0, "f5ca36d4-f723-4747-b928-1fb17fc0c43a", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJaQ8V6zKhDmEDa0DYKotSbniHmBlNZikxtmPrrEIwr0xWGiH6oVpEElXmEPy8G3IA==", null, false, "47625cd0-e333-4b04-ba17-cf15cf1b8971", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7ee290fb-105e-46cf-b177-41e9e82693f4", "e5d5656e-b35d-4cc1-a22c-736a6aad41d8" });
        }
    }
}
