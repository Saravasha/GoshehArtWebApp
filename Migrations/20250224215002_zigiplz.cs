using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiplz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a272fa6-353b-4195-a37e-f85aed921874");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f00cd4cb-7cb3-4c66-b90f-e95f04bd1cd3", "4b5c62ab-2704-4c88-a37c-2dcfb141f86d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f00cd4cb-7cb3-4c66-b90f-e95f04bd1cd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b5c62ab-2704-4c88-a37c-2dcfb141f86d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0395f328-7436-4f72-b1d0-ce076a78eaeb", null, "Admin", "ADMIN" },
                    { "ca70e8b6-55f4-4f29-a0d0-c1332b26a256", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "59b0c4b8-5fb8-4d97-9308-4c133dc544db", 0, "5d09733c-ac42-4d83-ab99-192c3ac26a27", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEBxWGdWnGQ6fDf6E6RsmLe2ULecKip2YArSpiSU9hQNjLeJ9vzMXN3E2KoaDSoYvtQ==", null, false, "a0d65114-5ddd-40bf-b71d-b6a053c81195", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "imagesAsset\\Pictures\\Sidans Filer\\Filmproduktion\\image(287).jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0395f328-7436-4f72-b1d0-ce076a78eaeb", "59b0c4b8-5fb8-4d97-9308-4c133dc544db" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca70e8b6-55f4-4f29-a0d0-c1332b26a256");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0395f328-7436-4f72-b1d0-ce076a78eaeb", "59b0c4b8-5fb8-4d97-9308-4c133dc544db" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0395f328-7436-4f72-b1d0-ce076a78eaeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59b0c4b8-5fb8-4d97-9308-4c133dc544db");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a272fa6-353b-4195-a37e-f85aed921874", null, "User", "USER" },
                    { "f00cd4cb-7cb3-4c66-b90f-e95f04bd1cd3", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4b5c62ab-2704-4c88-a37c-2dcfb141f86d", 0, "a880b18a-29ad-43ab-986f-031fd8a0a57c", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJ4EaqU9uWCaVg6pjgnaPxgc2qd0FUgOB7qhWJ25ZheWvYySxgMXpnep8S+mb40V3w==", null, false, "49a46ab1-6572-4762-9b4e-1272373c0c09", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "imagesAsset\\Pictures\\Sidans Filer\\Filmproduktion\\image (287).jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f00cd4cb-7cb3-4c66-b90f-e95f04bd1cd3", "4b5c62ab-2704-4c88-a37c-2dcfb141f86d" });
        }
    }
}
