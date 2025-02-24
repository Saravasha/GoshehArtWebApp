using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class tryingagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "00db29f1-fe6a-4781-b5d7-f3de562f7a22", null, "User", "USER" },
                    { "1c438a35-c022-48ff-a937-89c2d3e188fb", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cbba4313-d60c-4efc-aae9-118dc18782f4", 0, "ac161b50-029f-4d4a-9dce-088290184964", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEIy7hEMWp0SwWHtgsGEqJVykgSwXk5RcjyXCcFUiv4TFmlmGQNIaLgoPIIVLKXyGgw==", null, false, "9797cb53-f022-4d0b-aa02-3c9d3236548f", false, "Admin" });

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
                values: new object[] { "1c438a35-c022-48ff-a937-89c2d3e188fb", "cbba4313-d60c-4efc-aae9-118dc18782f4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00db29f1-fe6a-4781-b5d7-f3de562f7a22");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c438a35-c022-48ff-a937-89c2d3e188fb", "cbba4313-d60c-4efc-aae9-118dc18782f4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c438a35-c022-48ff-a937-89c2d3e188fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbba4313-d60c-4efc-aae9-118dc18782f4");

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
    }
}
