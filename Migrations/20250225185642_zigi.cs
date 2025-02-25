using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0a4dda3-c2fe-4da0-84fd-4db7b23bda03");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72c380f8-ad50-40e9-9748-5f0009b4f3e2", "47d6bda4-1d8a-4ee0-a81f-132a5a5d6f2b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72c380f8-ad50-40e9-9748-5f0009b4f3e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47d6bda4-1d8a-4ee0-a81f-132a5a5d6f2b");

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

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/Assets/Filmproduktion/image (287).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/Assets/Kontroversiell Konst/image (3).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Assets/Filmproduktion/image (304).jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38bbc3d2-49bc-4658-8308-72860d0262e4", "a35affae-5545-4281-a7d3-479965400c29" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "72c380f8-ad50-40e9-9748-5f0009b4f3e2", null, "Admin", "ADMIN" },
                    { "d0a4dda3-c2fe-4da0-84fd-4db7b23bda03", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "47d6bda4-1d8a-4ee0-a81f-132a5a5d6f2b", 0, "3738c9b4-2305-4b4f-8df1-caaedcc49267", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEArqiyJFwKYioPKXOWxgdGp2EAqgaC6gCKoEvYgFDt6FN5H1uAXFmg50Pi5YvQ8mCg==", null, false, "f753ed49-77e6-45c7-8f4e-12adb3c29b13", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/imagesAsset/Pictures/Sidans Filer/Filmproduktion/image (287).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/imagesAsset/Pictures/Sidans Filer/Kontroversiell Konst/image (3).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/imagesAsset/Pictures/Sidans Filer/Filmproduktion/image (304).jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "72c380f8-ad50-40e9-9748-5f0009b4f3e2", "47d6bda4-1d8a-4ee0-a81f-132a5a5d6f2b" });
        }
    }
}
