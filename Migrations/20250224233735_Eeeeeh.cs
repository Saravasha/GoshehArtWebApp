using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Eeeeeh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca70e8b6-55f4-4f29-a0d0-c1332b26a256");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0395f328-7436-4f72-b1d0-ce076a78eaeb", "59b0c4b8-5fb8-4d97-9308-4c133dc544db" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0395f328-7436-4f72-b1d0-ce076a78eaeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59b0c4b8-5fb8-4d97-9308-4c133dc544db");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "88ac5a05-5986-44a9-ac88-53a53e8804cf", null, "Admin", "ADMIN" },
                    { "8bd6a810-df88-4dd0-82ef-23ff1d0a75fb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "be29edb5-e00e-404e-a8db-f97727a8d41b", 0, "bdf62662-daa0-4fb4-ba46-da95e955b9d0", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEKfuISqXdN+ju6rQUgRq10YcM8BhGhpWvyRhOel/LxAk43i8zn7qVd/pEIFiriZznw==", null, false, "31ef60e0-0c4e-401d-b808-6416e72dceeb", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "imagesAsset\\Pictures\\Sidans Filer\\Filmproduktion\\image (287).jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "88ac5a05-5986-44a9-ac88-53a53e8804cf", "be29edb5-e00e-404e-a8db-f97727a8d41b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bd6a810-df88-4dd0-82ef-23ff1d0a75fb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88ac5a05-5986-44a9-ac88-53a53e8804cf", "be29edb5-e00e-404e-a8db-f97727a8d41b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88ac5a05-5986-44a9-ac88-53a53e8804cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be29edb5-e00e-404e-a8db-f97727a8d41b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0395f328-7436-4f72-b1d0-ce076a78eaeb", null, "Admin", "ADMIN" },
                    { "ca70e8b6-55f4-4f29-a0d0-c1332b26a256", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "59b0c4b8-5fb8-4d97-9308-4c133dc544db", 0, "5d09733c-ac42-4d83-ab99-192c3ac26a27", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEBxWGdWnGQ6fDf6E6RsmLe2ULecKip2YArSpiSU9hQNjLeJ9vzMXN3E2KoaDSoYvtQ==", null, false, "a0d65114-5ddd-40bf-b71d-b6a053c81195", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "imagesAsset\\Pictures\\Sidans Filer\\Filmproduktion\\image(287).jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0395f328-7436-4f72-b1d0-ce076a78eaeb", "59b0c4b8-5fb8-4d97-9308-4c133dc544db" });
        }
    }
}
