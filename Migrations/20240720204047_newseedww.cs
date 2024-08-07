using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newseedww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5793509b-3797-4cc6-812a-8ab8b53a71a7", null, "Admin", "ADMIN" },
                    { "fcffe7fb-88f5-4533-90f2-65ad2fc521b5", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ea80894f-632f-48c4-b575-dba8bd892b6f", 0, "fadd5734-a089-42d3-8687-7132ea60639f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEB9nMwlibmL7XY8A5qReq63yU+uNX6NOyjho94VXUXTPBaLKO6VGxPKczQcO0HrHMg==", null, false, "44dcfc59-0e20-49d6-b6f1-b2f26549efbd", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AssetCategory",
                columns: new[] { "AssetsId", "CategoriesId" },
                values: new object[,]
                {
                    { 1, 9 },
                    { 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5793509b-3797-4cc6-812a-8ab8b53a71a7", "ea80894f-632f-48c4-b575-dba8bd892b6f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcffe7fb-88f5-4533-90f2-65ad2fc521b5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5793509b-3797-4cc6-812a-8ab8b53a71a7", "ea80894f-632f-48c4-b575-dba8bd892b6f" });

            migrationBuilder.DeleteData(
                table: "AssetCategory",
                keyColumns: new[] { "AssetsId", "CategoriesId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "AssetCategory",
                keyColumns: new[] { "AssetsId", "CategoriesId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5793509b-3797-4cc6-812a-8ab8b53a71a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea80894f-632f-48c4-b575-dba8bd892b6f");

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
                    { 2, 9 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4f153863-b10d-43e4-a62b-4f74d8a0ae5f", "54f98b75-f8a3-4176-805d-3712cb1f136b" });
        }
    }
}
