using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14857add-5cef-45ea-b4f7-10b74e134eeb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77d08c37-2005-4711-b66f-9e573477c532", "13d8efcc-54d8-456b-8e25-eafa3f1654d9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77d08c37-2005-4711-b66f-9e573477c532");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13d8efcc-54d8-456b-8e25-eafa3f1654d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ccc16d8-be78-4031-94e3-0f68f31aa79a", null, "Admin", "ADMIN" },
                    { "b2d4565d-4c55-4fef-aecc-c54f47f54762", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "785baa01-515a-4e0a-9207-a07772d247af", 0, "5d3b9b4e-90b5-4526-8113-8398607e8971", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEs1oQozPPISZWD+kb21s2dydY+3hFCVFROoEwmygYXRLkM5k8l9UeAGxJq2r0kCDg==", null, false, "f5fd49c0-3e86-4b1c-b680-6ef3e2cf8be7", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 9, "/imagesAsset/Pictures/Sidans Filer/Filmproduktion/image (287).jpg" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 6, "/imagesAsset/Pictures/Sidans Filer/Kontroversiell Konst/image (3).jpg" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 9, "/imagesAsset/Pictures/Sidans Filer/Filmproduktion/image (304).jpg" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7ccc16d8-be78-4031-94e3-0f68f31aa79a", "785baa01-515a-4e0a-9207-a07772d247af" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2d4565d-4c55-4fef-aecc-c54f47f54762");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ccc16d8-be78-4031-94e3-0f68f31aa79a", "785baa01-515a-4e0a-9207-a07772d247af" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ccc16d8-be78-4031-94e3-0f68f31aa79a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "785baa01-515a-4e0a-9207-a07772d247af");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14857add-5cef-45ea-b4f7-10b74e134eeb", null, "User", "USER" },
                    { "77d08c37-2005-4711-b66f-9e573477c532", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "13d8efcc-54d8-456b-8e25-eafa3f1654d9", 0, "356ac614-7c06-4e85-af24-c423b7b121fa", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJq6AZjX0zDIrY+F51fy5dYu2AWNHgirja3qr+ipQoCUaT3P+4WO6Vz/3Ds/xJ/AvQ==", null, false, "0ad92ddd-b56d-4e6f-953e-d042ed444015", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 1, "" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 2, "placeholder" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 3, "placeholder" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "77d08c37-2005-4711-b66f-9e573477c532", "13d8efcc-54d8-456b-8e25-eafa3f1654d9" });
        }
    }
}
