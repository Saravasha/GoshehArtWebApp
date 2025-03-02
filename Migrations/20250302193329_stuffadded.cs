using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class stuffadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "6cfa678c-c4a6-4c99-9629-0dc47a79d9d8", null, "User", "USER" },
                    { "845755f5-ce97-40a4-be39-96bec8521abb", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "74205d85-5689-4529-8d70-d4c2a3f39366", 0, "b6452704-d6ee-4377-8ae7-7328fb235867", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEOpm5HvIoBxD+0fFMh7kM1d+nxPpL6acqDUddJWmjgmg5BpzuwyWHGeSyIvXazFJ7g==", null, false, "64bf76fb-146a-4091-a680-e2cdc3ab6481", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "845755f5-ce97-40a4-be39-96bec8521abb", "74205d85-5689-4529-8d70-d4c2a3f39366" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cfa678c-c4a6-4c99-9629-0dc47a79d9d8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "845755f5-ce97-40a4-be39-96bec8521abb", "74205d85-5689-4529-8d70-d4c2a3f39366" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "845755f5-ce97-40a4-be39-96bec8521abb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74205d85-5689-4529-8d70-d4c2a3f39366");

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
    }
}
