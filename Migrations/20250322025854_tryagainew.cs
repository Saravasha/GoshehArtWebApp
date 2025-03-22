using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class tryagainew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34b59e6a-34d7-4577-9135-a5e423b8c49e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12a5d893-d463-4e24-9466-6fc0548360a9", "288ff2bd-75f2-4fa7-ab89-5439bab35208" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12a5d893-d463-4e24-9466-6fc0548360a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "288ff2bd-75f2-4fa7-ab89-5439bab35208");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "007218ec-166a-4793-b7a5-3f110ca2a038", null, "Admin", "ADMIN" },
                    { "844b7939-25d1-44e9-9cd0-a8bdf0c8119c", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c175491c-85ab-4824-b260-37a6735ff838", 0, "5dcce677-176c-49d6-bf76-25871bd31c7a", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGiro73/ULp9Zv9Pm9T5OlJR0fdIKOrYoCiuluWxVe6QP+FyMRFe/TxSYMCMItW45g==", null, false, "f3aadc1a-22eb-4395-9844-2816724ab3dc", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "007218ec-166a-4793-b7a5-3f110ca2a038", "c175491c-85ab-4824-b260-37a6735ff838" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "844b7939-25d1-44e9-9cd0-a8bdf0c8119c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "007218ec-166a-4793-b7a5-3f110ca2a038", "c175491c-85ab-4824-b260-37a6735ff838" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "007218ec-166a-4793-b7a5-3f110ca2a038");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c175491c-85ab-4824-b260-37a6735ff838");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12a5d893-d463-4e24-9466-6fc0548360a9", null, "Admin", "ADMIN" },
                    { "34b59e6a-34d7-4577-9135-a5e423b8c49e", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "288ff2bd-75f2-4fa7-ab89-5439bab35208", 0, "e2b01393-e08d-4eb9-a89d-95bf6589bfed", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJwhTILWkFUCmq0ac/EKj66qDNyZHyLtkQotpN3ttQf2Cp4TtQrPLrUKfKfgWwXA2A==", null, false, "416b9a28-94c7-4cba-858e-31005a4076f3", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "12a5d893-d463-4e24-9466-6fc0548360a9", "288ff2bd-75f2-4fa7-ab89-5439bab35208" });
        }
    }
}
