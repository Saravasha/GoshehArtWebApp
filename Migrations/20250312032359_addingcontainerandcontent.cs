using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addingcontainerandcontent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Pages",
                newName: "Container");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a632101-48d2-4d7b-9c8d-c204665564e3", null, "Admin", "ADMIN" },
                    { "c06fd4b2-e709-4e8d-9ce7-b9892a63d4d3", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5cfb79fd-f5a7-4dba-a162-18344f7d57b0", 0, "3442ce7d-6bcb-431a-accd-91bc02cd0d58", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEMDrNNbxNA0KYG+sYM1G0bVC9vCj+nhdpd3qOFOvKj/xS6gZuxKVDczwiNiJBY5GjQ==", null, false, "5bffb670-f0ed-46c9-b5e7-e49a6e78cffa", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1a632101-48d2-4d7b-9c8d-c204665564e3", "5cfb79fd-f5a7-4dba-a162-18344f7d57b0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c06fd4b2-e709-4e8d-9ce7-b9892a63d4d3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a632101-48d2-4d7b-9c8d-c204665564e3", "5cfb79fd-f5a7-4dba-a162-18344f7d57b0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a632101-48d2-4d7b-9c8d-c204665564e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cfb79fd-f5a7-4dba-a162-18344f7d57b0");

            migrationBuilder.RenameColumn(
                name: "Container",
                table: "Pages",
                newName: "Header");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2def0e5-6f34-43d3-82e7-4bec1cc62a03", "9b18fee2-be95-4438-8e18-3f5a46441b5e" });
        }
    }
}
