using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Date_Model_Change_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4ac16562-a52c-4fd1-86ff-5479fd96bbdc", null, "User", "USER" },
                    { "a9bb7c3e-9f31-4915-b3a0-3d423221c94b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4a37691-6612-4ba7-8137-40bedbfe7274", 0, "2fe6f712-fb2f-4bf5-9912-5391001db29b", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECGEYO4Adqk9TU1BQYrxhk7UpxEEC/kZY2qxtI6Q/pKwZBzLwlJ9LdnQKMdJyGLD7w==", null, false, "e1f99183-acd4-4837-9196-9ed5ef3abcf5", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a9bb7c3e-9f31-4915-b3a0-3d423221c94b", "e4a37691-6612-4ba7-8137-40bedbfe7274" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ac16562-a52c-4fd1-86ff-5479fd96bbdc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9bb7c3e-9f31-4915-b3a0-3d423221c94b", "e4a37691-6612-4ba7-8137-40bedbfe7274" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bb7c3e-9f31-4915-b3a0-3d423221c94b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4a37691-6612-4ba7-8137-40bedbfe7274");

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
    }
}
