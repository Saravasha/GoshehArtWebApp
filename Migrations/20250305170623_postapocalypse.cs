using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoshehArtWebApp.Migrations
{
    /// <inheritdoc />
    public partial class postapocalypse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cfa678c-c4a6-4c99-9629-0dc47a79d9d8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "845755f5-ce97-40a4-be39-96bec8521abb", "74205d85-5689-4529-8d70-d4c2a3f39366" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "845755f5-ce97-40a4-be39-96bec8521abb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74205d85-5689-4529-8d70-d4c2a3f39366");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ca8adea-98b6-4a62-86c1-0311dac6eff9", null, "Admin", "ADMIN" },
                    { "8d53c702-e681-47e6-97f9-e187f5a9e902", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1f8a5396-748c-42ed-8c59-202f3399ca9d", 0, "778f75db-bc9b-48f6-971d-31118c375741", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEG9IxtgQVVC3tA9zAjYv+o9Yo/58aujOVczFFR6D2vVm2hV7dcBIDf8Auy3zV35i7Q==", null, false, "9e24087a-4270-48e6-9794-32b6386208c1", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0ca8adea-98b6-4a62-86c1-0311dac6eff9", "1f8a5396-748c-42ed-8c59-202f3399ca9d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d53c702-e681-47e6-97f9-e187f5a9e902");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ca8adea-98b6-4a62-86c1-0311dac6eff9", "1f8a5396-748c-42ed-8c59-202f3399ca9d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ca8adea-98b6-4a62-86c1-0311dac6eff9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f8a5396-748c-42ed-8c59-202f3399ca9d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6cfa678c-c4a6-4c99-9629-0dc47a79d9d8", null, "User", "USER" },
                    { "845755f5-ce97-40a4-be39-96bec8521abb", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "74205d85-5689-4529-8d70-d4c2a3f39366", 0, "b6452704-d6ee-4377-8ae7-7328fb235867", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEOpm5HvIoBxD+0fFMh7kM1d+nxPpL6acqDUddJWmjgmg5BpzuwyWHGeSyIvXazFJ7g==", null, false, "64bf76fb-146a-4091-a680-e2cdc3ab6481", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "845755f5-ce97-40a4-be39-96bec8521abb", "74205d85-5689-4529-8d70-d4c2a3f39366" });
        }
    }
}
