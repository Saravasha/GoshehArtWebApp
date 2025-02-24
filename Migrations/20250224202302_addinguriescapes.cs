using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addinguriescapes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a067dfa5-df78-45b9-8e4e-3502c20f3310");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0b1e682-a29e-453e-9ed2-ad0cf79e6ae4", "e2ab0035-7a83-441a-8b0b-a763604adc9c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0b1e682-a29e-453e-9ed2-ad0cf79e6ae4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2ab0035-7a83-441a-8b0b-a763604adc9c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28b55915-87ea-48eb-947c-a440c7446e0c", null, "User", "USER" },
                    { "e69ec4bf-5dcb-4809-9226-eabb9f71a936", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b13aa4a8-457f-4ed9-89b1-ab3ce1503c3e", 0, "44dfdeb1-743f-4e3c-8b19-0cade47728ee", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEPRxpjCLtUfKsk52JAZxCrJ5MruiO/AhWTouJOCqbQ/Y8cSo75TYKPRCoCE0oQznYg==", null, false, "3f89f339-d712-49e1-ad34-e20fe259a2c8", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "%2FimagesAsset%2FPictures%2FSidans%20Filer%2FFilmproduktion%2Fimage%20%28287%29.jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "%2FimagesAsset%2FPictures%2FSidans%20Filer%2FKontroversiell%20Konst%2Fimage%20%283%29.jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "%2FimagesAsset%2FPictures%2FSidans%20Filer%2FFilmproduktion%2Fimage%20%28304%29.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e69ec4bf-5dcb-4809-9226-eabb9f71a936", "b13aa4a8-457f-4ed9-89b1-ab3ce1503c3e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28b55915-87ea-48eb-947c-a440c7446e0c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e69ec4bf-5dcb-4809-9226-eabb9f71a936", "b13aa4a8-457f-4ed9-89b1-ab3ce1503c3e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e69ec4bf-5dcb-4809-9226-eabb9f71a936");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b13aa4a8-457f-4ed9-89b1-ab3ce1503c3e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a067dfa5-df78-45b9-8e4e-3502c20f3310", null, "User", "USER" },
                    { "f0b1e682-a29e-453e-9ed2-ad0cf79e6ae4", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e2ab0035-7a83-441a-8b0b-a763604adc9c", 0, "c804d2c2-2c3c-4bf9-b682-6b18d30f8758", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEENd3s5aPH1eqkgJcDsKVWADryKzr1ZFQUvFqn/dEUEIy/4vvKI4ZBOvpG0SbHwdpQ==", null, false, "d9eae6e1-cdb7-4696-99fa-3ec5b38dbdb3", false, "Admin" });

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
                values: new object[] { "f0b1e682-a29e-453e-9ed2-ad0cf79e6ae4", "e2ab0035-7a83-441a-8b0b-a763604adc9c" });
        }
    }
}
