using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class tryagaine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "478e015a-cd30-49fb-83d8-ab1cc7638c0a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e80c3ed6-52df-4c49-b8ec-582d320ec695", "b4ac291c-e581-4f74-a297-2236753a2e8e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e80c3ed6-52df-4c49-b8ec-582d320ec695");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4ac291c-e581-4f74-a297-2236753a2e8e");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "478e015a-cd30-49fb-83d8-ab1cc7638c0a", null, "User", "USER" },
                    { "e80c3ed6-52df-4c49-b8ec-582d320ec695", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b4ac291c-e581-4f74-a297-2236753a2e8e", 0, "831fa883-1372-49c3-8e66-2222355c6859", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEPYSnOPnm3/F/WmB39hZ4PUW8nWtmHFtBV+tG3d5QXS3D/kiAm1a/EUoXGpycOPZpw==", null, false, "4f16013c-8ae1-46d3-9850-907d6b24249f", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e80c3ed6-52df-4c49-b8ec-582d320ec695", "b4ac291c-e581-4f74-a297-2236753a2e8e" });
        }
    }
}
