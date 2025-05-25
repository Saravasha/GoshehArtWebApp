using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addingthumbnailstoassetwithffmpeg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e6909c6-9453-48bd-a781-b95125a17faa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef5789e7-20f1-4ac9-8b1b-15246b55f84d");

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c64d6976-2600-4fdd-992f-b1eb5ed11ce3", null, "Admin", "ADMIN" },
                    { "dd7cacba-0a40-4746-82b6-d9fe650f5e2a", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThumbnailUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThumbnailUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "ThumbnailUrl",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c64d6976-2600-4fdd-992f-b1eb5ed11ce3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd7cacba-0a40-4746-82b6-d9fe650f5e2a");

            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Assets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e6909c6-9453-48bd-a781-b95125a17faa", null, "User", "USER" },
                    { "ef5789e7-20f1-4ac9-8b1b-15246b55f84d", null, "Admin", "ADMIN" }
                });
        }
    }
}
