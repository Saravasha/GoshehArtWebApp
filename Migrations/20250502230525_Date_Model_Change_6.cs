using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Date_Model_Change_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2b027a-1981-4e3f-b650-bba557b5e61d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b62d7771-309e-4aa9-918c-b1587c6e0111", "f21b6fce-fe01-4650-b6f3-a1036255e028" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b62d7771-309e-4aa9-918c-b1587c6e0111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f21b6fce-fe01-4650-b6f3-a1036255e028");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "88c86b59-f8ef-4d53-af56-f49eb39922a8", null, "Admin", "ADMIN" },
                    { "f0a57ea4-1d01-442d-8542-d0e17dd181a2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4792b28c-75e6-4587-9970-3a77220f114a", 0, "db6f2e25-16ad-4cc7-aa4b-17c89b0ab8c1", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHxRhBiK64WDVnT86O5YZk4anG2jJtAXYkTliMz7gZNM0/5bAjopfLwcSijBZyTaWA==", null, false, "e74ef5e3-0cfd-4bc3-a587-58393100de8e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "88c86b59-f8ef-4d53-af56-f49eb39922a8", "4792b28c-75e6-4587-9970-3a77220f114a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0a57ea4-1d01-442d-8542-d0e17dd181a2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88c86b59-f8ef-4d53-af56-f49eb39922a8", "4792b28c-75e6-4587-9970-3a77220f114a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88c86b59-f8ef-4d53-af56-f49eb39922a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4792b28c-75e6-4587-9970-3a77220f114a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b62d7771-309e-4aa9-918c-b1587c6e0111", null, "Admin", "ADMIN" },
                    { "bd2b027a-1981-4e3f-b650-bba557b5e61d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f21b6fce-fe01-4650-b6f3-a1036255e028", 0, "834394c7-38ae-4c6b-a032-2195b0d98b1d", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHIbYjW30PRLX9KzKVKafd2u+opQRB2Vr+S0i77o3tJKvd+Zo9NIv6kBlOnEf0YyFQ==", null, false, "a764c9a5-8cc1-48e1-aa00-91b165b3f358", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b62d7771-309e-4aa9-918c-b1587c6e0111", "f21b6fce-fe01-4650-b6f3-a1036255e028" });
        }
    }
}
