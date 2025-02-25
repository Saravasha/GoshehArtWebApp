using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiplzwkw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "569fc238-91ba-4f4e-a57f-2ca263a0c794", null, "Admin", "ADMIN" },
                    { "adbf2958-c76e-4d09-8831-af82ea945853", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "55cb6588-0814-44b2-8bd6-7dee260ecd27", 0, "0d3429d6-3cea-4c89-948a-e40f3ab8b1f3", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEIlRL/z9dLbLhmLcZPzlDbAAercCOZOwZ5Uy1GnlXMi9PJymL/qXX17YD24EModbVA==", null, false, "66ee1c3b-8e2a-4f5b-93c9-573647fccf4d", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "569fc238-91ba-4f4e-a57f-2ca263a0c794", "55cb6588-0814-44b2-8bd6-7dee260ecd27" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adbf2958-c76e-4d09-8831-af82ea945853");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "569fc238-91ba-4f4e-a57f-2ca263a0c794", "55cb6588-0814-44b2-8bd6-7dee260ecd27" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "569fc238-91ba-4f4e-a57f-2ca263a0c794");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55cb6588-0814-44b2-8bd6-7dee260ecd27");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "88ac5a05-5986-44a9-ac88-53a53e8804cf", "be29edb5-e00e-404e-a8db-f97727a8d41b" });
        }
    }
}
