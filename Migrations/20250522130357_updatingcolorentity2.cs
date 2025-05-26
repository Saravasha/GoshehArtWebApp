using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class updatingcolorentity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "604c59dd-f4e2-4ce9-85e1-d3e6e161329b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1e33f2f-0230-4236-bbde-3c9935b4eb0f");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "604c59dd-f4e2-4ce9-85e1-d3e6e161329b", null, "User", "USER" },
                    { "a1e33f2f-0230-4236-bbde-3c9935b4eb0f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DarkEndColor", "DarkStartColor", "EndColor", "StartColor" },
                values: new object[] { "gradientNotSet", "bg-black", "gradientNotSet", "bg-white" });
        }
    }
}
