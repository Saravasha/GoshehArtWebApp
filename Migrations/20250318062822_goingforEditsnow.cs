using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class goingforEditsnow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b06f0449-91a9-46c0-92ef-31b803b7715f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a8e1933-2f99-4db2-9b1c-1f1c0b874d8f", "5a54dc9d-99a6-46d9-8ae2-4b02722c716d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8e1933-2f99-4db2-9b1c-1f1c0b874d8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a54dc9d-99a6-46d9-8ae2-4b02722c716d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "4a8e1933-2f99-4db2-9b1c-1f1c0b874d8f", null, "Admin", "ADMIN" },
                    { "b06f0449-91a9-46c0-92ef-31b803b7715f", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5a54dc9d-99a6-46d9-8ae2-4b02722c716d", 0, "3d7f0094-a111-4d18-acfb-807359668edf", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEDdq48F0dvDEB5V4WjYXTbJoCeENJ1MYNB4bzjJEq2kMOf41YUyL+GQ8GUqS3xme1A==", null, false, "249ac360-5784-4bb7-8472-82c9bb4da516", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a8e1933-2f99-4db2-9b1c-1f1c0b874d8f", "5a54dc9d-99a6-46d9-8ae2-4b02722c716d" });
        }
    }
}
