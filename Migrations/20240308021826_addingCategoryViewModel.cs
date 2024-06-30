using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addingCategoryViewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24d80ffa-8803-474f-b80b-c321a40e5314");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "969547db-f09f-4f83-ae5a-0d502c0495e7", "bf0df987-72ac-49c7-8341-99681a182153" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "969547db-f09f-4f83-ae5a-0d502c0495e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf0df987-72ac-49c7-8341-99681a182153");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "51ac23b9-8ae2-4c95-b239-626ecce116e7", null, "Admin", "ADMIN" },
                    { "7e636d80-03cb-428b-9b08-2d9f8b60b02a", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4ee363e7-ba0f-4491-aa80-6a457b2df50e", 0, "0e14430a-287b-45f3-b71b-43fc983a9f66", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEFzH+zu+DeC5CiFnNS49jLl954eDkTknNurgdIaWhG6L/xjCQI4g15a8DCgitlixag==", null, false, "46d01663-0a1f-4edf-8661-f8373c57da52", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "51ac23b9-8ae2-4c95-b239-626ecce116e7", "4ee363e7-ba0f-4491-aa80-6a457b2df50e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e636d80-03cb-428b-9b08-2d9f8b60b02a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "51ac23b9-8ae2-4c95-b239-626ecce116e7", "4ee363e7-ba0f-4491-aa80-6a457b2df50e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51ac23b9-8ae2-4c95-b239-626ecce116e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ee363e7-ba0f-4491-aa80-6a457b2df50e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24d80ffa-8803-474f-b80b-c321a40e5314", null, "User", "USER" },
                    { "969547db-f09f-4f83-ae5a-0d502c0495e7", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bf0df987-72ac-49c7-8341-99681a182153", 0, "88dfd0fd-cd55-49f9-a26d-18f9236738f9", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEIQ9zzyu0mWkOK/3q8zFb4vPYmuBr6NEPg8XVB7qfvIqHxYzEYUWiRrRI+bAkoUieg==", null, false, "82440c2a-2949-4f14-89f7-621d8e053e0e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "969547db-f09f-4f83-ae5a-0d502c0495e7", "bf0df987-72ac-49c7-8341-99681a182153" });
        }
    }
}
