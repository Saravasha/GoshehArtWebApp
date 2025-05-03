using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Date_Model_Change_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0b6f8432-ec54-4add-9961-b843162c7a60", null, "User", "USER" },
                    { "82d812e7-a0a8-43fb-a116-78153389855b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f950f518-431e-43cb-9880-9169f3c06db7", 0, "8d8c67e0-744f-41d9-acc6-edbc1dde828d", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJZK8sGEPjjdS/Gx06fBxPmHNYT7axDg33SutygaBzPH0ECXYUI7VGs3XeGlJu8wqg==", null, false, "23a6660a-3242-4fab-88f5-71151c1a8340", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "82d812e7-a0a8-43fb-a116-78153389855b", "f950f518-431e-43cb-9880-9169f3c06db7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b6f8432-ec54-4add-9961-b843162c7a60");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "82d812e7-a0a8-43fb-a116-78153389855b", "f950f518-431e-43cb-9880-9169f3c06db7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82d812e7-a0a8-43fb-a116-78153389855b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f950f518-431e-43cb-9880-9169f3c06db7");

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
    }
}
