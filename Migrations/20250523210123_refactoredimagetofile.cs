using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class refactoredimagetofile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "818e2615-94d7-4bf2-b254-1cfd9c5ae782");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e98b228a-a8ce-4e90-b57c-9ecf838ff30b");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Assets",
                newName: "FileUrl");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "89559e30-6dc8-4ee0-9689-1c197ee74725", null, "User", "USER" },
                    { "f86aef39-730d-40b0-83db-09cfd1326a49", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89559e30-6dc8-4ee0-9689-1c197ee74725");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f86aef39-730d-40b0-83db-09cfd1326a49");

            migrationBuilder.RenameColumn(
                name: "FileUrl",
                table: "Assets",
                newName: "ImageUrl");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "818e2615-94d7-4bf2-b254-1cfd9c5ae782", null, "Admin", "ADMIN" },
                    { "e98b228a-a8ce-4e90-b57c-9ecf838ff30b", null, "User", "USER" }
                });
        }
    }
}
