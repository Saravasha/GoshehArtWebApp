using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Date_Model_Change_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ac16562-a52c-4fd1-86ff-5479fd96bbdc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9bb7c3e-9f31-4915-b3a0-3d423221c94b", "e4a37691-6612-4ba7-8137-40bedbfe7274" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bb7c3e-9f31-4915-b3a0-3d423221c94b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4a37691-6612-4ba7-8137-40bedbfe7274");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contents",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Assets",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b62d7771-309e-4aa9-918c-b1587c6e0111", null, "Admin", "ADMIN" },
                    { "bd2b027a-1981-4e3f-b650-bba557b5e61d", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f21b6fce-fe01-4650-b6f3-a1036255e028", 0, "834394c7-38ae-4c6b-a032-2195b0d98b1d", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHIbYjW30PRLX9KzKVKafd2u+opQRB2Vr+S0i77o3tJKvd+Zo9NIv6kBlOnEf0YyFQ==", null, false, "a764c9a5-8cc1-48e1-aa00-91b165b3f358", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b62d7771-309e-4aa9-918c-b1587c6e0111", "f21b6fce-fe01-4650-b6f3-a1036255e028" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2b027a-1981-4e3f-b650-bba557b5e61d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b62d7771-309e-4aa9-918c-b1587c6e0111", "f21b6fce-fe01-4650-b6f3-a1036255e028" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b62d7771-309e-4aa9-918c-b1587c6e0111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f21b6fce-fe01-4650-b6f3-a1036255e028");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Assets",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ac16562-a52c-4fd1-86ff-5479fd96bbdc", null, "User", "USER" },
                    { "a9bb7c3e-9f31-4915-b3a0-3d423221c94b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4a37691-6612-4ba7-8137-40bedbfe7274", 0, "2fe6f712-fb2f-4bf5-9912-5391001db29b", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECGEYO4Adqk9TU1BQYrxhk7UpxEEC/kZY2qxtI6Q/pKwZBzLwlJ9LdnQKMdJyGLD7w==", null, false, "e1f99183-acd4-4837-9196-9ed5ef3abcf5", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a9bb7c3e-9f31-4915-b3a0-3d423221c94b", "e4a37691-6612-4ba7-8137-40bedbfe7274" });
        }
    }
}
