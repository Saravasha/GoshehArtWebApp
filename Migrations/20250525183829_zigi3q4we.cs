using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigi3q4we : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4f0e06cf-fc58-48b5-9161-669e21c42cca", null, "User", "USER" },
                    { "dd309164-dea1-480f-9013-40b94eea355d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "DarkEndColor", "DarkStartColor", "EndColor", "Name", "StartColor" },
                values: new object[] { 2, "#000000", "#000000", "#000000", "Header Text", "#000000" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f0e06cf-fc58-48b5-9161-669e21c42cca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd309164-dea1-480f-9013-40b94eea355d");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "869b028b-3af6-4105-82ef-6b1086b54350", null, "Admin", "ADMIN" },
                    { "b4fc879b-61a5-4f2f-ad65-f817ea41f47e", null, "User", "USER" }
                });
        }
    }
}
