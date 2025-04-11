using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class PageIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "844b7939-25d1-44e9-9cd0-a8bdf0c8119c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "007218ec-166a-4793-b7a5-3f110ca2a038", "c175491c-85ab-4824-b260-37a6735ff838" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "007218ec-166a-4793-b7a5-3f110ca2a038");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c175491c-85ab-4824-b260-37a6735ff838");

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
                    { "462e9730-cb2c-474a-a7c5-6a61fa1316d1", null, "User", "USER" },
                    { "63c21377-70e7-474f-92b4-e2e28efee99e", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "409078f8-411c-4832-acb2-17af6d7d4d40", 0, "dd6f3949-7340-4548-840b-75d9cb1126ce", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEK5oYqBpDEaCtT84tffIYs8FNethx+L4AQe1INH7NAjHn2nw+kO1+OjdOfwbSlay7A==", null, false, "f8cd5326-5b26-422e-984c-208c536dfba6", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "63c21377-70e7-474f-92b4-e2e28efee99e", "409078f8-411c-4832-acb2-17af6d7d4d40" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "462e9730-cb2c-474a-a7c5-6a61fa1316d1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63c21377-70e7-474f-92b4-e2e28efee99e", "409078f8-411c-4832-acb2-17af6d7d4d40" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63c21377-70e7-474f-92b4-e2e28efee99e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "409078f8-411c-4832-acb2-17af6d7d4d40");

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
                    { "007218ec-166a-4793-b7a5-3f110ca2a038", null, "Admin", "ADMIN" },
                    { "844b7939-25d1-44e9-9cd0-a8bdf0c8119c", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c175491c-85ab-4824-b260-37a6735ff838", 0, "5dcce677-176c-49d6-bf76-25871bd31c7a", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGiro73/ULp9Zv9Pm9T5OlJR0fdIKOrYoCiuluWxVe6QP+FyMRFe/TxSYMCMItW45g==", null, false, "f3aadc1a-22eb-4395-9844-2816724ab3dc", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "007218ec-166a-4793-b7a5-3f110ca2a038", "c175491c-85ab-4824-b260-37a6735ff838" });
        }
    }
}
