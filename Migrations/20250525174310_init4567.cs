using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class init4567 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df41cd76-80ab-4244-a64a-3fe564e69424");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed4d03b7-9fdb-47a9-94d8-0676148f68ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d0a46f81-538c-46b8-aed0-1adc1f2b2ba6", null, "User", "USER" },
                    { "fb4a7481-a488-4e9c-99e8-3f5f780ed23d", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "df41cd76-80ab-4244-a64a-3fe564e69424", null, "User", "USER" },
                    { "ed4d03b7-9fdb-47a9-94d8-0676148f68ea", null, "Admin", "ADMIN" }
                });
        }
    }
}
