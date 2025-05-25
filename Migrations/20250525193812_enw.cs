using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class enw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "301417fe-7ff2-4636-b4c1-1745dc282955", null, "Admin", "ADMIN" },
                    { "8db4e018-1b73-43ba-94b1-1a35bc5ed3e9", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "301417fe-7ff2-4636-b4c1-1745dc282955");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8db4e018-1b73-43ba-94b1-1a35bc5ed3e9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5929de76-3400-4aea-903f-526bf642bc0c", null, "User", "USER" },
                    { "fd91fa18-56c1-4513-b1f3-b57a71fd9532", null, "Admin", "ADMIN" }
                });
        }
    }
}
