using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class locationdatetimeaddedwww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28829bdf-47cf-4dbf-ad9a-fc66442df0ec");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5205dc44-47d5-48c7-ab8d-1ea19142e2d7", "46fe6acb-3009-42b2-9cce-485165065179" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5205dc44-47d5-48c7-ab8d-1ea19142e2d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46fe6acb-3009-42b2-9cce-485165065179");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1145dede-e340-4ba4-84ab-0f67d8cc0554", null, "User", "USER" },
                    { "a5e3dfc1-5071-4bc6-8b49-30fdc5052443", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6eb4975c-c1c1-4b62-90ae-938edb3ba51d", 0, "4fa306be-51a9-4fb5-a138-92a64b694c51", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJpp7nXsq7ZMS4dRb/eA0tXB0z/DHJf7C/dXI+3/20tUFmZF2yJYeKmHXUNLVnyX4A==", null, false, "332d9025-b02c-417a-8b04-bb446364c297", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a5e3dfc1-5071-4bc6-8b49-30fdc5052443", "6eb4975c-c1c1-4b62-90ae-938edb3ba51d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1145dede-e340-4ba4-84ab-0f67d8cc0554");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5e3dfc1-5071-4bc6-8b49-30fdc5052443", "6eb4975c-c1c1-4b62-90ae-938edb3ba51d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e3dfc1-5071-4bc6-8b49-30fdc5052443");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eb4975c-c1c1-4b62-90ae-938edb3ba51d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28829bdf-47cf-4dbf-ad9a-fc66442df0ec", null, "User", "USER" },
                    { "5205dc44-47d5-48c7-ab8d-1ea19142e2d7", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "46fe6acb-3009-42b2-9cce-485165065179", 0, "ced836a9-94b9-419c-876d-1338f2c43670", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEAsmwhNI1vLFoBCNLSOdhPqOZVQ8feGket8ydsAyCiBK8iYmyLkqEQ9teoYKxhSfbg==", null, false, "76bd2b19-0ab4-4431-a3aa-ebb5d46b47a3", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5205dc44-47d5-48c7-ab8d-1ea19142e2d7", "46fe6acb-3009-42b2-9cce-485165065179" });
        }
    }
}
