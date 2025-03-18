using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiwwwwwwwww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Contents_ContentId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_ContentId",
                table: "Pages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "748a0aaa-89fa-475c-8f6c-3c66441aa655");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "334494b4-1e6c-4424-a31f-34b21c395be8", "20896606-90f9-4b01-94a0-a0a165f11aa6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "334494b4-1e6c-4424-a31f-34b21c395be8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20896606-90f9-4b01-94a0-a0a165f11aa6");

            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "Pages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "208672f1-7446-41c3-ae24-655e77e2832b", null, "Admin", "ADMIN" },
                    { "78710c15-3a49-4d94-966b-764558613965", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "acc19888-4bfc-48d4-a4b6-33fc06cb8f55", 0, "5ffcccdb-2739-48c0-82dc-9f2e32191369", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEABfR6NaUzRKivBi1sckvCErfqHsdNNaqev+rApbpq2oUX2RC+GsSZlgmlx+e9QHEA==", null, false, "294536d1-12b9-40c5-9ba8-c8bdb73dc7fb", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "208672f1-7446-41c3-ae24-655e77e2832b", "acc19888-4bfc-48d4-a4b6-33fc06cb8f55" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78710c15-3a49-4d94-966b-764558613965");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "208672f1-7446-41c3-ae24-655e77e2832b", "acc19888-4bfc-48d4-a4b6-33fc06cb8f55" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "208672f1-7446-41c3-ae24-655e77e2832b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acc19888-4bfc-48d4-a4b6-33fc06cb8f55");

            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "Pages",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "334494b4-1e6c-4424-a31f-34b21c395be8", null, "Admin", "ADMIN" },
                    { "748a0aaa-89fa-475c-8f6c-3c66441aa655", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "20896606-90f9-4b01-94a0-a0a165f11aa6", 0, "0e58c04b-3190-4d88-a2d1-7451696e08d3", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEKL/zfh1+xQ7UahWb7m6jlxFUBiWY8LOp9ZpUioeYJUIK2DCp3kvG8QGlbd0HAvSAQ==", null, false, "74101aff-3777-478c-a16a-2e464d13682a", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ContentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ContentId",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "334494b4-1e6c-4424-a31f-34b21c395be8", "20896606-90f9-4b01-94a0-a0a165f11aa6" });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ContentId",
                table: "Pages",
                column: "ContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Contents_ContentId",
                table: "Pages",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id");
        }
    }
}
