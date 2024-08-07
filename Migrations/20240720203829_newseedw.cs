using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newseedw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AssetCategory",
                keyColumns: new[] { "AssetsId", "CategoriesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AssetCategory",
                keyColumns: new[] { "AssetsId", "CategoriesId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AssetCategory",
                keyColumns: new[] { "AssetsId", "CategoriesId" },
                keyValues: new object[] { 3, 1 });

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
                    { "2294be34-388b-490f-bd33-bfbbc4046026", null, "User", "USER" },
                    { "4f153863-b10d-43e4-a62b-4f74d8a0ae5f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "54f98b75-f8a3-4176-805d-3712cb1f136b", 0, "d3724416-c022-4b36-9f19-9c44a7671d8e", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEAMWZp4zCYUdKoDH4uhdHXz8J88A4+M/pySHgbx/0JqivRYZ/hozGM2+U3k1KiZLGw==", null, false, "0d0c789b-4f36-45f7-9533-bfae55587ca6", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AssetCategory",
                columns: new[] { "AssetsId", "CategoriesId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 2, 9 },
                    { 3, 9 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4f153863-b10d-43e4-a62b-4f74d8a0ae5f", "54f98b75-f8a3-4176-805d-3712cb1f136b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2294be34-388b-490f-bd33-bfbbc4046026");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f153863-b10d-43e4-a62b-4f74d8a0ae5f", "54f98b75-f8a3-4176-805d-3712cb1f136b" });

            migrationBuilder.DeleteData(
                table: "AssetCategory",
                keyColumns: new[] { "AssetsId", "CategoriesId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AssetCategory",
                keyColumns: new[] { "AssetsId", "CategoriesId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "AssetCategory",
                keyColumns: new[] { "AssetsId", "CategoriesId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f153863-b10d-43e4-a62b-4f74d8a0ae5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54f98b75-f8a3-4176-805d-3712cb1f136b");

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

            migrationBuilder.InsertData(
                table: "AssetCategory",
                columns: new[] { "AssetsId", "CategoriesId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7ccc16d8-be78-4031-94e3-0f68f31aa79a", "785baa01-515a-4e0a-9207-a07772d247af" });
        }
    }
}
