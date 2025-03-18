using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class finishingThis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cee39a82-dde0-4f20-bff5-3ab76d128753");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38b18ddb-6d9b-4f2e-a574-d17d5046b050", "32da60ff-205d-4982-9933-1e2de06a4340" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38b18ddb-6d9b-4f2e-a574-d17d5046b050");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32da60ff-205d-4982-9933-1e2de06a4340");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38b18ddb-6d9b-4f2e-a574-d17d5046b050", null, "Admin", "ADMIN" },
                    { "cee39a82-dde0-4f20-bff5-3ab76d128753", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "32da60ff-205d-4982-9933-1e2de06a4340", 0, "8571e8f4-738e-4ffe-88b3-909077e5fae9", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEKXlTJoQbniQrsh5XqhXpjuFvqU3uHqD21giUwQNJ+SgSJENSaYkezqL/ElhCTb/WQ==", null, false, "98b67a3e-bcbe-4b48-9d00-093dc0813dba", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "38b18ddb-6d9b-4f2e-a574-d17d5046b050", "32da60ff-205d-4982-9933-1e2de06a4340" });
        }
    }
}
