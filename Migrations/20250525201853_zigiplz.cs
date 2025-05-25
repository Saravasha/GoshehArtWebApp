using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiplz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "78c1a63a-ad74-4785-9d1f-ba0431317feb", null, "Admin", "ADMIN" },
                    { "b9cff4b4-7c11-47ae-bed6-3d91118b6f77", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileUrl",
                value: "A/ssets/Filmproduktion/image (287).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileUrl",
                value: "/Assets/Kontroversiell Konst/image (3).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileUrl",
                value: "/Assets/Filmproduktion/image (304).jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c1a63a-ad74-4785-9d1f-ba0431317feb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9cff4b4-7c11-47ae-bed6-3d91118b6f77");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "301417fe-7ff2-4636-b4c1-1745dc282955", null, "Admin", "ADMIN" },
                    { "8db4e018-1b73-43ba-94b1-1a35bc5ed3e9", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileUrl",
                value: "Assets/Filmproduktion/image (287).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileUrl",
                value: "Assets/Kontroversiell Konst/image (3).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileUrl",
                value: "Assets/Filmproduktion/image (304).jpg");
        }
    }
}
