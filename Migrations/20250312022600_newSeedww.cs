using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newSeedww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "120f7d19-1012-40d5-b28d-e81de18077d8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ee91e16-3be2-475a-a524-1324b39d18b7", "536d5330-5bda-4cb3-8a29-68709b96ca7b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ee91e16-3be2-475a-a524-1324b39d18b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "536d5330-5bda-4cb3-8a29-68709b96ca7b");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b454010-d6b8-4eb4-a63f-9792ed64f431", null, "User", "USER" },
                    { "e2def0e5-6f34-43d3-82e7-4bec1cc62a03", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9b18fee2-be95-4438-8e18-3f5a46441b5e", 0, "30a9ca39-bd01-4b6e-bf3e-bda8fd80325f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEFW1e3DQB0EgfjT2SeqN1ija3M+0RUqH5oJJub/Xq6K6ezrhhe0/ODRXB+vw/1FqSw==", null, false, "1613a35a-3a9f-454b-9492-d8a0ce7f4be5", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ContentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ContentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ContentId",
                value: 1);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2def0e5-6f34-43d3-82e7-4bec1cc62a03", "9b18fee2-be95-4438-8e18-3f5a46441b5e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b454010-d6b8-4eb4-a63f-9792ed64f431");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2def0e5-6f34-43d3-82e7-4bec1cc62a03", "9b18fee2-be95-4438-8e18-3f5a46441b5e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2def0e5-6f34-43d3-82e7-4bec1cc62a03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b18fee2-be95-4438-8e18-3f5a46441b5e");

            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "Pages");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "120f7d19-1012-40d5-b28d-e81de18077d8", null, "User", "USER" },
                    { "9ee91e16-3be2-475a-a524-1324b39d18b7", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "536d5330-5bda-4cb3-8a29-68709b96ca7b", 0, "8e503a06-3838-42da-9a42-530e16a90f7e", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAECpbuUlTDAfgqqQjSJjzgVlsE/ek9nfNUXzAPPTb4V2lD2E8O1lhKLFIsoZFQdxvkw==", null, false, "29ffe87c-947a-411e-9c1a-5bc1684f35bf", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9ee91e16-3be2-475a-a524-1324b39d18b7", "536d5330-5bda-4cb3-8a29-68709b96ca7b" });
        }
    }
}
