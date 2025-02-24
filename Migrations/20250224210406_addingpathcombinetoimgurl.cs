using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addingpathcombinetoimgurl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
