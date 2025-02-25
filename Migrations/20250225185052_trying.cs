using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class trying : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "385fa512-eaf5-40be-a939-39f25b0cc924");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "51502c6d-dc39-410c-9d66-d306a0d6fd01", "0db7bdb8-0653-45b4-b87b-6b8816e6da30" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51502c6d-dc39-410c-9d66-d306a0d6fd01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0db7bdb8-0653-45b4-b87b-6b8816e6da30");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72c380f8-ad50-40e9-9748-5f0009b4f3e2", null, "Admin", "ADMIN" },
                    { "d0a4dda3-c2fe-4da0-84fd-4db7b23bda03", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "47d6bda4-1d8a-4ee0-a81f-132a5a5d6f2b", 0, "3738c9b4-2305-4b4f-8df1-caaedcc49267", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEArqiyJFwKYioPKXOWxgdGp2EAqgaC6gCKoEvYgFDt6FN5H1uAXFmg50Pi5YvQ8mCg==", null, false, "f753ed49-77e6-45c7-8f4e-12adb3c29b13", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "72c380f8-ad50-40e9-9748-5f0009b4f3e2", "47d6bda4-1d8a-4ee0-a81f-132a5a5d6f2b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0a4dda3-c2fe-4da0-84fd-4db7b23bda03");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72c380f8-ad50-40e9-9748-5f0009b4f3e2", "47d6bda4-1d8a-4ee0-a81f-132a5a5d6f2b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72c380f8-ad50-40e9-9748-5f0009b4f3e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47d6bda4-1d8a-4ee0-a81f-132a5a5d6f2b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "385fa512-eaf5-40be-a939-39f25b0cc924", null, "User", "USER" },
                    { "51502c6d-dc39-410c-9d66-d306a0d6fd01", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0db7bdb8-0653-45b4-b87b-6b8816e6da30", 0, "74b023b7-67c5-4fe9-8f8a-578c90ad79f9", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEG+0pNTMCdob3ioahCyj7wyiD5VCfohFC0idluamwIC6ZPxUR1fT14BOBb9lOtjRNw==", null, false, "6c7a87a3-ce35-48c7-b3a8-5090b79aa685", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "51502c6d-dc39-410c-9d66-d306a0d6fd01", "0db7bdb8-0653-45b4-b87b-6b8816e6da30" });
        }
    }
}
