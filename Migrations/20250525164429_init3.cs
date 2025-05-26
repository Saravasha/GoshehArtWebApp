using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71517ab7-694e-49b9-9b2f-96c7adc9660e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acbc8993-1877-4595-a114-347e9e5d96f4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a7f7bfd-52bf-42f9-bbbd-51e3391afbf5", null, "Admin", "ADMIN" },
                    { "6eed02c6-8fed-470d-b5dc-3e56c1a910e3", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a7f7bfd-52bf-42f9-bbbd-51e3391afbf5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eed02c6-8fed-470d-b5dc-3e56c1a910e3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71517ab7-694e-49b9-9b2f-96c7adc9660e", null, "Admin", "ADMIN" },
                    { "acbc8993-1877-4595-a114-347e9e5d96f4", null, "User", "USER" }
                });
        }
    }
}
