using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newzigi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e94c70c9-4402-4df3-b6d0-bf880499b0c8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c27dd347-2a46-4c75-9ef8-e499f36f56cf", "e7d99e63-5ee6-4e59-8be5-7dbd9253a517" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c27dd347-2a46-4c75-9ef8-e499f36f56cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7d99e63-5ee6-4e59-8be5-7dbd9253a517");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "c27dd347-2a46-4c75-9ef8-e499f36f56cf", null, "Admin", "ADMIN" },
                    { "e94c70c9-4402-4df3-b6d0-bf880499b0c8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e7d99e63-5ee6-4e59-8be5-7dbd9253a517", 0, "955e80c9-d528-4ac9-8e24-c61a244ee2c7", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENvXDrjUBqwghqk9u0NeIToaKatfgfzQwPoRpwpAkyB8PrJQiKE9rAgF4Jkc+Q9lfQ==", null, false, "03be6af0-a8b0-40d6-aaaa-19e536772166", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c27dd347-2a46-4c75-9ef8-e499f36f56cf", "e7d99e63-5ee6-4e59-8be5-7dbd9253a517" });
        }
    }
}
