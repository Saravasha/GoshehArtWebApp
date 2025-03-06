using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db7bda4b-19a5-4cae-81ef-8e866499a258");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57b50225-ee03-4c9d-bc57-93c186566da4", "e3b0d14f-d6c0-4a4b-98b0-3708f0bb8c59" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57b50225-ee03-4c9d-bc57-93c186566da4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3b0d14f-d6c0-4a4b-98b0-3708f0bb8c59");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ac55a95-97c9-43f3-a6ac-6e865eee5fa1", null, "User", "USER" },
                    { "e88b855b-e742-4b05-9cfe-c20d8cf9ea73", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5070f71f-c327-41c5-a696-57f71b4b22b9", 0, "09e809de-094c-4b64-9151-a2b02d1a3334", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJqVILgbIVhtEJSh3juwO2IwgosY/apHS86FguCMcfNoKEVT2zNBpAjXiXQgC396zQ==", null, false, "2e9e3da1-f80b-417b-9d36-002ad5f9d978", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e88b855b-e742-4b05-9cfe-c20d8cf9ea73", "5070f71f-c327-41c5-a696-57f71b4b22b9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ac55a95-97c9-43f3-a6ac-6e865eee5fa1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e88b855b-e742-4b05-9cfe-c20d8cf9ea73", "5070f71f-c327-41c5-a696-57f71b4b22b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e88b855b-e742-4b05-9cfe-c20d8cf9ea73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5070f71f-c327-41c5-a696-57f71b4b22b9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57b50225-ee03-4c9d-bc57-93c186566da4", null, "Admin", "ADMIN" },
                    { "db7bda4b-19a5-4cae-81ef-8e866499a258", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e3b0d14f-d6c0-4a4b-98b0-3708f0bb8c59", 0, "bea6b129-6b6b-45cc-ba66-92dd635d6a55", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENxh1hz/I7h9L8g1CqHT/6x2nTXW/Pib8ppen4hQNEsx3aq238qoGDq86Xdkk8NIXg==", null, false, "fcf38eeb-ba67-4e1e-ac58-4c8919e71682", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57b50225-ee03-4c9d-bc57-93c186566da4", "e3b0d14f-d6c0-4a4b-98b0-3708f0bb8c59" });
        }
    }
}
