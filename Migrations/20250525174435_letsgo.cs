using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class letsgo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0a46f81-538c-46b8-aed0-1adc1f2b2ba6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb4a7481-a488-4e9c-99e8-3f5f780ed23d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "869b028b-3af6-4105-82ef-6b1086b54350", null, "Admin", "ADMIN" },
                    { "b4fc879b-61a5-4f2f-ad65-f817ea41f47e", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "869b028b-3af6-4105-82ef-6b1086b54350");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4fc879b-61a5-4f2f-ad65-f817ea41f47e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d0a46f81-538c-46b8-aed0-1adc1f2b2ba6", null, "User", "USER" },
                    { "fb4a7481-a488-4e9c-99e8-3f5f780ed23d", null, "Admin", "ADMIN" }
                });
        }
    }
}
