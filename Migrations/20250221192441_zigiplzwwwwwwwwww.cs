using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiplzwwwwwwwwww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcffe7fb-88f5-4533-90f2-65ad2fc521b5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5793509b-3797-4cc6-812a-8ab8b53a71a7", "ea80894f-632f-48c4-b575-dba8bd892b6f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5793509b-3797-4cc6-812a-8ab8b53a71a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea80894f-632f-48c4-b575-dba8bd892b6f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14fbe4d3-28dd-4874-bde7-a3a35f30a7eb", null, "User", "USER" },
                    { "e5b2f9c3-d70e-42f5-abb6-394903438a1c", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c117a80b-76bc-470f-bffa-55f6971b7a8d", 0, "c9f64518-e93c-4119-baf0-96d0d205f1fa", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEPQq9vbYjWPKlOrc9RUAGurSAUlp1QjvFP/dQrajB5Zqy6LidRqzFI+Nyt0ghqYFNA==", null, false, "9557d313-62d2-4034-b132-d694367bdfa1", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e5b2f9c3-d70e-42f5-abb6-394903438a1c", "c117a80b-76bc-470f-bffa-55f6971b7a8d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14fbe4d3-28dd-4874-bde7-a3a35f30a7eb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e5b2f9c3-d70e-42f5-abb6-394903438a1c", "c117a80b-76bc-470f-bffa-55f6971b7a8d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5b2f9c3-d70e-42f5-abb6-394903438a1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c117a80b-76bc-470f-bffa-55f6971b7a8d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5793509b-3797-4cc6-812a-8ab8b53a71a7", null, "Admin", "ADMIN" },
                    { "fcffe7fb-88f5-4533-90f2-65ad2fc521b5", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ea80894f-632f-48c4-b575-dba8bd892b6f", 0, "fadd5734-a089-42d3-8687-7132ea60639f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEB9nMwlibmL7XY8A5qReq63yU+uNX6NOyjho94VXUXTPBaLKO6VGxPKczQcO0HrHMg==", null, false, "44dcfc59-0e20-49d6-b6f1-b2f26549efbd", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5793509b-3797-4cc6-812a-8ab8b53a71a7", "ea80894f-632f-48c4-b575-dba8bd892b6f" });
        }
    }
}
