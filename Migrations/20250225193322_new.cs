using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e94c28ed-751e-4b3e-8402-cc47eb7a8294");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38bbc3d2-49bc-4658-8308-72860d0262e4", "a35affae-5545-4281-a7d3-479965400c29" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38bbc3d2-49bc-4658-8308-72860d0262e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35affae-5545-4281-a7d3-479965400c29");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b7ec58a-c825-46d3-9626-e2cd0f15b341", null, "Admin", "ADMIN" },
                    { "be5207a0-d622-4b53-bb54-61a7ae4b8d4a", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "63ec3c82-2f7a-4a24-ab6a-51e973d2af03", 0, "a5204ade-db32-4708-bab6-45a613ad1e9a", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEER/meij2e0mwftmjzBaGAgoNC/+3xkXGdf88ZwNWbtMT/DfdML/qJjNIHnnnod+/w==", null, false, "a21601c2-67cf-45cf-a1fb-16733e7d1cd0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2b7ec58a-c825-46d3-9626-e2cd0f15b341", "63ec3c82-2f7a-4a24-ab6a-51e973d2af03" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be5207a0-d622-4b53-bb54-61a7ae4b8d4a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b7ec58a-c825-46d3-9626-e2cd0f15b341", "63ec3c82-2f7a-4a24-ab6a-51e973d2af03" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b7ec58a-c825-46d3-9626-e2cd0f15b341");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63ec3c82-2f7a-4a24-ab6a-51e973d2af03");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38bbc3d2-49bc-4658-8308-72860d0262e4", null, "Admin", "ADMIN" },
                    { "e94c28ed-751e-4b3e-8402-cc47eb7a8294", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a35affae-5545-4281-a7d3-479965400c29", 0, "41a55b56-082c-4efd-a656-a2d1510dac75", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGec8MPXSuDPxizay7kcXuPSZB/dor/RJ87LOWwLfHEIhDhAVsaso+wU1pJZIY9zWg==", null, false, "ad744073-52a7-4902-b8e0-3cfbe7af6d89", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38bbc3d2-49bc-4658-8308-72860d0262e4", "a35affae-5545-4281-a7d3-479965400c29" });
        }
    }
}
