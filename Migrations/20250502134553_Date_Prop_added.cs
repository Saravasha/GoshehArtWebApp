using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Date_Prop_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Contents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b774f3f-146b-4801-a6d0-2bf082340334", null, "Admin", "ADMIN" },
                    { "73826d4b-b842-494c-9ab7-901b4193d1f5", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "77c903ae-c29b-4676-866e-670c3d1a5c77", 0, "71eb1d25-0008-4071-a0bc-43652868bcc9", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEMi6ASJRna8OFtbRhV+7khDolpfiO1lOuqo6p8sfVEjCkts9sUtf0U3bfFbgmpu85A==", null, false, "65c3868e-79ba-460f-98d9-9d1cf930692e", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3b774f3f-146b-4801-a6d0-2bf082340334", "77c903ae-c29b-4676-866e-670c3d1a5c77" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73826d4b-b842-494c-9ab7-901b4193d1f5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b774f3f-146b-4801-a6d0-2bf082340334", "77c903ae-c29b-4676-866e-670c3d1a5c77" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b774f3f-146b-4801-a6d0-2bf082340334");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c903ae-c29b-4676-866e-670c3d1a5c77");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Contents");

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
    }
}
