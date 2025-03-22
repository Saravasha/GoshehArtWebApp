using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class didweforgettomigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98822663-766a-4eee-8c36-0e61d7ed9d84");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3188e6fc-2d39-41a4-879b-8040456dc8f3", "0b298642-74b8-42fb-9bb8-ff41e536fb8a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3188e6fc-2d39-41a4-879b-8040456dc8f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b298642-74b8-42fb-9bb8-ff41e536fb8a");

            migrationBuilder.AlterColumn<int>(
                name: "PageId",
                table: "Contents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "478e015a-cd30-49fb-83d8-ab1cc7638c0a", null, "User", "USER" },
                    { "e80c3ed6-52df-4c49-b8ec-582d320ec695", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b4ac291c-e581-4f74-a297-2236753a2e8e", 0, "831fa883-1372-49c3-8e66-2222355c6859", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEPYSnOPnm3/F/WmB39hZ4PUW8nWtmHFtBV+tG3d5QXS3D/kiAm1a/EUoXGpycOPZpw==", null, false, "4f16013c-8ae1-46d3-9850-907d6b24249f", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e80c3ed6-52df-4c49-b8ec-582d320ec695", "b4ac291c-e581-4f74-a297-2236753a2e8e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "478e015a-cd30-49fb-83d8-ab1cc7638c0a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e80c3ed6-52df-4c49-b8ec-582d320ec695", "b4ac291c-e581-4f74-a297-2236753a2e8e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e80c3ed6-52df-4c49-b8ec-582d320ec695");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4ac291c-e581-4f74-a297-2236753a2e8e");

            migrationBuilder.AlterColumn<int>(
                name: "PageId",
                table: "Contents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3188e6fc-2d39-41a4-879b-8040456dc8f3", null, "Admin", "ADMIN" },
                    { "98822663-766a-4eee-8c36-0e61d7ed9d84", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0b298642-74b8-42fb-9bb8-ff41e536fb8a", 0, "2bda3ffe-fa66-4320-87b8-c3ec8d37895f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEL1zm+BVE4mH04Sq7p7Whh7KdDohZOJLeRJMjGd1RmeilNI6o4m37xe8pRF2c6lY1Q==", null, false, "70847ee3-5ad3-44ec-80e5-07f776de077a", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3188e6fc-2d39-41a4-879b-8040456dc8f3", "0b298642-74b8-42fb-9bb8-ff41e536fb8a" });
        }
    }
}
