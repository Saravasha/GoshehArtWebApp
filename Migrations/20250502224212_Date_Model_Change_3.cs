using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Date_Model_Change_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61838291-dfca-483c-bb8b-18fc1a8183f2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e7c1479-2515-4f19-a39c-0e263d78b128", "4d5b0aad-320e-4340-aaf1-a0c2aa5da70e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e7c1479-2515-4f19-a39c-0e263d78b128");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d5b0aad-320e-4340-aaf1-a0c2aa5da70e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4fe54ceb-e7d0-4328-944b-41c7cb843043", null, "Admin", "ADMIN" },
                    { "b07b5f93-9584-4e5a-bd93-cf1e0dbc9b13", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a972b784-11b1-4876-8382-9fd765d45780", 0, "d7338e6d-9769-45f4-ba05-575587516c0c", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEIjqzTfXHDehkL0IN3zJnm6zmz/qgljdQ4y3SycQ6/Paoe3vpL0jUC1CsewBIywN+g==", null, false, "3316fc82-4564-41ba-85fa-855e2f754995", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4fe54ceb-e7d0-4328-944b-41c7cb843043", "a972b784-11b1-4876-8382-9fd765d45780" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b07b5f93-9584-4e5a-bd93-cf1e0dbc9b13");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4fe54ceb-e7d0-4328-944b-41c7cb843043", "a972b784-11b1-4876-8382-9fd765d45780" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe54ceb-e7d0-4328-944b-41c7cb843043");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a972b784-11b1-4876-8382-9fd765d45780");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e7c1479-2515-4f19-a39c-0e263d78b128", null, "Admin", "ADMIN" },
                    { "61838291-dfca-483c-bb8b-18fc1a8183f2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4d5b0aad-320e-4340-aaf1-a0c2aa5da70e", 0, "e4ff75f5-a25e-470d-8ec5-76326969caff", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAED5fgP8XPpa3ttmMHdpaMy8KBrllTpgBNLEhSzT8vZ/buHD6V328oYKCVSU3uSbblg==", null, false, "3ec6e4b8-fcfa-484a-be25-cc5cd5297701", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0e7c1479-2515-4f19-a39c-0e263d78b128", "4d5b0aad-320e-4340-aaf1-a0c2aa5da70e" });
        }
    }
}
