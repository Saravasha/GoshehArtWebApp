using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class colormodelrefactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc568e39-fa3a-451d-817b-f55903f56d9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f80468-a6ab-4dd3-977b-2e8f20ec8e59");

            migrationBuilder.RenameColumn(
                name: "GradientColor",
                table: "Colors",
                newName: "EndColor");

            migrationBuilder.RenameColumn(
                name: "BgColor",
                table: "Colors",
                newName: "StartColor");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40e8d240-fc1d-498b-9b81-f5da3dea8af9", null, "User", "USER" },
                    { "fdb95523-7a4d-4662-95b2-07520bb54f68", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Background Color");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40e8d240-fc1d-498b-9b81-f5da3dea8af9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdb95523-7a4d-4662-95b2-07520bb54f68");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Colors");

            migrationBuilder.RenameColumn(
                name: "StartColor",
                table: "Colors",
                newName: "BgColor");

            migrationBuilder.RenameColumn(
                name: "EndColor",
                table: "Colors",
                newName: "GradientColor");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cc568e39-fa3a-451d-817b-f55903f56d9d", null, "User", "USER" },
                    { "f0f80468-a6ab-4dd3-977b-2e8f20ec8e59", null, "Admin", "ADMIN" }
                });
        }
    }
}
