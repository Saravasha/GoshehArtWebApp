using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class finishedaddingpathcombinestoallurlstringsincontrollers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "576aeeb5-a5b6-4abf-8eed-cb2322588cd7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1beaa913-8b57-452c-8306-57433ec61835", "828c3c6d-ee3b-4a4a-b6ac-8599893763f5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1beaa913-8b57-452c-8306-57433ec61835");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "828c3c6d-ee3b-4a4a-b6ac-8599893763f5");

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
                values: new object[] { "f00cd4cb-7cb3-4c66-b90f-e95f04bd1cd3", "4b5c62ab-2704-4c88-a37c-2dcfb141f86d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "1beaa913-8b57-452c-8306-57433ec61835", null, "Admin", "ADMIN" },
                    { "576aeeb5-a5b6-4abf-8eed-cb2322588cd7", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "828c3c6d-ee3b-4a4a-b6ac-8599893763f5", 0, "f153ebf4-104d-418a-8bdd-d4e49deac32e", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGf3exXPt7/dFgFvAEEcpOOjHgZRkSy5HdUppRwFjzbFUigaMQ5GB1uhKO5rdGkkOw==", null, false, "1762f99e-ea79-47c9-bc7c-92b696d295e5", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "imagesAsset/Pictures\\Sidans Filer\\Filmproduktion\\image (287).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "imagesAsset/Pictures\\Sidans Filer\\Kontroversiell Konst\\image (3).jpg");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "imagesAsset/Pictures\\Sidans Filer\\Filmproduktion\\image (304).jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1beaa913-8b57-452c-8306-57433ec61835", "828c3c6d-ee3b-4a4a-b6ac-8599893763f5" });
        }
    }
}
