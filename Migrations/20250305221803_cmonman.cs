using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class cmonman : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d53c702-e681-47e6-97f9-e187f5a9e902");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ca8adea-98b6-4a62-86c1-0311dac6eff9", "1f8a5396-748c-42ed-8c59-202f3399ca9d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ca8adea-98b6-4a62-86c1-0311dac6eff9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f8a5396-748c-42ed-8c59-202f3399ca9d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0ca8adea-98b6-4a62-86c1-0311dac6eff9", null, "Admin", "ADMIN" },
                    { "8d53c702-e681-47e6-97f9-e187f5a9e902", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1f8a5396-748c-42ed-8c59-202f3399ca9d", 0, "778f75db-bc9b-48f6-971d-31118c375741", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEG9IxtgQVVC3tA9zAjYv+o9Yo/58aujOVczFFR6D2vVm2hV7dcBIDf8Auy3zV35i7Q==", null, false, "9e24087a-4270-48e6-9794-32b6386208c1", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0ca8adea-98b6-4a62-86c1-0311dac6eff9", "1f8a5396-748c-42ed-8c59-202f3399ca9d" });
        }
    }
}
