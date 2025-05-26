using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class init456 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca10ba9f-8fdd-4239-ab85-f5fa2acbea6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d72a7a87-2df3-4139-af90-872d36453bab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "df41cd76-80ab-4244-a64a-3fe564e69424", null, "User", "USER" },
                    { "ed4d03b7-9fdb-47a9-94d8-0676148f68ea", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "ca10ba9f-8fdd-4239-ab85-f5fa2acbea6f", null, "User", "USER" },
                    { "d72a7a87-2df3-4139-af90-872d36453bab", null, "Admin", "ADMIN" }
                });
        }
    }
}
