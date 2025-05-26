using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newColorsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "848be8bb-8785-44ab-8788-0d3139d43691");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "977eccef-af21-4e40-86dc-ba66f098af4d");

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BgColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradientColor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0194c0fd-ba32-43a0-8996-d904087b2160", null, "Admin", "ADMIN" },
                    { "49f2df1f-85ec-4b50-86f5-0841e33f2d0a", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "BgColor", "GradientColor" },
                values: new object[] { 1, "bg-white", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0194c0fd-ba32-43a0-8996-d904087b2160");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f2df1f-85ec-4b50-86f5-0841e33f2d0a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "848be8bb-8785-44ab-8788-0d3139d43691", null, "User", "USER" },
                    { "977eccef-af21-4e40-86dc-ba66f098af4d", null, "Admin", "ADMIN" }
                });
        }
    }
}
