using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiplzw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4c81d983-e4ad-431e-ac11-82a4df746a67", null, "User", "USER" },
                    { "f6807f3c-4d55-4d10-81e3-bde36592195b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileUrl",
                value: "/Assets/Filmproduktion/image (287).jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c81d983-e4ad-431e-ac11-82a4df746a67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6807f3c-4d55-4d10-81e3-bde36592195b");

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
        }
    }
}
