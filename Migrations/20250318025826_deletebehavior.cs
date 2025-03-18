using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class deletebehavior : Migration
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
                keyValue: "e892c0f2-df9c-44c8-8355-907ce03b8ebb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1b94e03-80ab-435a-9447-31b0ff0aee48", "58f3799e-48a6-4fa1-9059-5ac486c90a7d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b94e03-80ab-435a-9447-31b0ff0aee48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58f3799e-48a6-4fa1-9059-5ac486c90a7d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "a1b94e03-80ab-435a-9447-31b0ff0aee48", null, "Admin", "ADMIN" },
                    { "e892c0f2-df9c-44c8-8355-907ce03b8ebb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "58f3799e-48a6-4fa1-9059-5ac486c90a7d", 0, "1fa78d54-bbba-43d5-a3fd-863bdd6b1c9c", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAED1Q8f65UUXKxMCdqPCYvTocdRVeTJ11+L8aZ6ioiOH0HGYdcRTMCofMuyC9BgL/1g==", null, false, "87638117-2b10-4031-b974-2c38471faff0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a1b94e03-80ab-435a-9447-31b0ff0aee48", "58f3799e-48a6-4fa1-9059-5ac486c90a7d" });

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Pages_PageId",
                table: "Contents",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id");
        }
    }
}
