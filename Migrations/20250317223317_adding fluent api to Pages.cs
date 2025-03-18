using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addingfluentapitoPages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d7f4f7a-9658-4e59-9e0b-07189237f81c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f42759c7-7c74-4384-866a-e86076a77cf0", "7c7c2340-4578-4126-9b33-fa5bd9397b61" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f42759c7-7c74-4384-866a-e86076a77cf0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c7c2340-4578-4126-9b33-fa5bd9397b61");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "84061cc3-3ec0-43a9-b6f6-7280734a2d2b", null, "Admin", "ADMIN" },
                    { "f1ad4657-20e2-414c-9a21-db0df1621aa2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "61705629-9435-4bf2-a2c9-a907c7651b5a", 0, "4ded0589-d58b-4d20-a6a5-ffa79a695b9b", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEGYgWJJX9tMQNqvibFLZh5Tro/jHvP3SfEQ2JSM82dSl1neUeHZw1hvUe90KwxWh0Q==", null, false, "bc8078c8-10e3-4296-825a-9a5f0c639276", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "84061cc3-3ec0-43a9-b6f6-7280734a2d2b", "61705629-9435-4bf2-a2c9-a907c7651b5a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1ad4657-20e2-414c-9a21-db0df1621aa2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84061cc3-3ec0-43a9-b6f6-7280734a2d2b", "61705629-9435-4bf2-a2c9-a907c7651b5a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84061cc3-3ec0-43a9-b6f6-7280734a2d2b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61705629-9435-4bf2-a2c9-a907c7651b5a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d7f4f7a-9658-4e59-9e0b-07189237f81c", null, "User", "USER" },
                    { "f42759c7-7c74-4384-866a-e86076a77cf0", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c7c2340-4578-4126-9b33-fa5bd9397b61", 0, "4941f26a-c6d4-4d1d-9f59-e64d71800916", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEHI04K5hdOOmLlnh1DNcQjqGNhgvFdc1Dru1WEHNDAYsYfVfRWdZYZrx4PqIvSSfig==", null, false, "c6c2aa39-84bd-41cc-bba5-20dd93ee2e25", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f42759c7-7c74-4384-866a-e86076a77cf0", "7c7c2340-4578-4126-9b33-fa5bd9397b61" });
        }
    }
}
