using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "120f7d19-1012-40d5-b28d-e81de18077d8", null, "User", "USER" },
                    { "9ee91e16-3be2-475a-a524-1324b39d18b7", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "536d5330-5bda-4cb3-8a29-68709b96ca7b", 0, "8e503a06-3838-42da-9a42-530e16a90f7e", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECpbuUlTDAfgqqQjSJjzgVlsE/ek9nfNUXzAPPTb4V2lD2E8O1lhKLFIsoZFQdxvkw==", null, false, "29ffe87c-947a-411e-9c1a-5bc1684f35bf", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Stuff i made up");

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Body", "PageId", "Title" },
                values: new object[,]
                {
                    { 2, "blog body", 5, "stuff i made up 2" },
                    { 3, "blog body", 2, "atrocities" },
                    { 4, "blog body", 3, "blog title" },
                    { 5, "blog body", 4, "blog title" },
                    { 6, "blog body", 1, "blog title" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9ee91e16-3be2-475a-a524-1324b39d18b7", "536d5330-5bda-4cb3-8a29-68709b96ca7b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "120f7d19-1012-40d5-b28d-e81de18077d8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ee91e16-3be2-475a-a524-1324b39d18b7", "536d5330-5bda-4cb3-8a29-68709b96ca7b" });

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ee91e16-3be2-475a-a524-1324b39d18b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "536d5330-5bda-4cb3-8a29-68709b96ca7b");

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

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "blog title");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a2c939a3-f34e-4441-ac2c-2437b54db562", "905fa595-261e-4d01-87f6-ae3f42b36c3e" });
        }
    }
}
