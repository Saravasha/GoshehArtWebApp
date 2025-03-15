using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class tryingToAddContentAsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5a3490-d385-4830-9618-e1aeb6ffdd4b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57d93dd1-bc59-42f1-98d5-18215f1dec59", "44babcd0-39ed-4323-8e8d-715b7503c813" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57d93dd1-bc59-42f1-98d5-18215f1dec59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44babcd0-39ed-4323-8e8d-715b7503c813");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "49867349-a1d0-4501-aa43-b6b3f410d752", null, "Admin", "ADMIN" },
                    { "c04f0234-1de9-42c0-832b-6df380e0e2a1", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "55b2fc52-bb24-4393-bcfa-68a90448be41", 0, "a418a1d3-4b8d-4a84-bfc3-2003027a8d8f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEB57kNxHwJnvP4H3rjAFg0wKhs9YTIdooJSQ5DEj34/PQxY/XiI0u2jYHz+WMkkqWQ==", null, false, "c696ef7c-c1f1-4e32-aecf-245902e0c269", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "49867349-a1d0-4501-aa43-b6b3f410d752", "55b2fc52-bb24-4393-bcfa-68a90448be41" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c04f0234-1de9-42c0-832b-6df380e0e2a1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "49867349-a1d0-4501-aa43-b6b3f410d752", "55b2fc52-bb24-4393-bcfa-68a90448be41" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49867349-a1d0-4501-aa43-b6b3f410d752");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55b2fc52-bb24-4393-bcfa-68a90448be41");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57d93dd1-bc59-42f1-98d5-18215f1dec59", null, "Admin", "ADMIN" },
                    { "9d5a3490-d385-4830-9618-e1aeb6ffdd4b", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "44babcd0-39ed-4323-8e8d-715b7503c813", 0, "9dd4a984-2dc7-4ec8-a728-68215f29e268", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGxGIuNSgdGXIwAQ/NGJhHBbCEDURn6LNDV8h12bTXGgVR1B2Y9q2INndSlIHB7Jdg==", null, false, "cd043688-b9b3-4c90-9153-3e7c30e7e32f", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57d93dd1-bc59-42f1-98d5-18215f1dec59", "44babcd0-39ed-4323-8e8d-715b7503c813" });
        }
    }
}
