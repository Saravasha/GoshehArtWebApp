using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class new_multipart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "a1b94e03-80ab-435a-9447-31b0ff0aee48", null, "Admin", "ADMIN" },
                    { "e892c0f2-df9c-44c8-8355-907ce03b8ebb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "58f3799e-48a6-4fa1-9059-5ac486c90a7d", 0, "1fa78d54-bbba-43d5-a3fd-863bdd6b1c9c", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAED1Q8f65UUXKxMCdqPCYvTocdRVeTJ11+L8aZ6ioiOH0HGYdcRTMCofMuyC9BgL/1g==", null, false, "87638117-2b10-4031-b974-2c38471faff0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a1b94e03-80ab-435a-9447-31b0ff0aee48", "58f3799e-48a6-4fa1-9059-5ac486c90a7d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e892c0f2-df9c-44c8-8355-907ce03b8ebb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1b94e03-80ab-435a-9447-31b0ff0aee48", "58f3799e-48a6-4fa1-9059-5ac486c90a7d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b94e03-80ab-435a-9447-31b0ff0aee48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58f3799e-48a6-4fa1-9059-5ac486c90a7d");

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
    }
}
