using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class testingnewstuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24f93699-ec0c-45ae-a88d-83f8b87de5d5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "92286967-c96b-488a-ab55-69fd3c63ed67", "801d4429-3dcc-4752-aa1a-2603e0b1b4a0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92286967-c96b-488a-ab55-69fd3c63ed67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "801d4429-3dcc-4752-aa1a-2603e0b1b4a0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d7f4f7a-9658-4e59-9e0b-07189237f81c", null, "User", "USER" },
                    { "f42759c7-7c74-4384-866a-e86076a77cf0", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c7c2340-4578-4126-9b33-fa5bd9397b61", 0, "4941f26a-c6d4-4d1d-9f59-e64d71800916", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHI04K5hdOOmLlnh1DNcQjqGNhgvFdc1Dru1WEHNDAYsYfVfRWdZYZrx4PqIvSSfig==", null, false, "c6c2aa39-84bd-41cc-bba5-20dd93ee2e25", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f42759c7-7c74-4384-866a-e86076a77cf0", "7c7c2340-4578-4126-9b33-fa5bd9397b61" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d7f4f7a-9658-4e59-9e0b-07189237f81c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f42759c7-7c74-4384-866a-e86076a77cf0", "7c7c2340-4578-4126-9b33-fa5bd9397b61" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f42759c7-7c74-4384-866a-e86076a77cf0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c7c2340-4578-4126-9b33-fa5bd9397b61");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24f93699-ec0c-45ae-a88d-83f8b87de5d5", null, "User", "USER" },
                    { "92286967-c96b-488a-ab55-69fd3c63ed67", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "801d4429-3dcc-4752-aa1a-2603e0b1b4a0", 0, "a23c4a30-b05d-4563-9354-4e898f0eb1f6", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEBx2fk+OdUhe4pZn4lWmlQdOCrFC3Mxnc23zhqxKw5wvYxkFqXtYFgXqky2h8mYtsA==", null, false, "b448dab2-4ce3-4ab6-9097-c7bdff1f18cf", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "92286967-c96b-488a-ab55-69fd3c63ed67", "801d4429-3dcc-4752-aa1a-2603e0b1b4a0" });
        }
    }
}
