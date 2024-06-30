using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiplz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2fe0714f-78d9-4dc7-abb4-97a32b2ed5e5", null, "Admin", "ADMIN" },
                    { "3b51233e-1a8f-49aa-822a-3782740eb696", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d9aea14b-2fdc-4e42-91c5-eb92e6fc080e", 0, "97fa5f8b-ee98-4ca6-a41b-35e102deed32", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEDdG57ujwYkulpf/diCouBG2N5pn0ZfJV1stnzt5dIym33iP2k81BB6JQY81fhWB5g==", null, false, "956d9b39-2e20-4777-aa22-e94484663db9", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2fe0714f-78d9-4dc7-abb4-97a32b2ed5e5", "d9aea14b-2fdc-4e42-91c5-eb92e6fc080e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b51233e-1a8f-49aa-822a-3782740eb696");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2fe0714f-78d9-4dc7-abb4-97a32b2ed5e5", "d9aea14b-2fdc-4e42-91c5-eb92e6fc080e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fe0714f-78d9-4dc7-abb4-97a32b2ed5e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9aea14b-2fdc-4e42-91c5-eb92e6fc080e");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "771c8e5d-57c1-4e45-85d3-28c83fd33e85", "30219eb8-e905-4371-9c19-fc9917a063fb" });
        }
    }
}
