using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class deletebehavior_setnull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Pages_PageId",
                table: "Contents");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0246f5c4-160d-45f8-8788-1f23292a1abc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a712fbc9-448e-402d-acc8-ff60ef136b9d", "315520eb-d31d-4449-b363-fe10dc244add" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a712fbc9-448e-402d-acc8-ff60ef136b9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "315520eb-d31d-4449-b363-fe10dc244add");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Pages_PageId",
                table: "Contents",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Pages_PageId",
                table: "Contents");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0246f5c4-160d-45f8-8788-1f23292a1abc", null, "User", "USER" },
                    { "a712fbc9-448e-402d-acc8-ff60ef136b9d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "315520eb-d31d-4449-b363-fe10dc244add", 0, "c2475e5c-ced3-438a-a879-f080feb020c2", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEDz+2LtAJeBzz79lkCpx5Q/O1FiVow8+klIM3rJN/IA75ir2C+DAyLLWjSBaat6tHA==", null, false, "289f4839-6185-44b6-938e-75c2d3156879", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a712fbc9-448e-402d-acc8-ff60ef136b9d", "315520eb-d31d-4449-b363-fe10dc244add" });

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Pages_PageId",
                table: "Contents",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
