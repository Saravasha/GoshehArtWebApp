using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class tryingSecretInjector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be5207a0-d622-4b53-bb54-61a7ae4b8d4a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b7ec58a-c825-46d3-9626-e2cd0f15b341", "63ec3c82-2f7a-4a24-ab6a-51e973d2af03" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b7ec58a-c825-46d3-9626-e2cd0f15b341");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63ec3c82-2f7a-4a24-ab6a-51e973d2af03");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "501aeced-7488-4788-98a1-ce184606a475", null, "Admin", "ADMIN" },
                    { "80503bc3-1835-4a25-a424-5411883c2038", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "13b7f9e2-7914-4269-9ce6-07c7a24348e0", 0, "d622867f-c0ac-4d40-965a-9b5e4ffa1323", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEO0bTo5tEIU2O10NQ6TI6YA49FAvgDN8z0qib+QfSReV/LLKa1H6/gJJ9PfdDd2SNA==", null, false, "033c29de-2da8-4bb8-8893-a26bc8e7ac5f", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "501aeced-7488-4788-98a1-ce184606a475", "13b7f9e2-7914-4269-9ce6-07c7a24348e0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80503bc3-1835-4a25-a424-5411883c2038");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "501aeced-7488-4788-98a1-ce184606a475", "13b7f9e2-7914-4269-9ce6-07c7a24348e0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "501aeced-7488-4788-98a1-ce184606a475");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13b7f9e2-7914-4269-9ce6-07c7a24348e0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b7ec58a-c825-46d3-9626-e2cd0f15b341", null, "Admin", "ADMIN" },
                    { "be5207a0-d622-4b53-bb54-61a7ae4b8d4a", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "63ec3c82-2f7a-4a24-ab6a-51e973d2af03", 0, "a5204ade-db32-4708-bab6-45a613ad1e9a", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEER/meij2e0mwftmjzBaGAgoNC/+3xkXGdf88ZwNWbtMT/DfdML/qJjNIHnnnod+/w==", null, false, "a21601c2-67cf-45cf-a1fb-16733e7d1cd0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2b7ec58a-c825-46d3-9626-e2cd0f15b341", "63ec3c82-2f7a-4a24-ab6a-51e973d2af03" });
        }
    }
}
