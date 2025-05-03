using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Date_Model_Change_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8b74c19-3334-49d2-af06-3460a2ba0797");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "139299a9-c592-4f70-95c9-62c655307835", "91c31e12-a4b7-4216-8add-b6a6f2a60445" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "139299a9-c592-4f70-95c9-62c655307835");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91c31e12-a4b7-4216-8add-b6a6f2a60445");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "139299a9-c592-4f70-95c9-62c655307835", null, "Admin", "ADMIN" },
                    { "d8b74c19-3334-49d2-af06-3460a2ba0797", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "91c31e12-a4b7-4216-8add-b6a6f2a60445", 0, "66b23006-df2e-4ddf-813c-9e44bc16c170", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAELEQoQpHVm0XZOmiFvSKtv7PIOA1RBRA0wvJGTZNK/9gzpgFtLNeHr4cUPONDk+NXg==", null, false, "5bdd1181-d922-436c-b5fe-9e87064de7b3", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "139299a9-c592-4f70-95c9-62c655307835", "91c31e12-a4b7-4216-8add-b6a6f2a60445" });
        }
    }
}
