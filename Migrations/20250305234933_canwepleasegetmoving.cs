using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class canwepleasegetmoving : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a1ee4ae-24bf-4bb7-bac1-9d86613fd810");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "707cfdda-3bd2-4bb3-af4a-5092ac108578", "97511b9f-cadf-497b-b93d-1088f3991af2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "707cfdda-3bd2-4bb3-af4a-5092ac108578");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97511b9f-cadf-497b-b93d-1088f3991af2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f1a3453-4dc2-4c9b-b2ad-8dcc9d347863", null, "Admin", "ADMIN" },
                    { "86f1c223-5d37-4859-8f54-7067d8fb61a0", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "433fd63b-d6ed-430f-b25d-ceea231a4f3d", 0, "7afc6f3c-dbd0-4681-8377-ce6597f90de3", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEHG2VuFcN5HnNgfHnfQadCpSOQAGyqv5E2ufI+z64ifcw/FxIqMKC1jC9zrgWr4Jg==", null, false, "1bbec546-a71f-4f1e-944e-0e8bb15cffb0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0f1a3453-4dc2-4c9b-b2ad-8dcc9d347863", "433fd63b-d6ed-430f-b25d-ceea231a4f3d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86f1c223-5d37-4859-8f54-7067d8fb61a0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f1a3453-4dc2-4c9b-b2ad-8dcc9d347863", "433fd63b-d6ed-430f-b25d-ceea231a4f3d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f1a3453-4dc2-4c9b-b2ad-8dcc9d347863");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "433fd63b-d6ed-430f-b25d-ceea231a4f3d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a1ee4ae-24bf-4bb7-bac1-9d86613fd810", null, "User", "USER" },
                    { "707cfdda-3bd2-4bb3-af4a-5092ac108578", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "97511b9f-cadf-497b-b93d-1088f3991af2", 0, "3a4553b0-a927-4a0a-890f-6120eb0c0094", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENdp73795PByuoNPMJQzKKLAmN1t2EF88myFT0wDfPfNpjFuqfGIaMe/KU/axNAz9A==", null, false, "020dc4cd-e6a5-4757-9472-33ea78bfc12c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "707cfdda-3bd2-4bb3-af4a-5092ac108578", "97511b9f-cadf-497b-b93d-1088f3991af2" });
        }
    }
}
