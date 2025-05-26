using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class updatingcolorentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40e8d240-fc1d-498b-9b81-f5da3dea8af9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdb95523-7a4d-4662-95b2-07520bb54f68");

            migrationBuilder.AlterColumn<string>(
                name: "StartColor",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DarkEndColor",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DarkStartColor",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "DarkEndColor", "DarkStartColor" },
                values: new object[] { "gradientNotSet", "bg-black" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "604c59dd-f4e2-4ce9-85e1-d3e6e161329b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1e33f2f-0230-4236-bbde-3c9935b4eb0f");

            migrationBuilder.DropColumn(
                name: "DarkEndColor",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "DarkStartColor",
                table: "Colors");

            migrationBuilder.AlterColumn<string>(
                name: "StartColor",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40e8d240-fc1d-498b-9b81-f5da3dea8af9", null, "User", "USER" },
                    { "fdb95523-7a4d-4662-95b2-07520bb54f68", null, "Admin", "ADMIN" }
                });
        }
    }
}
