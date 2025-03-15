using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class newpagesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08d68e25-84eb-4005-b584-e3d903491854", null, "Admin", "ADMIN" },
                    { "f17e7278-95fe-45a1-a4e4-0c947ce2ef09", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cedea83c-28e1-4e93-a0ef-9236105bce4e", 0, "ad1e3ba1-0342-4b54-bfc0-57c286bd604c", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEIQUouH0pK9rVqqM3kdrfHiIF3sJ31Miz3OarHvb9dL2GcAFHSQvTqQFYOoMoNCLSA==", null, false, "d0711217-8c7e-4101-b1e1-76651866843e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "08d68e25-84eb-4005-b584-e3d903491854", "cedea83c-28e1-4e93-a0ef-9236105bce4e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f17e7278-95fe-45a1-a4e4-0c947ce2ef09");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08d68e25-84eb-4005-b584-e3d903491854", "cedea83c-28e1-4e93-a0ef-9236105bce4e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08d68e25-84eb-4005-b584-e3d903491854");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cedea83c-28e1-4e93-a0ef-9236105bce4e");

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
    }
}
