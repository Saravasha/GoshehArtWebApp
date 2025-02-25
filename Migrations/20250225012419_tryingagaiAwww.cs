using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class tryingagaiAwww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adbf2958-c76e-4d09-8831-af82ea945853");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "569fc238-91ba-4f4e-a57f-2ca263a0c794", "55cb6588-0814-44b2-8bd6-7dee260ecd27" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "569fc238-91ba-4f4e-a57f-2ca263a0c794");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55cb6588-0814-44b2-8bd6-7dee260ecd27");

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

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/imagesAsset/Pictures/Sidans Filer/Filmproduktion/image (287).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/imagesAsset/Pictures/Sidans Filer/Kontroversiell Konst/image (3).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/imagesAsset/Pictures/Sidans Filer/Filmproduktion/image (304).jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "51502c6d-dc39-410c-9d66-d306a0d6fd01", "0db7bdb8-0653-45b4-b87b-6b8816e6da30" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "569fc238-91ba-4f4e-a57f-2ca263a0c794", null, "Admin", "ADMIN" },
                    { "adbf2958-c76e-4d09-8831-af82ea945853", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "55cb6588-0814-44b2-8bd6-7dee260ecd27", 0, "0d3429d6-3cea-4c89-948a-e40f3ab8b1f3", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEIlRL/z9dLbLhmLcZPzlDbAAercCOZOwZ5Uy1GnlXMi9PJymL/qXX17YD24EModbVA==", null, false, "66ee1c3b-8e2a-4f5b-93c9-573647fccf4d", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "imagesAsset\\Pictures\\Sidans Filer\\Filmproduktion\\image (287).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "imagesAsset\\Pictures\\Sidans Filer\\Kontroversiell Konst\\image (3).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "imagesAsset\\Pictures\\Sidans Filer\\Filmproduktion\\image (304).jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "569fc238-91ba-4f4e-a57f-2ca263a0c794", "55cb6588-0814-44b2-8bd6-7dee260ecd27" });
        }
    }
}
