using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class locationdatetimeaddedwwwwww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "386df6cf-f1ed-4adf-8db4-9f74fd90b24e", null, "Admin", "ADMIN" },
                    { "c3e3e75a-be8c-456c-a14b-15f9bcfe3f43", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f86f187d-8507-497e-8da9-298de439145b", 0, "20c64ec0-517d-47b1-9172-672903ef9304", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEEyr75eZL9ODETsZaXRMipN5cTZ+5JS2etRvQul/9vicPomhuET98X1QkjQfH7ilUQ==", null, false, "8d8eb9c2-b9b3-4c68-b4ac-3da473cdae1c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "386df6cf-f1ed-4adf-8db4-9f74fd90b24e", "f86f187d-8507-497e-8da9-298de439145b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3e3e75a-be8c-456c-a14b-15f9bcfe3f43");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "386df6cf-f1ed-4adf-8db4-9f74fd90b24e", "f86f187d-8507-497e-8da9-298de439145b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "386df6cf-f1ed-4adf-8db4-9f74fd90b24e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86f187d-8507-497e-8da9-298de439145b");

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
    }
}
