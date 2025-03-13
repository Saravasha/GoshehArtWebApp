using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class tryingSeedContentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "96fe0ea1-8cdc-4e11-b724-1261c0a29859", null, "User", "USER" },
                    { "a2c939a3-f34e-4441-ac2c-2437b54db562", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "905fa595-261e-4d01-87f6-ae3f42b36c3e", 0, "75da5cb1-5c65-4014-a418-99b95f36b2de", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEH8iaLyEU0r4BykzAFQe6EZHj3ZQSjqsyDON+5zM9+Tz+PZVYTuei/weKfy/bSy7jQ==", null, false, "20f28512-7255-4395-9bd3-4bc8d94c47f9", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a2c939a3-f34e-4441-ac2c-2437b54db562", "905fa595-261e-4d01-87f6-ae3f42b36c3e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96fe0ea1-8cdc-4e11-b724-1261c0a29859");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2c939a3-f34e-4441-ac2c-2437b54db562", "905fa595-261e-4d01-87f6-ae3f42b36c3e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2c939a3-f34e-4441-ac2c-2437b54db562");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "905fa595-261e-4d01-87f6-ae3f42b36c3e");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "939fcd73-b193-4b71-8343-75bf8e449176", "55ac5f7d-94d3-459c-b89e-692a4d0ef821" });
        }
    }
}
