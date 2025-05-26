using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newColorsAdded3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2d41658-a1dd-488e-8ec9-caeac2094bef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef4f5344-43fa-4793-a52a-ac48f492c33f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d951bf6-8c51-48c4-95a2-49ea247e057d", null, "Admin", "ADMIN" },
                    { "e4f3aaf8-7007-4ca4-b829-ca7d75d37d97", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d951bf6-8c51-48c4-95a2-49ea247e057d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4f3aaf8-7007-4ca4-b829-ca7d75d37d97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2d41658-a1dd-488e-8ec9-caeac2094bef", null, "User", "USER" },
                    { "ef4f5344-43fa-4793-a52a-ac48f492c33f", null, "Admin", "ADMIN" }
                });
        }
    }
}
