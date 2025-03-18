using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigisewaweww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e998af92-fbc5-4fad-85c8-5e6135f3c921");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0590600-c37d-4c1d-9f0c-1b2f3a41d928", "8a16428f-02d1-45e5-897b-11e0e7ddea51" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0590600-c37d-4c1d-9f0c-1b2f3a41d928");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a16428f-02d1-45e5-897b-11e0e7ddea51");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07918bec-ac06-457d-b8c3-13a2762f97e4", null, "Admin", "ADMIN" },
                    { "8d5acf14-30f8-4b89-840d-1c16b2778a64", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8da2b545-e7fb-41b4-9a0a-3b36463b24ce", 0, "cd346bbe-b334-470d-b85d-b72ba55dc2d7", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJmovvtnwmG1JKCyjMNvPKoVBec+/K7gFruiDoHSO7xTaGGT3Vs3h4epS86MMu39VQ==", null, false, "e012191f-1827-4d6e-874e-f0251271c8a6", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "07918bec-ac06-457d-b8c3-13a2762f97e4", "8da2b545-e7fb-41b4-9a0a-3b36463b24ce" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d5acf14-30f8-4b89-840d-1c16b2778a64");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07918bec-ac06-457d-b8c3-13a2762f97e4", "8da2b545-e7fb-41b4-9a0a-3b36463b24ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07918bec-ac06-457d-b8c3-13a2762f97e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8da2b545-e7fb-41b4-9a0a-3b36463b24ce");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c0590600-c37d-4c1d-9f0c-1b2f3a41d928", null, "Admin", "ADMIN" },
                    { "e998af92-fbc5-4fad-85c8-5e6135f3c921", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8a16428f-02d1-45e5-897b-11e0e7ddea51", 0, "beb3383e-81a9-40af-a4d3-22d014490cbe", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEICphBFiTPKpayKDnKqZgLGwpDVDomSRqr7InaaylnZ0lC3+y2Isrz5LZ2WK9QSnCw==", null, false, "550334aa-9bb6-4871-a8c9-ed59914cdd60", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c0590600-c37d-4c1d-9f0c-1b2f3a41d928", "8a16428f-02d1-45e5-897b-11e0e7ddea51" });
        }
    }
}
