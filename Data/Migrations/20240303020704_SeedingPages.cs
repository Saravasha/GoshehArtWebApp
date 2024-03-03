using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingPages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0839f58e-b303-44d1-9e00-052ea0189c04");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "100b464e-4f82-464e-b491-40329fb907be", "9fcce70e-954f-4754-946a-ada31b2ee468" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "100b464e-4f82-464e-b491-40329fb907be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fcce70e-954f-4754-946a-ada31b2ee468");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c74b18c-6fb1-4a32-bf56-27e73178a521", null, "Admin", "ADMIN" },
                    { "448b11f4-ca4a-44b8-952b-b20afa0d7772", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8d6d25b7-e311-4450-8202-387cef357e15", 0, "5fd2499d-8cc9-42aa-8058-2704841c12f6", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEB1huIYixh2XG3+B22xANOaqxDyfkOVv6lkz7vXuLzPcnd8k3sT0IuOXcg8TVDOxqQ==", null, false, "392626a4-250d-4ed5-85fb-22edf52cd9b0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Title", "Content" },
                values: new object[,]
                {
                    { "About", "" },
                    { "Contact", "" },
                    { "Home", "" },
                    { "Production", "" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c74b18c-6fb1-4a32-bf56-27e73178a521", "8d6d25b7-e311-4450-8202-387cef357e15" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "448b11f4-ca4a-44b8-952b-b20afa0d7772");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c74b18c-6fb1-4a32-bf56-27e73178a521", "8d6d25b7-e311-4450-8202-387cef357e15" });

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Title",
                keyValue: "About");

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Title",
                keyValue: "Contact");

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Title",
                keyValue: "Home");

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Title",
                keyValue: "Production");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c74b18c-6fb1-4a32-bf56-27e73178a521");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d6d25b7-e311-4450-8202-387cef357e15");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0839f58e-b303-44d1-9e00-052ea0189c04", null, "User", "USER" },
                    { "100b464e-4f82-464e-b491-40329fb907be", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9fcce70e-954f-4754-946a-ada31b2ee468", 0, "cef42de9-4e43-48a7-95b5-2ba375463a38", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEKVzClmuPp9EkaTy7hCpsm6Kz6+Ujm2RWglLy6ZhteMyKoV4qEWh2D4BZWpMdoTNow==", null, false, "ecb7325f-2227-4b2f-8c28-79c15a0e71c0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "100b464e-4f82-464e-b491-40329fb907be", "9fcce70e-954f-4754-946a-ada31b2ee468" });
        }
    }
}
