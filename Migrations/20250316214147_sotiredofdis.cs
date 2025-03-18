using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class sotiredofdis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "Contents",
                newName: "Container");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24f93699-ec0c-45ae-a88d-83f8b87de5d5", null, "User", "USER" },
                    { "92286967-c96b-488a-ab55-69fd3c63ed67", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "801d4429-3dcc-4752-aa1a-2603e0b1b4a0", 0, "a23c4a30-b05d-4563-9354-4e898f0eb1f6", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEBx2fk+OdUhe4pZn4lWmlQdOCrFC3Mxnc23zhqxKw5wvYxkFqXtYFgXqky2h8mYtsA==", null, false, "b448dab2-4ce3-4ab6-9097-c7bdff1f18cf", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "92286967-c96b-488a-ab55-69fd3c63ed67", "801d4429-3dcc-4752-aa1a-2603e0b1b4a0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24f93699-ec0c-45ae-a88d-83f8b87de5d5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "92286967-c96b-488a-ab55-69fd3c63ed67", "801d4429-3dcc-4752-aa1a-2603e0b1b4a0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92286967-c96b-488a-ab55-69fd3c63ed67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "801d4429-3dcc-4752-aa1a-2603e0b1b4a0");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Pages",
                newName: "PageTitle");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Contents",
                newName: "ContentTitle");

            migrationBuilder.RenameColumn(
                name: "Container",
                table: "Contents",
                newName: "Body");

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
    }
}
