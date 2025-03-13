using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class locationdatetimeaddedwwww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1145dede-e340-4ba4-84ab-0f67d8cc0554");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5e3dfc1-5071-4bc6-8b49-30fdc5052443", "6eb4975c-c1c1-4b62-90ae-938edb3ba51d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e3dfc1-5071-4bc6-8b49-30fdc5052443");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eb4975c-c1c1-4b62-90ae-938edb3ba51d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24224631-cd86-4920-8d8b-77f4c9b22b4e", null, "User", "USER" },
                    { "d80036fa-5f72-4b80-a95b-99cc65c9ca4a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "435f9efe-abf3-46f7-af10-a2c21598a278", 0, "30bd56cb-3629-4182-b3f1-27df7ccd7d6f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEAm9mMpsd9o4mzD1BHsQCRCMbCtHWNXGjt2R8eXGVACpKaoq5Fm7g2XnrJnXZvTqDg==", null, false, "a4934bc6-c65f-4473-b370-4404963d169b", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d80036fa-5f72-4b80-a95b-99cc65c9ca4a", "435f9efe-abf3-46f7-af10-a2c21598a278" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24224631-cd86-4920-8d8b-77f4c9b22b4e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d80036fa-5f72-4b80-a95b-99cc65c9ca4a", "435f9efe-abf3-46f7-af10-a2c21598a278" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d80036fa-5f72-4b80-a95b-99cc65c9ca4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f9efe-abf3-46f7-af10-a2c21598a278");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1145dede-e340-4ba4-84ab-0f67d8cc0554", null, "User", "USER" },
                    { "a5e3dfc1-5071-4bc6-8b49-30fdc5052443", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6eb4975c-c1c1-4b62-90ae-938edb3ba51d", 0, "4fa306be-51a9-4fb5-a138-92a64b694c51", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJpp7nXsq7ZMS4dRb/eA0tXB0z/DHJf7C/dXI+3/20tUFmZF2yJYeKmHXUNLVnyX4A==", null, false, "332d9025-b02c-417a-8b04-bb446364c297", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a5e3dfc1-5071-4bc6-8b49-30fdc5052443", "6eb4975c-c1c1-4b62-90ae-938edb3ba51d" });
        }
    }
}
