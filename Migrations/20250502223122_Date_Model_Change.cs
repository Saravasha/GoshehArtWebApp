using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Date_Model_Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73826d4b-b842-494c-9ab7-901b4193d1f5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b774f3f-146b-4801-a6d0-2bf082340334", "77c903ae-c29b-4676-866e-670c3d1a5c77" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b774f3f-146b-4801-a6d0-2bf082340334");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c903ae-c29b-4676-866e-670c3d1a5c77");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3b774f3f-146b-4801-a6d0-2bf082340334", null, "Admin", "ADMIN" },
                    { "73826d4b-b842-494c-9ab7-901b4193d1f5", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "77c903ae-c29b-4676-866e-670c3d1a5c77", 0, "71eb1d25-0008-4071-a0bc-43652868bcc9", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEMi6ASJRna8OFtbRhV+7khDolpfiO1lOuqo6p8sfVEjCkts9sUtf0U3bfFbgmpu85A==", null, false, "65c3868e-79ba-460f-98d9-9d1cf930692e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3b774f3f-146b-4801-a6d0-2bf082340334", "77c903ae-c29b-4676-866e-670c3d1a5c77" });
        }
    }
}
