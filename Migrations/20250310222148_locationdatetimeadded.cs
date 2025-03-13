using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class locationdatetimeadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Assets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Location" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5205dc44-47d5-48c7-ab8d-1ea19142e2d7", "46fe6acb-3009-42b2-9cce-485165065179" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Assets");

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
    }
}
