using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class assetplz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ad68e11-3164-4cd9-8712-b3a5cdc4e707");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b615b2f4-75f5-4d06-8112-a047409deb7b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5929de76-3400-4aea-903f-526bf642bc0c", null, "User", "USER" },
                    { "fd91fa18-56c1-4513-b1f3-b57a71fd9532", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5929de76-3400-4aea-903f-526bf642bc0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd91fa18-56c1-4513-b1f3-b57a71fd9532");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ad68e11-3164-4cd9-8712-b3a5cdc4e707", null, "User", "USER" },
                    { "b615b2f4-75f5-4d06-8112-a047409deb7b", null, "Admin", "ADMIN" }
                });
        }
    }
}
