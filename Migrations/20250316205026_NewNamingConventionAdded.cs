using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class NewNamingConventionAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d5acf14-30f8-4b89-840d-1c16b2778a64");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07918bec-ac06-457d-b8c3-13a2762f97e4", "8da2b545-e7fb-41b4-9a0a-3b36463b24ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07918bec-ac06-457d-b8c3-13a2762f97e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8da2b545-e7fb-41b4-9a0a-3b36463b24ce");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Pages",
                newName: "PageTitle");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Contents",
                newName: "ContentTitle");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72e892a0-5b07-4da5-b9bf-0d5a96ca8b41", null, "User", "USER" },
                    { "c77bfbab-2518-4b77-8820-6d2de6575908", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eb7ee14d-01fa-4d9d-903e-0c4fbf5baeae", 0, "34890b11-73dc-47fa-b945-176417a5019d", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEFFu3jahJs91FfK4j8iEKvXvexOCILw4nJHgAZwZO4zkZsLkJcg8YkzOQJCdHS3y6A==", null, false, "28a25991-9734-4510-953a-ccbaf89f380a", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c77bfbab-2518-4b77-8820-6d2de6575908", "eb7ee14d-01fa-4d9d-903e-0c4fbf5baeae" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72e892a0-5b07-4da5-b9bf-0d5a96ca8b41");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c77bfbab-2518-4b77-8820-6d2de6575908", "eb7ee14d-01fa-4d9d-903e-0c4fbf5baeae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c77bfbab-2518-4b77-8820-6d2de6575908");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb7ee14d-01fa-4d9d-903e-0c4fbf5baeae");

            migrationBuilder.RenameColumn(
                name: "PageTitle",
                table: "Pages",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ContentTitle",
                table: "Contents",
                newName: "Title");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07918bec-ac06-457d-b8c3-13a2762f97e4", null, "Admin", "ADMIN" },
                    { "8d5acf14-30f8-4b89-840d-1c16b2778a64", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8da2b545-e7fb-41b4-9a0a-3b36463b24ce", 0, "cd346bbe-b334-470d-b85d-b72ba55dc2d7", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJmovvtnwmG1JKCyjMNvPKoVBec+/K7gFruiDoHSO7xTaGGT3Vs3h4epS86MMu39VQ==", null, false, "e012191f-1827-4d6e-874e-f0251271c8a6", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "07918bec-ac06-457d-b8c3-13a2762f97e4", "8da2b545-e7fb-41b4-9a0a-3b36463b24ce" });
        }
    }
}
