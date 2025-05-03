using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Date_Model_Change_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a6389fa-0b5a-42ba-91f6-ce0c4604fdf2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "925c9bbf-8d33-41b1-95fe-0d55e3af4db1", "e9d4eaa8-1235-4835-946d-1956d761ae9f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "925c9bbf-8d33-41b1-95fe-0d55e3af4db1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9d4eaa8-1235-4835-946d-1956d761ae9f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24870a51-0628-4193-a21c-65b47e879132", null, "User", "USER" },
                    { "de6020b0-19c9-4a73-9c03-ba51f1b8ae5d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d95658e1-6d5a-469a-9aae-209368b5a589", 0, "420e87a0-4da1-4f2c-a216-069a05d1baee", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEH1/yuqfeAtDnqJCVNjFSPzZ/FdvgmHTswRKCXdZI7M23xqzNRNkIA/w/9u0+e5+Ug==", null, false, "67f33251-67ed-4f6a-9d6b-fd14b6e56e40", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "de6020b0-19c9-4a73-9c03-ba51f1b8ae5d", "d95658e1-6d5a-469a-9aae-209368b5a589" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24870a51-0628-4193-a21c-65b47e879132");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de6020b0-19c9-4a73-9c03-ba51f1b8ae5d", "d95658e1-6d5a-469a-9aae-209368b5a589" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de6020b0-19c9-4a73-9c03-ba51f1b8ae5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d95658e1-6d5a-469a-9aae-209368b5a589");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a6389fa-0b5a-42ba-91f6-ce0c4604fdf2", null, "User", "USER" },
                    { "925c9bbf-8d33-41b1-95fe-0d55e3af4db1", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e9d4eaa8-1235-4835-946d-1956d761ae9f", 0, "df2779c0-e64c-4c5e-af2a-e83387e70443", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEAos7JNyc6KuzIOZrvGI1O/Ef5FhpKgHVsQHsk0JFJI+j6V1W+U0pFVUIacUl5CfZg==", null, false, "80cf78f8-fa67-45f4-be71-3c105f34f909", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "925c9bbf-8d33-41b1-95fe-0d55e3af4db1", "e9d4eaa8-1235-4835-946d-1956d761ae9f" });
        }
    }
}
