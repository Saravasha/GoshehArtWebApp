using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "334494b4-1e6c-4424-a31f-34b21c395be8", "20896606-90f9-4b01-94a0-a0a165f11aa6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "136d76a5-0f6f-498c-beff-3fe3400cde19", "4ec4108a-12a4-42d3-b7dc-4ab2f0123738" });
        }
    }
}
