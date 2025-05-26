using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class massiveoverhaul : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c64d6976-2600-4fdd-992f-b1eb5ed11ce3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd7cacba-0a40-4746-82b6-d9fe650f5e2a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e3ceaf1-b5a0-4df8-8ab4-e745c734c274", null, "Admin", "ADMIN" },
                    { "d39df32e-883b-4dea-b353-62d1b9f0ab3a", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e3ceaf1-b5a0-4df8-8ab4-e745c734c274");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d39df32e-883b-4dea-b353-62d1b9f0ab3a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c64d6976-2600-4fdd-992f-b1eb5ed11ce3", null, "Admin", "ADMIN" },
                    { "dd7cacba-0a40-4746-82b6-d9fe650f5e2a", null, "User", "USER" }
                });
        }
    }
}
