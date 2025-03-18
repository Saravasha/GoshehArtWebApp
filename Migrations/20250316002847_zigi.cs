using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37e411c8-bd25-4d4d-b1d6-9d2741ef8e82");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "74cef872-6ed7-4756-a2f0-246849d64ca6", "4338f087-c5fd-4db3-9752-78f12fd49b37" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74cef872-6ed7-4756-a2f0-246849d64ca6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4338f087-c5fd-4db3-9752-78f12fd49b37");

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
                    { "136d76a5-0f6f-498c-beff-3fe3400cde19", null, "Admin", "ADMIN" },
                    { "ad68b95d-7ffa-4f2f-adf9-1b453b098c48", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4ec4108a-12a4-42d3-b7dc-4ab2f0123738", 0, "d1b1db6e-efb9-495d-bb45-aca128673a34", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEB7hpEHqcdEAH1vfR2AsMSmOvocSnUzNYIHty2jkS8JB9yBKao3y2/qDRmTId7mF5w==", null, false, "a6db8019-e575-498d-8c28-7d4b8fa6b4b9", false, "Admin" });

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
                values: new object[] { "136d76a5-0f6f-498c-beff-3fe3400cde19", "4ec4108a-12a4-42d3-b7dc-4ab2f0123738" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "ad68b95d-7ffa-4f2f-adf9-1b453b098c48");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "136d76a5-0f6f-498c-beff-3fe3400cde19", "4ec4108a-12a4-42d3-b7dc-4ab2f0123738" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "136d76a5-0f6f-498c-beff-3fe3400cde19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ec4108a-12a4-42d3-b7dc-4ab2f0123738");

            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "Pages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37e411c8-bd25-4d4d-b1d6-9d2741ef8e82", null, "User", "USER" },
                    { "74cef872-6ed7-4756-a2f0-246849d64ca6", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4338f087-c5fd-4db3-9752-78f12fd49b37", 0, "dc0e7b31-25eb-468f-8c72-51009d14faff", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEBw/ARUl0e82hq3rY0wwV7fHV1V1ygFEREAY8MSiHnDAzDzQHIVmSqK1TXUvpcABAw==", null, false, "8c3b0d86-721a-45d2-a0e1-58a1f332bc44", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "74cef872-6ed7-4756-a2f0-246849d64ca6", "4338f087-c5fd-4db3-9752-78f12fd49b37" });
        }
    }
}
