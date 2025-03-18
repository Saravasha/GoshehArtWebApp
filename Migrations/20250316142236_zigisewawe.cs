using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigisewawe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78710c15-3a49-4d94-966b-764558613965");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "208672f1-7446-41c3-ae24-655e77e2832b", "acc19888-4bfc-48d4-a4b6-33fc06cb8f55" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "208672f1-7446-41c3-ae24-655e77e2832b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acc19888-4bfc-48d4-a4b6-33fc06cb8f55");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "208672f1-7446-41c3-ae24-655e77e2832b", null, "Admin", "ADMIN" },
                    { "78710c15-3a49-4d94-966b-764558613965", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "acc19888-4bfc-48d4-a4b6-33fc06cb8f55", 0, "5ffcccdb-2739-48c0-82dc-9f2e32191369", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEABfR6NaUzRKivBi1sckvCErfqHsdNNaqev+rApbpq2oUX2RC+GsSZlgmlx+e9QHEA==", null, false, "294536d1-12b9-40c5-9ba8-c8bdb73dc7fb", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "208672f1-7446-41c3-ae24-655e77e2832b", "acc19888-4bfc-48d4-a4b6-33fc06cb8f55" });
        }
    }
}
