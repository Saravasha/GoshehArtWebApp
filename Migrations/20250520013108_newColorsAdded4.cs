using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newColorsAdded4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "cc568e39-fa3a-451d-817b-f55903f56d9d", null, "User", "USER" },
                    { "f0f80468-a6ab-4dd3-977b-2e8f20ec8e59", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradientColor",
                value: "gradientNotSet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc568e39-fa3a-451d-817b-f55903f56d9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f80468-a6ab-4dd3-977b-2e8f20ec8e59");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d951bf6-8c51-48c4-95a2-49ea247e057d", null, "Admin", "ADMIN" },
                    { "e4f3aaf8-7007-4ca4-b829-ca7d75d37d97", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradientColor",
                value: "");
        }
    }
}
