using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e47b0ed5-1971-4812-9b1f-60bef88f93a8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c2dd84e8-5d8a-48bd-aff2-f357ea27b0da", "aca64f4e-6ba6-45d3-83a0-a3acd5c7a654" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2dd84e8-5d8a-48bd-aff2-f357ea27b0da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca64f4e-6ba6-45d3-83a0-a3acd5c7a654");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "c2dd84e8-5d8a-48bd-aff2-f357ea27b0da", null, "Admin", "ADMIN" },
                    { "e47b0ed5-1971-4812-9b1f-60bef88f93a8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aca64f4e-6ba6-45d3-83a0-a3acd5c7a654", 0, "631c64af-a88d-46f4-a438-2dc3005f5a76", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEAvBdPLsZsFCu0MKtm+lisu2MwRan7WHJtcW3ol0VM8vC4dKh8+O6xIUPJfhoaNoTw==", null, false, "c9f01b29-81d3-4872-9e8c-0a052aa00240", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c2dd84e8-5d8a-48bd-aff2-f357ea27b0da", "aca64f4e-6ba6-45d3-83a0-a3acd5c7a654" });
        }
    }
}
