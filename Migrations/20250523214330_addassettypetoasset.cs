using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addassettypetoasset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89559e30-6dc8-4ee0-9689-1c197ee74725");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f86aef39-730d-40b0-83db-09cfd1326a49");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e6909c6-9453-48bd-a781-b95125a17faa", null, "User", "USER" },
                    { "ef5789e7-20f1-4ac9-8b1b-15246b55f84d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e6909c6-9453-48bd-a781-b95125a17faa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef5789e7-20f1-4ac9-8b1b-15246b55f84d");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Assets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "89559e30-6dc8-4ee0-9689-1c197ee74725", null, "User", "USER" },
                    { "f86aef39-730d-40b0-83db-09cfd1326a49", null, "Admin", "ADMIN" }
                });
        }
    }
}
