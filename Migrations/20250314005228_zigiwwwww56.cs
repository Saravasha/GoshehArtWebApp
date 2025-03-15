using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class zigiwwwww56 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86f02106-7e15-42e8-ac89-5137576eee93");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a8e2689-a81d-4665-b79b-2607c3abe221", "a23fc2e3-465e-4831-9619-6e7afeede665" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a8e2689-a81d-4665-b79b-2607c3abe221");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a23fc2e3-465e-4831-9619-6e7afeede665");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "95dc0f15-895f-4de5-93ac-39af475901a9", null, "User", "USER" },
                    { "9d736b4a-df6b-445b-a8bf-bf3285a680a3", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "51667b73-b567-4758-ac65-37acc80e6a92", 0, "6afb1efc-3264-4433-9d51-ff6b78b55a73", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAELYHZMeP7tmdXQD7jUoWjrBKDvQmu73oOJxt2+rBPBFVa1b2y8QIbNAvePMFP4og9g==", null, false, "03fbc8eb-950e-4b3e-9b14-146a4d5037dd", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d736b4a-df6b-445b-a8bf-bf3285a680a3", "51667b73-b567-4758-ac65-37acc80e6a92" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95dc0f15-895f-4de5-93ac-39af475901a9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d736b4a-df6b-445b-a8bf-bf3285a680a3", "51667b73-b567-4758-ac65-37acc80e6a92" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d736b4a-df6b-445b-a8bf-bf3285a680a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51667b73-b567-4758-ac65-37acc80e6a92");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a8e2689-a81d-4665-b79b-2607c3abe221", null, "Admin", "ADMIN" },
                    { "86f02106-7e15-42e8-ac89-5137576eee93", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a23fc2e3-465e-4831-9619-6e7afeede665", 0, "ba6e1a8a-d5ef-4c3f-99ce-e4fd50f52b05", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAENbtVYAHWfevKunPEVcXsdklPq22mwMf0JMZxJwFFhhPtbuPh5mp56oT1SgtIoEbJg==", null, false, "8f7d0e5a-7b7f-4324-9ef2-47ba9fc176d5", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2a8e2689-a81d-4665-b79b-2607c3abe221", "a23fc2e3-465e-4831-9619-6e7afeede665" });
        }
    }
}
