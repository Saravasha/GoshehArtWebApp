using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addedNewCategoriesByCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2b3c1929-7e44-43e9-9fa4-10976e6f90b3", null, "User", "USER" },
                    { "771c8e5d-57c1-4e45-85d3-28c83fd33e85", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30219eb8-e905-4371-9c19-fc9917a063fb", 0, "aada92b3-db53-4a95-9b57-a5c5cf49bc9b", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEH0ySJKwrVX8MzEA7DKb3OXe3XyoGlZ9xdYKAfTTHsnviCiTInY11zkSxoOxfABREw==", null, false, "0061c3ca-9267-4172-8e30-cc0eb86b4661", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Press" },
                    { 5, "Foto" },
                    { 6, "Kontroversiell Konst" },
                    { 7, "Abstrakt Konst" },
                    { 8, "Akvarell Konst" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "771c8e5d-57c1-4e45-85d3-28c83fd33e85", "30219eb8-e905-4371-9c19-fc9917a063fb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b3c1929-7e44-43e9-9fa4-10976e6f90b3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "771c8e5d-57c1-4e45-85d3-28c83fd33e85", "30219eb8-e905-4371-9c19-fc9917a063fb" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771c8e5d-57c1-4e45-85d3-28c83fd33e85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30219eb8-e905-4371-9c19-fc9917a063fb");

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
    }
}
