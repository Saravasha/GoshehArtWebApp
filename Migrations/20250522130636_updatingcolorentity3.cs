using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class updatingcolorentity3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90b1851a-f48b-4a7f-a91b-1ef3c5894e72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc7e45f5-5459-4a6f-8af9-d90ded65689d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1380e15e-fa7c-4d32-9e41-91f46f227767", null, "Admin", "ADMIN" },
                    { "efd49bfa-91fd-42f1-82d0-5815562d2509", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DarkEndColor", "DarkStartColor", "EndColor", "StartColor" },
                values: new object[] { "#000000", "#000000", "#000000", "#000000" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1380e15e-fa7c-4d32-9e41-91f46f227767");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efd49bfa-91fd-42f1-82d0-5815562d2509");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "90b1851a-f48b-4a7f-a91b-1ef3c5894e72", null, "Admin", "ADMIN" },
                    { "dc7e45f5-5459-4a6f-8af9-d90ded65689d", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DarkEndColor", "DarkStartColor", "EndColor", "StartColor" },
                values: new object[] { null, null, null, null });
        }
    }
}
